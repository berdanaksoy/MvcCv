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

<img width="2560" height="1290" alt="a_hakkımda" src="https://github.com/user-attachments/assets/74310df9-eb57-4bc5-bb75-0ea5d90f7e32" />

<details>
<summary><strong>📸 Diğer CV Modüllerini İncelemek İçin Tıklayın</strong></summary>
<br>

**Detaylı CV Modülleri:**
<img width="2560" height="1290" alt="a_deneyim" src="https://github.com/user-attachments/assets/a74cc2fb-3c14-4e54-9254-67e16f6e1ac0" />
<br>
<img width="2560" height="1290" alt="eğitim" src="https://github.com/user-attachments/assets/287bc1f1-10ac-4665-99e1-d5f8e49c3c6d" />
<br>
<img width="2560" height="1290" alt="a_yetenek" src="https://github.com/user-attachments/assets/195222ec-e311-4e39-b4fa-06b1743a8095" />
<br>
<img width="2560" height="1284" alt="a_iletişim" src="https://github.com/user-attachments/assets/3f52e245-7e7b-44a5-b2ae-62f27a4c5460" />
</details>



### 🔐 Admin Girişi
Sade ve şık giriş sayfası.

<img width="2560" height="1287" alt="login" src="https://github.com/user-attachments/assets/3bd07a38-6756-42c4-ad8b-097d908a51a8" />

### 🛡️ Admin Paneli
AdminLTE tabanlı, güvenli kimlik doğrulama korumalı yönetim merkezi.

<img width="2560" height="1288" alt="hakkımda" src="https://github.com/user-attachments/assets/3bcdcd4f-fb44-40a4-8de9-13a01afd4f8b" />

<details>
<summary><strong>📸 Diğer Admin Paneli Modüllerini İncelemek İçin Tıklayın</strong></summary>
<br>

**Detaylı Sistem Modülleri:**
<img width="2560" height="1290" alt="eğitim" src="https://github.com/user-attachments/assets/8db1e45a-f76d-4d95-aa0b-e82a207370c2" />
<br>
<img width="2560" height="1289" alt="eğitim_düzenle" src="https://github.com/user-attachments/assets/e9b7705a-17bc-4e2f-9c7c-d111643c6a67" />
<br>
<img width="2560" height="1286" alt="eğitim_ekle" src="https://github.com/user-attachments/assets/5df7d7ae-dae3-4011-be2a-5d443574cc77" />
<br>
<img width="2560" height="1290" alt="yetenek" src="https://github.com/user-attachments/assets/bd2eceec-22b5-430b-b87a-4a62162eee09" />
<br>
<img width="2560" height="1285" alt="sertifika" src="https://github.com/user-attachments/assets/f9e3f7a0-95ec-4332-bd32-888bc7f8e533" />
<br>
<img width="2560" height="1285" alt="mesaj" src="https://github.com/user-attachments/assets/7fc4b3de-7d70-4ef4-abdd-f7c6cae2b307" />
<br>
<img width="2560" height="1285" alt="sosyal_medya_ekle" src="https://github.com/user-attachments/assets/99d3904a-b849-4c09-855e-1b5dfb50ca20" />
</details>

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
