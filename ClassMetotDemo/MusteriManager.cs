using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekleme(Musteri musteri) 
        {
            Console.WriteLine(musteri.ad + " " + musteri.soyad + " " + "Müşteri Eklendi"); 

        }

        public void Silme(Musteri musteri) 
        {
            Console.WriteLine(musteri.ad + " " + musteri.soyad + " " + "Müşteri Silindi");
        }

        public void Listeleme(Musteri musteri) 
        {
            Console.WriteLine(musteri.ad + " " + musteri.soyad + " " + "Müşteri Listelendi");
        }
        



    }
}
