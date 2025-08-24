# Adam Asmaca Oyunu

Bu proje, C# Windows Forms kullanılarak geliştirilmiş basit bir Adam Asmaca oyunudur. 

## 🎮 Oyun Hakkında

Adam Asmaca, bilinmeyen her harf için adamı asılmaya bir adım daha yaklaştıran klasik kelime tahmin oyunudur. Bu Windows uygulaması, tüm gereksinimleri karşılayan kapsamlı bir oyun deneyimi sunar.

## ✨ Özellikler

### 📋 Temel Özellikler
- **✅ Kelime Veritabanı**: `words.txt` dosyasından 100+ Türkçe kelime yüklenir
- **✅ Kelime Ekleme/Silme**: Form üzerinden yeni kelime ekleme ve mevcut kelimeleri silme
- **✅ Kelime Seçimi**: Belirli uzunlukta kelime seçme veya rastgele kelime seçme
- **✅ Hak Sistemi**: Kelime uzunluğunun 2 fazlası kadar tahmin hakkı
- **✅ Harf Kutuları**: Her harf için dinamik olarak oluşturulan ayrı metin kutusu
- **✅ Yanlış Harfler**: Yanlış tahmin edilen harflerin form üzerinde görüntülenmesi
- **✅ Harf Tekrarı Kontrolü**: Aynı harfin tekrar tahmin edilmesini engelleme
- **✅ Skor Sistemi**: Oyun sonu skorlarının `scores.txt` dosyasında saklanması

### 🎮 Oyun Özellikleri
- **✅ Adam Asmaca Görselleştirmesi**: 7 aşamalı ASCII art ile adam asmaca çizimi
- **✅ Türkçe Karakter Desteği**: Türkçe harfler ve kelimeler tam destekleniyor
- **✅ Kullanıcı Dostu Arayüz**: Basit ve anlaşılır Windows Forms tasarımı
- **✅ Gerçek Zamanlı Güncelleme**: Oyun durumunun anlık güncellenmesi
- **✅ Hata Yönetimi**: Dosya bulunamazsa varsayılan kelimelerle çalışma

## 🚀 Kurulum ve Çalıştırma

### Gereksinimler
- .NET 8.0 SDK
- Windows işletim sistemi

### Adımlar
1. **Projeyi İndirin**
   ```bash
   git clone https://github.com/BerfinSemiz/sayi-bulma-oyunu.git
   cd sayi-bulma-oyunu
   ```

2. **Projeyi Derleyin**
   ```bash
   dotnet build
   ```

3. **Oyunu Çalıştırın**
   ```bash
   dotnet run
   ```
```

## Dosya Yapısı

```
hangman_game/
├── Form1.cs              # Ana oyun mantığı
├── Form1.Designer.cs     # Form tasarımı
├── Program.cs            # Uygulama giriş noktası
├── words.txt             # Kelime veritabanı
├── scores.txt            # Skor kayıtları
└── hangman_game.csproj   # Proje dosyası
```

## 🎮 Oyun Kuralları

### 1. **Oyun Başlatma**
- **Belirli Uzunlukta Kelime**: Kelime uzunluğu girip "Oyunu Başlat" butonuna tıklayın
- **Rastgele Kelime**: "Rastgele Kelime" butonuna tıklayarak herhangi bir uzunlukta kelime seçin

### 2. **Tahmin Etme**
- Harf kutusuna **tek harf** girin
- "Harf Tahmin Et" butonuna tıklayın
- **Doğru harf**: Kelime kutularında görünür
- **Yanlış harf**: Yanlış harfler listesinde görünür ve hak azalır

### 3. **Oyun Sonu**
- **Kazanma**: Kelimeyi tamamen bulma
- **Kaybetme**: Hak bitirme
- **Skor Kaydetme**: İsim girerek skoru kaydetme

## 📊 Skor Hesaplama

```
Skor = (Kelime Uzunluğu × 10) + (Kalan Hak × 5)
```

**Örnek**: 5 harfli kelimeyi 3 hak kalarak bulma
- Skor = (5 × 10) + (3 × 5) = 50 + 15 = **65 puan**

## 🔧 Kelime Yönetimi

### Kelime Ekleme
1. Alt kısımdaki "Eklenecek" kutusuna kelime yazın
2. "Kelime Ekle" butonuna tıklayın
3. Kelime `words.txt` dosyasına eklenir

### Kelime Silme
1. Alt kısımdaki "Silinecek" kutusuna kelime yazın
2. "Kelime Sil" butonuna tıklayın
3. Kelime `words.txt` dosyasından silinir

### Skorları Görme
- "Skorları Göster" butonuna tıklayın
- En iyi 10 skor görüntülenir
- Skorlar: Oyuncu Adı, Puan, Kalan Hak

## 🛠️ Teknik Detaylar

### Teknolojiler
- **Framework**: .NET 8.0 Windows Forms
- **Programlama Dili**: C#
- **Veri Saklama**: Metin dosyaları (words.txt, scores.txt)
- **UI Framework**: Windows Forms Controls
- **Paket Yöneticisi**: NuGet (Microsoft.VisualBasic)

### Önemli Özellikler
- **Dosya Yolu Yönetimi**: Çalışma dizini ve uygulama dizininde dosya arama
- **Hata Toleransı**: Dosya bulunamazsa varsayılan kelimelerle çalışma
- **Türkçe Karakter Desteği**: UTF-8 encoding ile tam Türkçe desteği
- **Dinamik UI**: Kelime uzunluğuna göre harf kutuları oluşturma

### Önemli Metodlar
- `LoadWords()`: Kelime dosyasını yükler
- `StartNewGame()`: Yeni oyun başlatır
- `CreateLetterBoxes()`: Harf kutularını oluşturur
- `UpdateHangmanDisplay()`: Adam asmaca çizimini günceller
- `SaveScore()`: Skor kaydeder



## 📄 Lisans

Bu proje eğitim amaçlı geliştirilmiştir. Özgürce kullanılabilir ve değiştirilebilir.

--

