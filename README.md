FİLM LİSTESİ UYGULAMASI
Bu uygulama, kullanıcıdan sınırsız sayıda film bilgisi alıp, IMDb puanına göre çeşitli filtreleme işlemleri yapan bir konsol uygulamasıdır. Uygulamanın temel amacı, filmleri bir listeye eklemek, daha sonra bu liste üzerinde çeşitli sorgular yaparak filmleri listelemektir.

-Uygulamanın Özellikleri-
Film Ekleme: Kullanıcı, uygulama çalışırken istediği kadar film ekleyebilir. Film bilgisi olarak film adı ve IMDb puanı alınır.

Tüm Filmleri Listeleme: Uygulama, eklenen tüm filmleri kullanıcıya gösterebilir.

IMDb Puanına Göre Filtreleme: Uygulama, IMDb puanı 4 ile 9 arasında olan filmleri listeleyebilir.

Film Adına Göre Filtreleme: Uygulama, ismi 'A' harfi ile başlayan filmleri ve IMDb puanlarını kullanıcıya gösterebilir.

-Programın Kullanımı-
Uygulama çalıştırıldığında, kullanıcının eklemek istediği film adı ve IMDb puanı sorulur.

Kullanıcıya, her film ekledikten sonra yeni bir film eklemek isteyip istemediği sorulur.

"E" girilirse, yeni bir film eklenebilir.
"H" girilirse, film ekleme işlemi sonlanır ve eklenen tüm filmler listelenir.
Uygulama, IMDb puanı 4 ile 9 arasında olan filmleri ve ismi 'A' harfi ile başlayan filmleri otomatik olarak listeler.

-Kod Açıklaması-
Film Sınıfı: Film sınıfı, filmin adını ve IMDb puanını tutmak için iki özellik (Isim ve ImdbPuani) içerir.

Listeleme ve Filtreleme: Filmler List<Film> kullanılarak bir listeye eklenir. Linq kütüphanesi yardımıyla, IMDb puanına ve film ismine göre filtrelemeler yapılır.

-Gereksinimler-
.NET Framework yüklü bir bilgisayar.
System.Linq kütüphanesinin projeye dahil edilmesi.
Bu basit uygulama, film verilerini yönetmek ve çeşitli sorgular yapmak için temel bir örnek sunar.
