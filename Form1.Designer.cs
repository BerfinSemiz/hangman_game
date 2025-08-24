namespace hangman_game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWordLength = new System.Windows.Forms.Label();
            this.txtWordLength = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnRandomWord = new System.Windows.Forms.Button();
            this.panelWord = new System.Windows.Forms.Panel();
            this.lblHangman = new System.Windows.Forms.Label();
            this.lblWrongLetters = new System.Windows.Forms.Label();
            this.lblWrongLettersText = new System.Windows.Forms.Label();
            this.lblRemainingGuesses = new System.Windows.Forms.Label();
            this.lblRemainingGuessesText = new System.Windows.Forms.Label();
            this.txtLetterGuess = new System.Windows.Forms.TextBox();
            this.btnGuessLetter = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnDeleteWord = new System.Windows.Forms.Button();
            this.btnShowScores = new System.Windows.Forms.Button();
            this.txtAddWord = new System.Windows.Forms.TextBox();
            this.txtDeleteWord = new System.Windows.Forms.TextBox();
            this.lblAddWord = new System.Windows.Forms.Label();
            this.lblDeleteWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(300, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ADAM ASMACA";
            // 
            // lblWordLength
            // 
            this.lblWordLength.AutoSize = true;
            this.lblWordLength.Location = new System.Drawing.Point(50, 80);
            this.lblWordLength.Name = "lblWordLength";
            this.lblWordLength.Size = new System.Drawing.Size(100, 15);
            this.lblWordLength.TabIndex = 1;
            this.lblWordLength.Text = "Kelime Uzunluğu:";
            // 
            // txtWordLength
            // 
            this.txtWordLength.Location = new System.Drawing.Point(160, 77);
            this.txtWordLength.Name = "txtWordLength";
            this.txtWordLength.Size = new System.Drawing.Size(100, 23);
            this.txtWordLength.TabIndex = 2;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(280, 75);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(100, 25);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Oyunu Başlat";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnRandomWord
            // 
            this.btnRandomWord.Location = new System.Drawing.Point(400, 75);
            this.btnRandomWord.Name = "btnRandomWord";
            this.btnRandomWord.Size = new System.Drawing.Size(120, 25);
            this.btnRandomWord.TabIndex = 4;
            this.btnRandomWord.Text = "Rastgele Kelime";
            this.btnRandomWord.UseVisualStyleBackColor = true;
            this.btnRandomWord.Click += new System.EventHandler(this.btnRandomWord_Click);
            // 
            // panelWord
            // 
            this.panelWord.Location = new System.Drawing.Point(50, 120);
            this.panelWord.Name = "panelWord";
            this.panelWord.Size = new System.Drawing.Size(600, 50);
            this.panelWord.TabIndex = 5;
            // 
            // lblHangman
            // 
            this.lblHangman.AutoSize = true;
            this.lblHangman.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHangman.Location = new System.Drawing.Point(50, 200);
            this.lblHangman.Name = "lblHangman";
            this.lblHangman.Size = new System.Drawing.Size(200, 18);
            this.lblHangman.TabIndex = 6;
            this.lblHangman.Text = "  +---+\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n=========";
            // 
            // lblWrongLetters
            // 
            this.lblWrongLetters.AutoSize = true;
            this.lblWrongLetters.Location = new System.Drawing.Point(300, 200);
            this.lblWrongLetters.Name = "lblWrongLetters";
            this.lblWrongLetters.Size = new System.Drawing.Size(100, 15);
            this.lblWrongLetters.TabIndex = 7;
            this.lblWrongLetters.Text = "Yanlış Harfler:";
            // 
            // lblWrongLettersText
            // 
            this.lblWrongLettersText.AutoSize = true;
            this.lblWrongLettersText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWrongLettersText.Location = new System.Drawing.Point(300, 220);
            this.lblWrongLettersText.Name = "lblWrongLettersText";
            this.lblWrongLettersText.Size = new System.Drawing.Size(0, 21);
            this.lblWrongLettersText.TabIndex = 8;
            // 
            // lblRemainingGuesses
            // 
            this.lblRemainingGuesses.AutoSize = true;
            this.lblRemainingGuesses.Location = new System.Drawing.Point(300, 250);
            this.lblRemainingGuesses.Name = "lblRemainingGuesses";
            this.lblRemainingGuesses.Size = new System.Drawing.Size(100, 15);
            this.lblRemainingGuesses.TabIndex = 9;
            this.lblRemainingGuesses.Text = "Kalan Hak:";
            // 
            // lblRemainingGuessesText
            // 
            this.lblRemainingGuessesText.AutoSize = true;
            this.lblRemainingGuessesText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRemainingGuessesText.Location = new System.Drawing.Point(300, 270);
            this.lblRemainingGuessesText.Name = "lblRemainingGuessesText";
            this.lblRemainingGuessesText.Size = new System.Drawing.Size(0, 21);
            this.lblRemainingGuessesText.TabIndex = 10;
            // 
            // txtLetterGuess
            // 
            this.txtLetterGuess.Location = new System.Drawing.Point(50, 320);
            this.txtLetterGuess.MaxLength = 1;
            this.txtLetterGuess.Name = "txtLetterGuess";
            this.txtLetterGuess.Size = new System.Drawing.Size(50, 23);
            this.txtLetterGuess.TabIndex = 11;
            // 
            // btnGuessLetter
            // 
            this.btnGuessLetter.Location = new System.Drawing.Point(120, 320);
            this.btnGuessLetter.Name = "btnGuessLetter";
            this.btnGuessLetter.Size = new System.Drawing.Size(100, 25);
            this.btnGuessLetter.TabIndex = 12;
            this.btnGuessLetter.Text = "Harf Tahmin Et";
            this.btnGuessLetter.UseVisualStyleBackColor = true;
            this.btnGuessLetter.Click += new System.EventHandler(this.btnGuessLetter_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(240, 320);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(100, 25);
            this.btnNewGame.TabIndex = 13;
            this.btnNewGame.Text = "Yeni Oyun";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(50, 380);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(100, 25);
            this.btnAddWord.TabIndex = 14;
            this.btnAddWord.Text = "Kelime Ekle";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // btnDeleteWord
            // 
            this.btnDeleteWord.Location = new System.Drawing.Point(170, 380);
            this.btnDeleteWord.Name = "btnDeleteWord";
            this.btnDeleteWord.Size = new System.Drawing.Size(100, 25);
            this.btnDeleteWord.TabIndex = 15;
            this.btnDeleteWord.Text = "Kelime Sil";
            this.btnDeleteWord.UseVisualStyleBackColor = true;
            this.btnDeleteWord.Click += new System.EventHandler(this.btnDeleteWord_Click);
            // 
            // btnShowScores
            // 
            this.btnShowScores.Location = new System.Drawing.Point(290, 380);
            this.btnShowScores.Name = "btnShowScores";
            this.btnShowScores.Size = new System.Drawing.Size(100, 25);
            this.btnShowScores.TabIndex = 16;
            this.btnShowScores.Text = "Skorları Göster";
            this.btnShowScores.UseVisualStyleBackColor = true;
            this.btnShowScores.Click += new System.EventHandler(this.btnShowScores_Click);
            // 
            // txtAddWord
            // 
            this.txtAddWord.Location = new System.Drawing.Point(50, 420);
            this.txtAddWord.Name = "txtAddWord";
            this.txtAddWord.Size = new System.Drawing.Size(100, 23);
            this.txtAddWord.TabIndex = 17;
            // 
            // txtDeleteWord
            // 
            this.txtDeleteWord.Location = new System.Drawing.Point(170, 420);
            this.txtDeleteWord.Name = "txtDeleteWord";
            this.txtDeleteWord.Size = new System.Drawing.Size(100, 23);
            this.txtDeleteWord.TabIndex = 18;
            // 
            // lblAddWord
            // 
            this.lblAddWord.AutoSize = true;
            this.lblAddWord.Location = new System.Drawing.Point(50, 360);
            this.lblAddWord.Name = "lblAddWord";
            this.lblAddWord.Size = new System.Drawing.Size(80, 15);
            this.lblAddWord.TabIndex = 19;
            this.lblAddWord.Text = "Eklenecek:";
            // 
            // lblDeleteWord
            // 
            this.lblDeleteWord.AutoSize = true;
            this.lblDeleteWord.Location = new System.Drawing.Point(170, 360);
            this.lblDeleteWord.Name = "lblDeleteWord";
            this.lblDeleteWord.Size = new System.Drawing.Size(70, 15);
            this.lblDeleteWord.TabIndex = 20;
            this.lblDeleteWord.Text = "Silinecek:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.lblDeleteWord);
            this.Controls.Add(this.lblAddWord);
            this.Controls.Add(this.txtDeleteWord);
            this.Controls.Add(this.txtAddWord);
            this.Controls.Add(this.btnShowScores);
            this.Controls.Add(this.btnDeleteWord);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnGuessLetter);
            this.Controls.Add(this.txtLetterGuess);
            this.Controls.Add(this.lblRemainingGuessesText);
            this.Controls.Add(this.lblRemainingGuesses);
            this.Controls.Add(this.lblWrongLettersText);
            this.Controls.Add(this.lblWrongLetters);
            this.Controls.Add(this.lblHangman);
            this.Controls.Add(this.panelWord);
            this.Controls.Add(this.btnRandomWord);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.txtWordLength);
            this.Controls.Add(this.lblWordLength);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Adam Asmaca Oyunu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWordLength;
        private System.Windows.Forms.TextBox txtWordLength;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnRandomWord;
        private System.Windows.Forms.Panel panelWord;
        private System.Windows.Forms.Label lblHangman;
        private System.Windows.Forms.Label lblWrongLetters;
        private System.Windows.Forms.Label lblWrongLettersText;
        private System.Windows.Forms.Label lblRemainingGuesses;
        private System.Windows.Forms.Label lblRemainingGuessesText;
        private System.Windows.Forms.TextBox txtLetterGuess;
        private System.Windows.Forms.Button btnGuessLetter;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnDeleteWord;
        private System.Windows.Forms.Button btnShowScores;
        private System.Windows.Forms.TextBox txtAddWord;
        private System.Windows.Forms.TextBox txtDeleteWord;
        private System.Windows.Forms.Label lblAddWord;
        private System.Windows.Forms.Label lblDeleteWord;
    }
}
