using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classies
{
    //class CustomerManager
    //{
    //    public void Add()
    //    {
    //        Console.WriteLine("Customer Added");
    //    }
    //    public void Updated()
    //    {
    //        Console.WriteLine("Updated");
    //    }
    //}

    
    public class Program
    {
        static void Main(string[] args)
        {   
            //Burada CustomerManager'ın bir örneğini oluşturma işlemini gerçekleştirdik.
            CustomerManager customerManager = new CustomerManager();    
            ProductManager productManager = new ProductManager();
           
            customerManager.Add();
            customerManager.Updated();

            productManager.Updated();
            productManager.Add();
            Customer customer = new Customer();

            customer.ID = 1;
            customer.FirstName = "Fayik";
            customer.LastName = "Veznedaroglu";
            customer.City = "Brooklyn";
            Console.WriteLine("*******");
            //2.kullanım
            Customer customer2 = new Customer
            {
                  ID = 2,FirstName="Mustafa",LastName="Veznedaroglu",City="Elazıg",
            };
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer2.LastName);
            Console.WriteLine(customer2.ID);
            Console.WriteLine(customer2.City);

        }
    }
}
