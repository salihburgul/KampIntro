{
    //array - dizi

    string[] kurslar = new string[] { "yazılım geliştirme kampı" , "programlamaya başlangıç için temel kurs" , "java", "python", "c++"};    
    
    //length ne kadar eleman var ise o kadar sıralatır
    for (int i = 0; i <kurslar.Length; i++) //i+2 olursa 2 şer artar
    {
        Console.WriteLine(kurslar[i]);
    }
    Console.WriteLine("for bitti");

    foreach (string kurs in kurslar) //dizileri tek tek dolaşmaya deniyor. foreach dizileri daha kolay dolaşmak için kullanılır.
    {
        Console.WriteLine(kurs);
    }
    Console.WriteLine("sayfa sonu - footer");
}
