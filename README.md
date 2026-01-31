
# mysqldata

Bu proje, **.NET ile MySQL veritabanı üzerinde CRUD (Create, Read, Update, Delete) işlemlerini öğretmek ve pratiğe dökmek** amacıyla hazırlanmış basit bir uygulamadır.  
Veritabanı bağlantısı, temel sorgular ve veri yönetimi yapısı içermektedir.

---

## 📌 Özellikler

- MySQL veritabanına bağlanma
- Veri ekleme (Create)
- Veri listeleme (Read)
- Veri güncelleme (Update)
- Veri silme (Delete)
- Basit ve anlaşılır .NET veri erişim katmanı

---

## 🛠 Gereksinimler

Projeyi çalıştırmak için aşağıdakiler gereklidir:

1. .NET (6 veya üzeri)
2. MySQL Server
3. Visual Studio veya Visual Studio Code

---

## 🚀 Kurulum

1. Reposu klonlayın:
   ```
   git clone https://github.com/Burhan0664/mysqldata.git
   ````

2. Çalışma dizinine gidin ve gerekli paketleri yükleyin:

   ```bash
   dotnet add package MySql.Data
   dotnet add package MySqlConnector
   ```

3. Projeyi Visual Studio veya VS Code ile açın.

4. MySQL bağlantı dizesini kendi veritabanı bilgilerinle değiştirin:

   ```csharp
   string connectionString = "Server=localhost;Database=YourDB;Uid=root;Pwd=yourPassword;";
   ```

---

## 🧠 Proje Amacı

Bu repo, .NET ile MySQL kullanarak **temel veritabanı işlemlerini öğrenmek ve uygulamalı şekilde pratik yapmak** isteyenler için hazırlanmıştır. Basit ama öğrenmeye uygun bir yapıya sahiptir.

---

## 📄 Lisans

Bu proje MIT lisansı ile lisanslanmıştır.

```
# 👨‍💻 Geliştirici

**Burhan Çavdaroğlu**  
📍 Ankara, Türkiye  
🔗 LinkedIn: https://www.linkedin.com/in/burhancavdaroglu/
