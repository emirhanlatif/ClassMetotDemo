using System;

namespace MusteriTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1234;
            musteri1.musteriadi = "Emirhan";
            musteri1.musterisoyadi = "Latif";
            musteri1.musteriyasi = 20;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 6789;
            musteri2.musteriadi = "Mustafa";
            musteri2.musterisoyadi = "Yılmaz";
            musteri2.musteriyasi = 36;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 7777;
            musteri3.musteriadi = "Ali";
            musteri3.musterisoyadi = "Kiraz";
            musteri3.musteriyasi = 43;

            MusteriManager musteriManager = new MusteriManager();
           
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
         

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2 };
            musteriManager.Listele(musteriler);

            musteriManager.Sil(musteri1);

            //Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            //foreach (var musteri in musteriler)
            //{
            //    Console.WriteLine(musteri.Id);
            //    Console.WriteLine(musteri.musteriadi + " " + musteri.musterisoyadi);
            //    Console.WriteLine(musteri.musteriyasi);
            //    Console.WriteLine("---------");
            //}
        }
    }
}
