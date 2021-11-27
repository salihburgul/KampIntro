using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,boolean değer tipleridir.Stack te toplanır
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;
            //sayi1 i sayi2 ye eşitlediğimizde 20 olur sayi 2 değişince sayi1 değişmez
            Console.WriteLine("Sayı1:", sayi1);
            int[] sayilar1 = new int[] {1, 2, 3};
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
        }
    }
}
