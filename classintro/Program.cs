{
    Kurs kurs1 = new Kurs();
    kurs1.kursAdi = "c#";
    kurs1.egitmeni = "Engin Demiroğ";
    kurs1.izlenmeOrani = 68;

    Kurs kurs2 = new Kurs();
    kurs2.kursAdi = "java";
    kurs2.egitmeni = "Kerem Varış";
    kurs2.izlenmeOrani = 64;

    Kurs kurs3 = new Kurs();
    kurs3.kursAdi = "python";
    kurs3.egitmeni = "Berkay Bilgin";
    kurs3.izlenmeOrani = 80;

    //Console.WriteLine(kurs1.kursAdi + " : " + kurs1.egitmeni);

    Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, };

    foreach (var kurs in kurslar)
    {
        Console.WriteLine(kurs1.kursAdi + " : " + kurs1.egitmeni);
    }

}






    class Kurs //class sadece string değil bir çok elemanı içinde barındırabiliyor
{//prop= property yani özellik demek 
    public string kursAdi { get; set; }

    public string egitmeni { get; set; }

    public int izlenmeOrani { get; set; }
}
