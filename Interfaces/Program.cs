namespace Interfaces
{//aynı operasyonu farklı yerlerde yapmak için interface kullanırız.
    class Program
    {//interface newlenemez
        //interfaceler classların referansını tutabilirler
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager(); 
            employeeManager.Add();
            
        }
    }
    interface IPersonManager
    {//unimplemented Operation, tamamlanmış operasyon
        void Add();
        //müşteri ekleme kodları
        void Update();
        

    }
    //inherits - class --------------implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müsteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müsteri Güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {//personel eklme koları 
        public void Add() 
        
        { 
            Console.WriteLine("Personel Eklendi"); 
        }

        public void Update()
        {
            Console.WriteLine("Personel Eklendi");

        }
        class InternManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Stajyer Eklendi");
            }

            public void Update()
            {
                Console.WriteLine("Stajyer Güncellendi");
            }
        }

        class ProjectManager
        {
            public void Add(IPersonManager personManager)
            {
                
                personManager.Add();
            }
        }
    }
}