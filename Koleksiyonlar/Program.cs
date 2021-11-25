using System.Collections.Generic;

class Program
{
    static void Main(string[]args)
    {
        //string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil" };
        //Console.WriteLine(isimler[0]);
        //Console.WriteLine(isimler[1]);
        //Console.WriteLine(isimler[2]);
        //Console.WriteLine(isimler[3]);
        ////eğer 4 elemanlı tanımlandıysa 5 elemana çıkarmak istediğimizde öncek elemanları kaybederiz
        //isimler = new string[5];
        //isimler[4] = "İlker";
        //Console.WriteLine(isimler[4]);
        //Console.WriteLine(isimler[0]);
        ////dizilere yeni eleman eklemeye çalıştığımız zaman sorun yaşıyoruz. Bu sebeple koleksiyonlar kullanıyoruz

        List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
        Console.WriteLine(isimler2[0]);
        Console.WriteLine(isimler2[1]);
        Console.WriteLine(isimler2[2]);
        Console.WriteLine(isimler2[3]);
        isimler2.Add("ilker");
        Console.WriteLine(isimler2[4]);
        Console.WriteLine(isimler2[0]);


    }
}
   