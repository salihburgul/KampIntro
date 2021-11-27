using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ad = "Salih";
            musteri1.soyad = "Burgul";
            musteri1.Id = 123456;
            musteri1.Tel = 432432;

            Musteri musteri2 = new Musteri();
            musteri2.ad = "Kaan";
            musteri2.soyad = "Varışlı";
            musteri2.Id = 1234543;
            musteri2.Tel = 432432;

            Musteri musteri3 = new Musteri();
            musteri3.ad = "Caner";
            musteri3.soyad = "Bilici";
            musteri3.Id = 122456;
            musteri3.Tel = 532432;

            MusteriManager MusteriManager = new MusteriManager();
            MusteriManager.Ekleme(musteri1);
            MusteriManager.Silme(musteri2);
            MusteriManager.Listeleme(musteri3);
        }





    }
}
