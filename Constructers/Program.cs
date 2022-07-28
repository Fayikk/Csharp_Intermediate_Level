using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructers
{
    //Bir sınıf genel anlamda newlendiğinde çalışacak kod bloğudur.
    interface ILogger
    {
        void Log();
    }
    class DataBaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }

    class EmployeeManager
    {
        public ILogger Logger { get; set; }

        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Added!");
        }
    }



    class CustomerManager
    {
        private int count;
        public void List()
        {
            Console.WriteLine("Listed {0} items",count);
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
        public CustomerManager(int count)
        {
            Console.WriteLine("Working");
            this.count = count;
            Console.WriteLine("Ending");
        }
    }

    class Product
    {
        

        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id,string name)
        {
            _id = id;
            _name = name;   
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager(10);    
            manager.Add();


            Product product = new Product
            {
                Id = 1,
                Name = "Gamepad"
            };
            Product product2 = new Product(2,"Keyboard");
            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.Logger = new DataBaseLogger();
            employeeManager.Add();


        }
    }
}
