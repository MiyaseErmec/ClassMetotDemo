using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşterinin maaş bilgisi eklendi.");
            Console.WriteLine(musteri.Maasi + " TL" );
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşterilerin maaş bilgisi silindi.");
        }

        public void List(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Maasi + " TL ");
            }
        }
    }
}
