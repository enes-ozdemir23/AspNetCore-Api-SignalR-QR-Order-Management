# 🍽️ QR Kodlu Sipariş Yönetim Sistemi

**ASP.NET Core 6.0** ve **SignalR** kullanılarak geliştirilmiş, gerçek zamanlı restoran sipariş yönetim sistemidir.

---

## 🚀 Kullanılan Teknolojiler

| Katman | Teknoloji |
|--------|-----------|
| Backend | ASP.NET Core 6.0, C#, Web API |
| Real-Time | SignalR |
| ORM | Entity Framework Core, LINQ |
| Veritabanı | MSSQL |
| Mimari | N-Tier Architecture, DTO, AutoMapper |
| Frontend | HTML, CSS, JavaScript, Ajax |
| Araçlar | Swagger, Postman |

---

## ⚙️ Özellikler

### 🖥️ Admin Paneli
- ✅ Tüm siparişleri gerçek zamanlı görüntüleme (SignalR)
- ✅ Sipariş onaylama / iptal etme
- ✅ Rezervasyon yönetimi ve anlık bildirimler
- ✅ Gerçek zamanlı istatistik paneli
- ✅ Gerçek zamanlı mesajlaşma sistemi
- ✅ Mail gönderme entegrasyonu
- ✅ Sepet yönetimi

### 🪑 Müşteri Arayüzü
- ✅ QR kod okuma ile masa bazlı sipariş
- ✅ Menü görüntüleme ve ürün seçimi
- ✅ Rezervasyon oluşturma

---

## 📁 Proje Mimarisi

```
SignalRProject/
├── SignalRProject.DataAccessLayer/
├── SignalRProject.BusinessLayer/
├── SignalRProject.EntityLayer/
├── SignalRProject.DtoLayer/
├── SignalRProject.Api/            # Web API
└── SignalRProject.WebUI/          # MVC + SignalR Hub
```

---

## 🛠️ Kurulum

```bash
# 1. Repoyu klonla
git clone https://github.com/enesozdemir23/SignalRProject.git

# 2. appsettings.json bağlantı dizesini düzenle
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=SignalRDb;Trusted_Connection=True;"
}

# 3. Migration uygula
dotnet ef database update

# 4. Uygulamayı çalıştır
dotnet run
```

---

## 👤 Geliştirici

**Enes Özdemir**  
📧 ozdemir.enes2323@gmail.com  
🔗 (https://github.com/enes-ozdemir23)
