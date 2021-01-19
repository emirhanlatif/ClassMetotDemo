using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriTakip
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Numarasi: "+musteri.Id);
            Console.WriteLine("Ad Soyad: "+musteri.musteriadi+ " "+musteri.musterisoyadi);
            Console.WriteLine("Yasi: "+musteri.musteriyasi);
            Console.WriteLine("-----------");
        }

        public void Listele( Musteri[] musteriler)
        {
            Console.WriteLine("Musteri Listesi");
            Console.WriteLine("////////////////");
            foreach (var x in musteriler)
            {
                Console.WriteLine(x.Id);
                Console.WriteLine(x.musteriadi+" "+x.musterisoyadi);
                Console.WriteLine(x.musteriyasi);
            }
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("++++++++++++++++++++");
            Console.WriteLine("Musteri Silindi");
            musteri.Id = 0000;
            musteri.musteriadi = "###";
            musteri.musterisoyadi = "###";
            musteri.musteriyasi = 00;
            Console.WriteLine("Musteri Numarasi: "+musteri.Id);
            Console.WriteLine("Musterinin Yasi: "+musteri.musteriadi+musteri.musterisoyadi);
            Console.WriteLine("Musteri Yasi: "+musteri.musteriyasi);
        }
    }
}
