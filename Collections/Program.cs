using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Günümüzde neeredeyse artık array kullanmamaktayız.Koleksiyonlar ile bu işi çözmekteyiz.
namespace Collections
{
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
    public class Program
    {//Yeniden newlemek demek yeniden referans almak demektir.
        static void Main(string[] args)
        {
          
            //string[] cities = new string[2] { "Ankara", "İstanbul" };
           ////cities[2]="Diyarbakır" -> Eğer bu kodu çalıştırmaya çalışırsak patlarız çünkü indeksin sınırlarını aşmış olacağız.Zerobase ile işlem yapmaktayız.
            //cities = new string[3]; //New'lediğimiz anda yeni referans oluşturulacaktır.
           //Console.WriteLine(cities[0]);



            //Burada ise ben bir koleksiyon oluşturmak istiyorum evet ama bu koleksiyon ile yalnızca string ile çalışabilirim anlamına gelmektedir.
            List<string> cities=new List<string>();
            cities.Add("Diyarbakır");
            cities.Add("Elazığ");
            cities.Add("Malatya");
            cities.Add("Paris");
            cities.Add("Stockholm");
            //string colection generics ile string tip dışında ekleme yapılamamaktadır.
            //etc
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("******");
            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=10,FirstName="Muhammed emre"},
                new Customer{Id=11,FirstName="Seda Arslan Tuncer"},
                new Customer { Id = 10, FirstName = "Deniz" }
        };

            //List<Customer> customers1 = new List<Customer>
            //{
            //    new Customer{Id=1,FirstName="Mustafa"},
            //    new Customer{Id=3,FirstName="Füsun"}
            //};
            //var count = customers1.Count;
            //Console.WriteLine("*************"+count);


            //customers.Add(new Customer { Id = 1, FirstName = "Fayik" });
            //customers.Add(new Customer { Id = 2, FirstName = "Bambam" });
            //customers.Add(new Customer { Id = 4, FirstName = "Ecem" });

            var customers2 = new Customer { Id = 10, FirstName = "Deniz" };

            var result = customers.IndexOf(customers2);
            Console.WriteLine("Index: {0}", result);
            Console.WriteLine(result);


            //Console.WriteLine(customers);

            foreach (var c in customers)
            {
                Console.WriteLine(c.Id);
                Console.WriteLine(c.FirstName);
;           }
            Console.WriteLine("**********************");
            //foreach (var c2 in customers1)
            //{
            //    Console.WriteLine(c2.Id);
            //    Console.WriteLine(c2.FirstName);
            //    Console.WriteLine("*************");
            //}
        
        }

        private static void ArrayLists()
        {
            //Arraylist bir koleksiyondur.
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            cities.Add("Diyarbakır");
            cities.Add(6);
            cities.Add('a');
            Console.WriteLine(cities[2]);

            Console.WriteLine("****************");
            foreach (var city1 in cities)
            {
                Console.WriteLine(city1);
            }
        }
    }
}
