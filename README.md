# RSA & SHA-256 Kriptografi Aracı

Bu proje, RSA asimetrik şifreleme ve SHA-256 hash algoritması işlemlerini gerçekleştirmek için C# ve .NET Framework 4.7.2 kullanılarak geliştirilmiş bir Windows Forms masaüstü uygulamasıdır. Kriptografik işlemler için popüler BouncyCastle kütüphanesinden yararlanılmıştır.

## ✨ Özellikler

### SHA-256 Hash
* Girilen metinlerin SHA-256 özetini (hash) hesaplama.
* Seçilen dosyaların SHA-256 özetini (hash) hesaplama.

### RSA Araç Takımı
Uygulama, RSA kriptografisi için kapsamlı bir araç takımı sunar:

* **Anahtar Üretimi:**
    * 1024, 2048, 3072 ve 4096 bit boyutlarında RSA anahtar çiftleri (Public/Private) oluşturma.
    * Oluşturulan özel anahtarı isteğe bağlı olarak bir parola ile şifreleyerek (PKCS#8 formatında) güvenliğini artırma.
    * Oluşturulan anahtarları PEM formatında kaydetme.

* **Şifreleme (Encryption):**
    * Bir Public Key kullanarak metinleri şifreleme.
    * Güvenli **OAEP** (SHA-1/SHA-256 ile) ve eski sistemlerle uyumluluk için **PKCS#1 v1.5** dolgulama (padding) şemalarını destekleme.
    * Şifrelenmiş veriyi taşınabilirliği kolaylaştırmak için Base64 formatında sunma.

* **Deşifreleme (Decryption):**
    * Bir Private Key kullanarak şifrelenmiş metinleri çözme.
    * Parola ile korunan Private Key'leri destekleme.
    * Şifreleme sırasında kullanılan dolgulama şemasına uygun olarak deşifreleme yapma.

* **Dijital İmza (Signature):**
    * Bir mesajı, sahibine ait Private Key ile imzalama (`SHA256withRSA`).
    * Oluşturulan imzayı Base64 formatında sunma.

* **İmza Doğrulama (Verification):**
    * Bir imzayı, orijinal mesajı ve Public Key'i kullanarak doğrulama.
    * Doğrulama sonucunu kullanıcıya net bir şekilde (Geçerli/Geçersiz) bildirme.

### Kullanıcı Arayüzü
* Tüm işlevleri sekmeler altında toplayan modern ve kullanışlı arayüz.
* Animasyonlu ve açılır/kapanır menü tasarımı.
* Sürüklenebilir, kenarlıksız pencere yapısı.

---

## 🛠️ Kullanılan Teknolojiler
* **C#**
* **.NET Framework 4.7.2**
* **Windows Forms**
* **BouncyCastle.Cryptography (v2.6.1)**

---

## 🚀 Kurulum (Installation)
Bu projeyi kendi bilgisayarınızda çalıştırmak için aşağıdaki adımları izleyin:

1.  Projeyi klonlayın veya ZIP olarak indirin.
    \`\`\`bash
    git clone https://github.com/EFBabacan/Sha_and_Rsa.git
    \`\`\`
2.  İndirdiğiniz klasördeki `Sha_and_RSA.sln` dosyasını Visual Studio ile açın.
3.  Solution Explorer'da Solution'a (en üstteki çözüm öğesi) sağ tıklayıp **"Restore NuGet Packages"** (NuGet Paketlerini Geri Yükle) seçeneğini seçin. Bu işlem, proje için gerekli olan BouncyCastle kütüphanesini otomatik olarak indirecektir.
4.  Projeyi derlemek için `Build > Build Solution` menüsünü kullanın veya `F6` tuşuna basın.
5.  Projeyi çalıştırmak için `Debug > Start Debugging` menüsünü kullanın veya `F5` tuşuna basın.

---

## 🖼️ Ekran Görüntüleri

*Ana pencere ekran görüntüsü buraya gelecek*
https://github.com/EFBabacan/Sha_and_Rsa/blob/main/anasayfa.png

*RSA Anahtar Üretme ekran görüntüsü buraya gelecek*
https://github.com/EFBabacan/Sha_and_Rsa/blob/main/anahtar_olusturma.png

*RSA Şifreleme ekran görüntüsü buraya gelecek*
https://github.com/EFBabacan/Sha_and_Rsa/blob/main/encryption.png

*RSA Şifre Çözme ekran görüntüsü buraya gelecek*
https://github.com/EFBabacan/Sha_and_Rsa/blob/main/decryption.png

*RSA İmzalama ekran görüntüsü buraya gelecek*
https://github.com/EFBabacan/Sha_and_Rsa/blob/main/sign_message.png

*RSA İmza Doğrulama ekran görüntüsü buraya gelecek*
https://github.com/EFBabacan/Sha_and_Rsa/blob/main/verify_signature.png

*SHA-256 Aracı ekran görüntüsü buraya gelecek*
https://github.com/EFBabacan/Sha_and_Rsa/blob/main/sha256.png


