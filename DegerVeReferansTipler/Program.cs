{
    static void Main(string[] args)
    {
        //Bellekte stack ve heap denilen iki adet alan vardır.
        //Değer tip olanlar stack de tanımlanıyor.
        //Referans tip olanlar ise heap de tanımlanıyor

        int sayi1 = 10;
        int sayi2 = 30;
        sayi1 = sayi2; // sayi1'in değerini 30'a sabitledik 
        sayi2 = 65; //sayi2'nin değeri bu noktada sayi1'i değiştirmediği için sayi1=30 kalıyor
        //sayi1 = ?? = 30 STACK TİP
       
        // int , decimal , flood, oule, bool = değer tip 
        // array, class, interface = referans 
        int[] sayilar1= new int[] {10,20, 30 }; 
        int[] sayilar2 = new int[] { 100, 200, 300 };
        sayilar1 = sayilar2;
        sayilar2[0] = 999;
        //sayilar1[0] = ?? = 999 olur
        //sayilar 1 adında stack oluşturduk.
        // 101no'lu[10,20,30] (adres değeri) adında bir heap oluşturduk.
        // new, sayilar1-->[10,20,30] adres değerine yönlendiriyor
        //sayilar2'yi de 102no'lu[100,200,300] adres " yönlendiriyor.
        //sayilar1 = sayilar2 diyerek no101'i no102'ye çeviriyoruz.
        //o sebeple sayilar[0]=999 olur (pointer)
        //no101'i tutan kimse olmadığı için dat.net'in garbagecollectoru'u sayilar1'i bellekten atacaktır.

    }

}