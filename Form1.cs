using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace hangman_game
{
    public partial class Form1 : Form
    {
        private List<string> words = null!;
        private string currentWord = null!;
        private char[] guessedWord = null!;
        private List<char> wrongLetters = null!;
        private int remainingGuesses;
        private bool gameActive;
        private List<TextBox> letterBoxes = null!;
        private Random random = null!;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            words = new List<string>();
            wrongLetters = new List<char>();
            letterBoxes = new List<TextBox>();
            random = new Random();
            LoadWords();
            UpdateHangmanDisplay();
            lblWrongLettersText.Text = "";
            lblRemainingGuessesText.Text = "";
            gameActive = false;
        }

        private void LoadWords()
        {
            try
            {
                // Önce çalışma dizininde ara
                string wordsFilePath = "words.txt";
                
                if (!File.Exists(wordsFilePath))
                {
                    // Eğer bulunamazsa, uygulama dizininde ara
                    string appDirectory = Path.GetDirectoryName(Application.ExecutablePath) ?? "";
                    wordsFilePath = Path.Combine(appDirectory, "words.txt");
                }
                
                if (File.Exists(wordsFilePath))
                {
                    words = File.ReadAllLines(wordsFilePath)
                        .Where(line => !string.IsNullOrWhiteSpace(line))
                        .Select(word => word.Trim().ToUpper())
                        .ToList();
                }
                else
                {
                    // Dosya bulunamazsa varsayılan kelimeler ekle
                    words = new List<string> { "ELMA", "ARMUT", "KALEM", "KİTAP", "MASA", "SANDALYE" };
                    MessageBox.Show("Kelime dosyası bulunamadı! Varsayılan kelimeler kullanılıyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kelime dosyası yüklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Hata durumunda varsayılan kelimeler ekle
                words = new List<string> { "ELMA", "ARMUT", "KALEM", "KİTAP", "MASA", "SANDALYE" };
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtWordLength.Text, out int wordLength) || wordLength <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir kelime uzunluğu girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var suitableWords = words.Where(w => w.Length == wordLength).ToList();
            if (suitableWords.Count == 0)
            {
                MessageBox.Show($"Bu uzunlukta kelime bulunamadı! Mevcut uzunluklar: {string.Join(", ", words.Select(w => w.Length).Distinct().OrderBy(x => x))}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StartNewGame(suitableWords[random.Next(suitableWords.Count)]);
        }

        private void btnRandomWord_Click(object sender, EventArgs e)
        {
            if (words.Count == 0)
            {
                MessageBox.Show("Kelime veritabanı boş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StartNewGame(words[random.Next(words.Count)]);
        }

        private void StartNewGame(string word)
        {
            currentWord = word;
            guessedWord = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                guessedWord[i] = '_';
            }

            remainingGuesses = word.Length + 2; // Kelime uzunluğunun 2 fazlası kadar hak
            wrongLetters.Clear();
            gameActive = true;

            CreateLetterBoxes();
            UpdateDisplay();
            txtLetterGuess.Clear();
            txtLetterGuess.Focus();
        }

        private void CreateLetterBoxes()
        {
            panelWord.Controls.Clear();
            letterBoxes.Clear();

            int boxWidth = 30;
            int boxHeight = 30;
            int spacing = 5;
            int totalWidth = currentWord.Length * (boxWidth + spacing) - spacing;
            int startX = (panelWord.Width - totalWidth) / 2;

            for (int i = 0; i < currentWord.Length; i++)
            {
                TextBox letterBox = new TextBox
                {
                    Location = new System.Drawing.Point(startX + i * (boxWidth + spacing), 10),
                    Size = new System.Drawing.Size(boxWidth, boxHeight),
                    Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold),
                    TextAlign = HorizontalAlignment.Center,
                    ReadOnly = true,
                    Text = "_"
                };
                letterBoxes.Add(letterBox);
                panelWord.Controls.Add(letterBox);
            }
        }

        private void btnGuessLetter_Click(object sender, EventArgs e)
        {
            if (!gameActive)
            {
                MessageBox.Show("Önce bir oyun başlatın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLetterGuess.Text))
            {
                MessageBox.Show("Lütfen bir harf girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char guess = txtLetterGuess.Text.ToUpper()[0];
            
            // Türkçe karakterleri kontrol et
            if (!char.IsLetter(guess))
            {
                MessageBox.Show("Lütfen geçerli bir harf girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLetterGuess.Clear();
                return;
            }

            // Harf tekrarını kontrol et
            if (wrongLetters.Contains(guess) || guessedWord.Contains(guess))
            {
                MessageBox.Show("Bu harfi zaten tahmin ettiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLetterGuess.Clear();
                return;
            }

            bool correctGuess = false;
            for (int i = 0; i < currentWord.Length; i++)
            {
                if (currentWord[i] == guess)
                {
                    guessedWord[i] = guess;
                    letterBoxes[i].Text = guess.ToString();
                    correctGuess = true;
                }
            }

            if (!correctGuess)
            {
                wrongLetters.Add(guess);
                remainingGuesses--;
            }

            txtLetterGuess.Clear();
            UpdateDisplay();

            // Oyun sonu kontrolü
            if (remainingGuesses <= 0)
            {
                gameActive = false;
                MessageBox.Show($"Kaybettiniz! Kelime: {currentWord}", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveScore(0, remainingGuesses);
            }
            else if (!guessedWord.Contains('_'))
            {
                gameActive = false;
                int score = CalculateScore();
                MessageBox.Show($"Tebrikler! Kelimeyi buldunuz: {currentWord}\nSkorunuz: {score}", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveScore(score, remainingGuesses);
            }
        }

        private void UpdateDisplay()
        {
            lblWrongLettersText.Text = string.Join(" ", wrongLetters);
            lblRemainingGuessesText.Text = remainingGuesses.ToString();
            UpdateHangmanDisplay();
        }

        private void UpdateHangmanDisplay()
        {
            string[] hangmanStages = {
                "  +---+\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n=========",
                "  +---+\r\n  |   |\r\n  O   |\r\n      |\r\n      |\r\n=========",
                "  +---+\r\n  |   |\r\n  O   |\r\n  |   |\r\n      |\r\n=========",
                "  +---+\r\n  |   |\r\n  O   |\r\n /|   |\r\n      |\r\n=========",
                "  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n      |\r\n=========",
                "  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n /    |\r\n=========",
                "  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n / \\  |\r\n========="
            };

            int wrongCount = wrongLetters.Count;
            int stageIndex = Math.Min(wrongCount, hangmanStages.Length - 1);
            lblHangman.Text = hangmanStages[stageIndex];
        }

        private int CalculateScore()
        {
            // Basit skor hesaplama: kelime uzunluğu * 10 + kalan hak * 5
            return currentWord.Length * 10 + remainingGuesses * 5;
        }

        private void SaveScore(int score, int remainingGuesses)
        {
            try
            {
                string playerName = Microsoft.VisualBasic.Interaction.InputBox("Skorunuzu kaydetmek için adınızı girin:", "Skor Kaydet", "Oyuncu");
                if (!string.IsNullOrWhiteSpace(playerName))
                {
                    string scoreLine = $"{playerName},{score},{remainingGuesses}";
                    File.AppendAllText("scores.txt", scoreLine + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Skor kaydedilirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            InitializeGame();
            panelWord.Controls.Clear();
            txtWordLength.Clear();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            string newWord = txtAddWord.Text.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(newWord))
            {
                MessageBox.Show("Lütfen bir kelime girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!newWord.All(char.IsLetter))
            {
                MessageBox.Show("Kelime sadece harflerden oluşmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (words.Contains(newWord))
            {
                MessageBox.Show("Bu kelime zaten mevcut!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                File.AppendAllText("words.txt", newWord + Environment.NewLine);
                words.Add(newWord);
                txtAddWord.Clear();
                MessageBox.Show("Kelime başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kelime eklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteWord_Click(object sender, EventArgs e)
        {
            string wordToDelete = txtDeleteWord.Text.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(wordToDelete))
            {
                MessageBox.Show("Lütfen silinecek kelimeyi girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!words.Contains(wordToDelete))
            {
                MessageBox.Show("Bu kelime veritabanında bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                words.Remove(wordToDelete);
                File.WriteAllLines("words.txt", words);
                txtDeleteWord.Clear();
                MessageBox.Show("Kelime başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kelime silinirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowScores_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("scores.txt"))
                {
                    var scores = File.ReadAllLines("scores.txt")
                        .Where(line => !string.IsNullOrWhiteSpace(line))
                        .Select(line =>
                        {
                            var parts = line.Split(',');
                            return new { Name = parts[0], Score = int.Parse(parts[1]), Remaining = int.Parse(parts[2]) };
                        })
                        .OrderByDescending(x => x.Score)
                        .ThenByDescending(x => x.Remaining)
                        .Take(10);

                    string scoreText = "EN İYİ 10 SKOR:\n\n";
                    int rank = 1;
                    foreach (var score in scores)
                    {
                        scoreText += $"{rank}. {score.Name} - Skor: {score.Score} (Kalan Hak: {score.Remaining})\n";
                        rank++;
                    }

                    MessageBox.Show(scoreText, "Skor Listesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Henüz skor kaydedilmemiş!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Skorlar yüklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
