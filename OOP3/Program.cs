using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[]args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            
            IKrediManager konutKrediManager = new KonutKrediManager();
            
            ILoggerService databaseLoggerService = new DataBaseLoggerService();//alternatif
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>();
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);
           
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            //bütün managerları çağırabiliriz.
        }//interfaceler de classların referans numarasını tutabilir.
    }
}