using System;
using System.Collections.Generic;
using System.Linq;

class Film
{
    public string Isim { get; set; }
    public double ImdbPuani { get; set; }
}

class Program
{
    static void Main()
    {
        List<Film> filmListesi = new List<Film>();
        string devamMi = "E";

        // Kullanıcıdan sınırsız sayıda film bilgisi alalım
        while (devamMi.ToUpper() == "E")
        {
            Film film = new Film();

            // Film adı
            Console.Write("Film Adı: ");
            film.Isim = Console.ReadLine();

            // IMDb Puanı
            Console.Write("IMDb Puanı: ");
            film.ImdbPuani = Convert.ToDouble(Console.ReadLine());

            // Listeye ekle
            filmListesi.Add(film);

            // Yeni film eklemek ister misin?
            Console.Write("Yeni bir film eklemek istiyor musunuz? (E/H): ");
            devamMi = Console.ReadLine();
        }

        // Bütün filmleri listele
        Console.WriteLine("\nTüm Filmler:");
        foreach (var film in filmListesi)
        {
            Console.WriteLine($"Film: {film.Isim}, IMDb Puanı: {film.ImdbPuani}");
        }

        // IMDb puanı 4 ile 9 arasında olan filmleri listele
        Console.WriteLine("\nIMDb Puanı 4 ile 9 arasında olan Filmler:");
        var filtreliFilmler = filmListesi.Where(f => f.ImdbPuani >= 4 && f.ImdbPuani <= 9);
        foreach (var film in filtreliFilmler)
        {
            Console.WriteLine($"Film: {film.Isim}, IMDb Puanı: {film.ImdbPuani}");
        }

        // İsmi 'A' ile başlayan filmler ve IMDb puanları
        Console.WriteLine("\nİsmi 'A' ile başlayan Filmler:");
        var aIleBaslayanFilmler = filmListesi.Where(f => f.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase));
        foreach (var film in aIleBaslayanFilmler)
        {
            Console.WriteLine($"Film: {film.Isim}, IMDb Puanı: {film.ImdbPuani}");
        }

        Console.WriteLine("\nProgram sonlandı.");
    }
}
