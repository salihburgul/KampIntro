using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    { //Topla(2,3) iki nesne için uygulanır. Ancak metot yazarak istediğimiz kadar verinin toplanması için kullanılır.
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }

    }
}
