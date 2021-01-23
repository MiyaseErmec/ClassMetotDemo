using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id      = 1;
            musteri1.Adi     = "Miyase";
            musteri1.Soyadi  = "Ermeç";
            musteri1.Meslegi = "Tekstil Laborant";
            musteri1.Maasi   = 2500;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Kerem";
            musteri2.Soyadi = "Aslan";
            musteri2.Meslegi = "Mühendis";
            musteri2.Maasi = 5000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Ayaz";
            musteri3.Soyadi = "Tanrıkulu";
            musteri3.Meslegi = "Doktor";
            musteri3.Maasi = 15000;

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3};

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı : "+ musteri.Adi);
                Console.WriteLine("Müşteri Soyadı : "+ musteri.Soyadi);
                Console.WriteLine("Mesleği : " + musteri.Meslegi);
                Console.WriteLine("Maaşı : " + musteri.Maasi + " TL");
            }

            Console.WriteLine(".................................................");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Sil(musteri1);
            Console.WriteLine("Müşterilerin Maaş Listesi ;");
            musteriManager.List(musteriler);
      
            







        }
    }
}
