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
            //arrays, class, interface... referance types
            Console.WriteLine("Sayı1:", sayi1);
            int[] sayilar1 = new int[] {1, 2, 3};
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine(sayilar1[0]); //1000 olur
            //referance typelar heapte toplandığında bir adreste tanımlanır ve son soruda o adresler  eşitlendiği için cevap 1000 olur.
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;//adres değişikliği
            person1.FirstName = "Derin";
            //person2'nin firstname i derin diye değişir.
            Console.WriteLine(person2.FirstName);
            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "1234566543";
            Employee employee = new Employee();

            Person person3 = customer;
            customer.FirstName = "Ahmet";

            
            Console.WriteLine(((Customer)person3).CreditCardNumber); 
        }//bu şekilde base class içindeki kümedeki bir bilgiye iç içe kümeler ile ulaşabiliyoruz


    }
    //base class
    class Person
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set;}
    }
    class PersonManager
    {
        public void Add(Person Person)
        {
            Console.WriteLine(Person.FirstName);
            //bu şekilde ana parametre olan Persondan bütün classlar ile çalışabiliriz.
        }
    }
}
