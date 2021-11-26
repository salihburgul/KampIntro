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
namespace Ödev1
{
    public class Program<T>
    {
        static void Main(string[] args)
        {
            List<string> menuList = new List<string> { "Kurslarım", "Tüm Kurslar", "Kampa Hazırılık", "Sık Sorulan Sorular" };
            List<string> courseList = new List<string> { "C#", "Java", "Temel" };

            foreach (var menu in menuList)

            {
                Console.WriteLine(menuList);
            }
            foreach (var couse in courseList)
            {
                Console.WriteLine(courseList);
            }
            Console.WriteLine("sayfa sonu");
        }
    }
}
