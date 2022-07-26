using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IPerson//Soyutturlar
    {
        int ID { get; set; } //interfaceler yazılırken sadece özelliğin imzası yazılmalıdır.Erişim belirteci koyulmamalıdır.
        string Name { get; set; }
        string LastName { get; set; }
    }
    //Somuttur'lar
    class Customer : IPerson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }
    class Worker:IPerson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }
    class Student : IPerson
    {
        public int ID { get ; set ; }
        public string Name { get ; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)//parametre olarak bana bir müşteri nesnesi ver anlamına gelmektedir.
        {
            Console.WriteLine(person.Name);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //IPerson person = new IPerson();  interface'in instance'ını oluşturamazsın diye hata verecektir.Evet interfacelerin instance'ını oluşturamayız.
            //Demo();
            //bir verimiz var ve bi< bu veriyi şirketin hem sql hemde oracle veritabanına yazdırmak istiyoruz o zaman ne yaparız?
            ICustomerDal[] customerDals = new ICustomerDal[3] //ICustomerDal türünde array tanımlaması yaptık.
            { 
                new OracleServerCustomerDal(), 
                new SqlServerCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var item in customerDals)
            {
                item.Update();
            }
        
        
        
        }


       

        private static void Demo()
        {
            IPerson person1 = new Worker { ID = 1, Name = "SHAQ", LastName = "ONEAL", Adress = "USA" };
            CustomerManager customer = new CustomerManager();
            customer.Add(new OracleServerCustomerDal());//OracleCustomerDal için bellkete alan oluşturarak gerekliş atamaları yapıyoruz.
            customer.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            Customer customer = new Customer
            {
                ID = 1,
                Adress = "Turkey",
                LastName = "Veznedaroglu",
                Name = "Fayik"
            };

            Customer customer1 = new Customer
            {
                ID = 2,
                Adress = "Turkey",
                LastName = "Veznedaroglu",
                Name = "Mustafa"
            };
            Customer customer2 = new Customer
            {
                ID = 23,
                Name = "Muhammed Emre",
                LastName = "Çolak",
                Adress = "Elazig Firat University"

            };

            Student student = new Student
            {
                ID = 3,
                Name = "Kübra",
                Department = "Software",
                LastName = "Arslanoglu"
            };

            PersonManager manager = new PersonManager();
            manager.Add(customer);//PersonManager classından türetilen manager'a gerekli olan parametreleri tanımlamamzı gerekmektedir.Bu yüzden Custom sınıfından gerekli property'lerin tanımlamasını yapmış bulunmaktayız 
            manager.Add(customer1);

            manager.Add(student);
            manager.Add(customer2);

            manager.Add(new Worker { Adress = "Denmark", ID = 5, LastName = "Bryan", Name = "Kobe" });
        }
    }
}
