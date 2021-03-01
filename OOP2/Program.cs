using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Yusuf Aktaş
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Yusuf";
            musteri1.Soyadi = "Aktaş";
            musteri1.TcNo = "1234567890";

            //Kodlama.co

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "123343";
            musteri2.SirketAdi = "Kodlama.co";
            musteri2.VergiNo = "12344567876536";

            //-------------
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);
        }
    }
}
