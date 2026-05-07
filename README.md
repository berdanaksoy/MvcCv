<h1 align="center"> MvcCv: Dinamik Kişisel CV & Portfolyo Sitesi </h1>

<p align="center"> Profesyonellerin kişisel bilgilerini, yeteneklerini ve deneyimlerini sergilemesi; tüm CV içeriğini admin paneli üzerinden kolayca yönetmesi için tasarlanmış full-stack bir CV web uygulaması. </p>

<p align="center">
  <img alt="Build" src="https://img.shields.io/badge/Build-Passing-brightgreen?style=for-the-badge">
  <img alt="Framework" src="https://img.shields.io/badge/Framework-ASP.NET%20MVC%205-512bd4?style=for-the-badge">
  <img alt="Database" src="https://img.shields.io/badge/Database-SQL%20Server-red?style=for-the-badge">
  <img alt="Architecture" src="https://img.shields.io/badge/Architecture-MVC-blue?style=for-the-badge">
</p>

---

## 🌟 Genel Bakış

**MvcCv**, kişisel CV bilgilerinin dinamik olarak yönetilip sergilenmesini sağlayan bir web uygulamasıdır. Statik HTML CV'lerin aksine, bu sistem tüm içeriğin (eğitim, deneyim, yetenek, sertifika, hobi, sosyal medya bağlantıları) güvenli bir yönetim paneli üzerinden tek satır kod yazmadan güncellenebilmesine olanak tanır.

### Problem
> Birçok geliştirici kişisel CV'sini statik HTML dosyaları olarak tutar. Bilgileri güncellemek için doğrudan kodu düzenlemek, dosyaları yeniden deploy etmek ve tekrar tekrar aynı döngüyü yaşamak gerekir. Bu hem zaman kaybına hem de güncel olmayan içeriklere yol açar.

### Çözüm
MvcCv, CV içeriğini bir veritabanı üzerinde tutar ve **ASP.NET MVC 5** mimarisi ile sunar. Kullanıcıya yönelik tek sayfalık bir vitrin, arka planda ise kimlik doğrulama korumalı bir admin paneli çalışır. İçerik güncellemek için yalnızca admin paneline giriş yapıp birkaç tıklama yeterlidir.

---

## ✨ Temel Özellikler

### 🌐 Tek Sayfalık CV Vitrini
* **Partial View Mimarisi:** Ana CV sayfası modüler Partial View'lara bölünmüştür; her bölüm bağımsız olarak yönetilebilir.
* **Dinamik İçerik:** Hakkımda, Yetenekler, Eğitim, Deneyim, Sertifikalar, Hobiler ve Sosyal Medya bölümleri veritabanından beslenir.
* **İletişim Formu:** Ziyaretçiler sayfanın alt kısmındaki form üzerinden doğrudan mesaj gönderebilir.

### 🛡️ Güvenli Admin Paneli
* **Kimlik Doğrulama:** Admin paneli oturum tabanlı kimlik doğrulama ile korunur; giriş yapılmadan hiçbir yönetim sayfasına erişilemez.
* **Tam CRUD Yönetimi:** Tüm CV bölümleri için ekleme, düzenleme ve silme işlemleri.
* **Modal ile Hızlı Ekleme:** Belirli bölümler için sayfa yenilemeden modal pencere üzerinden hızlı içerik ekleme.
* **Mesaj Yönetimi:** İletişim formundan gelen ziyaretçi mesajlarını admin panelinden görüntüleme.

### 🗃️ Yönetilebilir CV Bölümleri
* **Hakkımda:** Ad, soyad, adres, telefon, e-posta, açıklama ve profil fotoğrafı.
* **Yetenekler:** Yetenek adı ve ilerleme yüzdesi.
* **Eğitim:** Okul, bölüm, not ortalaması ve tarih bilgileri.
* **Deneyim:** Şirket, pozisyon, açıklama ve tarih.
* **Sertifikalar:** Sertifika açıklaması ve tarih.
* **Hobiler:** Hobi açıklamaları.
* **Sosyal Medya:** Platform adı, bağlantı URL'i ve ikon.

---

## 🛠️ Teknoloji Yığını & Mimari

Proje, veri, iş mantığı ve arayüzü birbirinden ayıran temiz bir **MVC (Model-View-Controller)** mimarisi ve **Generic Repository Pattern** üzerine kurulmuştur.

### Kullanılan Teknolojiler

| Teknoloji | Amacı | Neden Tercih Edildi |
| :--- | :--- | :--- |
| **ASP.NET MVC 5** | Ana Backend Framework | Kararlı, olgun ve kurumsal düzeyde MVC altyapısı sağlar. |
| **C#** | Programlama Dili | Güçlü tip sistemi ile sürdürülebilir iş mantığı sunar. |
| **Entity Framework 6** | ORM / Veri Erişimi | DB-First yaklaşımıyla mevcut veritabanından model üretimini kolaylaştırır. |
| **SQL Server** | İlişkisel Veritabanı | Veri tutarlılığı ve gelişmiş sorgulama desteği sağlar. |
| **AdminLTE 3.0.4** | Admin Panel Template | Hazır ve profesyonel yönetim paneli arayüzü sunar. |
| **Start Bootstrap Resume** | CV Ön Yüz Template | Modern ve responsive CV vitrini için temel şablon sağlar. |
| **Bootstrap 5** | Frontend Tasarım | Mobil uyumlu responsive arayüz geliştirmeyi kolaylaştırır. |
| **jQuery** | Client-Side Etkileşim | DOM işlemleri ve dinamik kullanıcı etkileşimi için kullanılır. |
| **Razor** | Şablon Motoru | Sunucu taraflı dinamik HTML üretimini sağlar. |

---

## 📁 Proje Yapısı

```
MvcCv/
├── 📂 AdminLTE-3.0.4/           # Admin panel template asset'leri
├── 📂 App_Start/                # Uygulama yapılandırmaları ve routing
├── 📂 Content/                  # CSS ve stil dosyaları
├── 📂 Controllers/              # İş mantığı ve request yönetimi
├── 📂 login-form-20/            # Giriş sayfası template'i
├── 📂 Models/
│   └── 📂 Entity/               # EF DB-First ile üretilen veri modelleri (Model1.edmx)
├── 📂 Repositories/             # Generic Repository Pattern implementasyonu
├── 📂 Scripts/                  # JavaScript kütüphaneleri
├── 📂 startbootstrap-resume-gh-pages/ # CV ön yüz template asset'leri
├── 📂 Views/                    # Razor arayüz dosyaları (Partial View'lar dahil)
├── 📂 Database/                 # SQL başlangıç scriptleri
│   └── 📄 script.sql            # Tablo oluşturma ve örnek veri scripti
├── 📄 Global.asax               # Uygulama seviyesinde olay yönetimi
├── 📄 packages.config           # NuGet paket bağımlılıkları
└── 📄 Web.config                # Veritabanı bağlantısı ve uygulama yapılandırması
```

---

## 🗃️ Veritabanı Mimarisi

Proje, DB-First yaklaşımıyla tasarlanmış aşağıdaki tablo yapısını kullanır.

| Tablo | Açıklama |
| :--- | :--- |
| **TblAbout** | Ad, soyad, adres, telefon, e-posta, açıklama ve profil fotoğrafı |
| **TblAdmin** | Kullanıcı adı ve şifre (admin girişi için) |
| **TblContact** | Ziyaretçi iletişim formu mesajları |
| **TblExperience** | İş deneyimi bilgileri |
| **TblEducation** | Eğitim geçmişi ve not ortalaması |
| **TblCertificate** | Sertifika bilgileri |
| **TblSkill** | Yetenek adı ve ilerleme yüzdesi |
| **TblHobby** | Hobi açıklamaları |
| **TblSocialMedia** | Sosyal medya platform adı, bağlantı ve ikon |

---

## 📸 Ekran Görüntüleri

### 🌐 CV Vitrini
Veritabanından beslenen, modern ve responsive tek sayfalık CV arayüzü.

<!-- CV vitrin ekran görüntüsü -->

### 🛡️ Admin Paneli
AdminLTE tabanlı, güvenli kimlik doğrulama korumalı yönetim merkezi.

<!-- Admin panel ekran görüntüsü -->

### 🔐 Admin Girişi
Sade ve şık giriş sayfası.

<!-- Giriş sayfası ekran görüntüsü -->

---

## 🚀 Kurulum

### Gereksinimler
* **Visual Studio 2022** veya üzeri (ASP.NET workload yüklü)
* **SQL Server** (LocalDB veya Express)
* **SSMS** (SQL Server Management Studio)

### Kurulum Adımları

1. **Repository'yi Klonlayın**
    ```bash
    git clone https://github.com/berdanaksoy/MvcCv.git
    cd MvcCv
    ```

2. **Veritabanını Oluşturun**

    SSMS'i açın ve `MvcCvDb` adında yeni bir veritabanı oluşturun. Ardından `Database/script.sql` dosyasını çalıştırarak tabloları ve örnek verileri yükleyin.

3. **Bağlantı Ayarı**

    `Web.config` dosyasındaki connection string'i kendi SQL Server bilgilerinizle güncelleyin:
    ```xml
    <connectionStrings>
      <add name="DbCvEntities"
           connectionString="metadata=res://*/Models.Entity.Model1.csdl|res://*/Models.Entity.Model1.ssdl|res://*/Models.Entity.Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=(localdb)\MSSQLLocalDB;initial catalog=DbCv;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;"
           providerName="System.Data.EntityClient" />
    </connectionStrings>
    ```

4. **NuGet Paketlerini Restore Edin**

    Visual Studio'da çözüme sağ tıklayın → **Restore NuGet Packages**

5. **Projeyi Çalıştırın**

    `F5` tuşuna basın veya Visual Studio'dan **IIS Express** ile başlatın.

---

## 🔧 Kullanım

### CV Vitrini
Ana sayfa (`/`) üzerinden herkese açık CV sayfasına erişilebilir. Sayfanın en altındaki iletişim formundan mesaj gönderilebilir.

### Admin Paneli
* `/Login/Index` adresinden kullanıcı adı ve şifre ile giriş yapın.
* Giriş yapılmadan yönetim sayfalarına erişim engellenir.
* Panel üzerinden tüm CV bölümlerini ekleyebilir, düzenleyebilir ve silebilirsiniz.

---

## 🤝 Katkıda Bulunma

MvcCv'ye katkılarınızı memnuniyetle karşılıyoruz!

### Nasıl Katkı Sağlanır

1. Fork alın
2. Yeni branch oluşturun (`git checkout -b feature/yeni-ozellik`)
3. Geliştirme yapın
4. Test edin
5. Commit atın (`git commit -m 'feat: yeni özellik eklendi'`)
6. Push edin (`git push origin feature/yeni-ozellik`)
7. Pull Request açın
