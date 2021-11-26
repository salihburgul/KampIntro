namespace Ödev1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> menuList = new List<string> { "Kurslarım", "Tüm Kurslar", "Kampa Hazırılık", "Sık Sorulan Sorular" };
            List<string> courseList = new List<string> { "C#", "Java", "Temel" };

            foreach (var menu in menuList)

            {
                Console.WriteLine(menu);
            }
            foreach (var course in courseList)
            {
                Console.WriteLine(course);
            }
            Console.WriteLine("sayfa sonu");  
        }
    }
}