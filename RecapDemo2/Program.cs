using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public IPing Pinger { get; set; }

        public void Add()
        {
            Logger.Log();
            Console.WriteLine("ADDED!!");
        }


    }

    
    class DataBaseLogger : ILogger,IPing
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }

        public void Ping()
        {
            Console.WriteLine("DataBaseLogger for throw ping");
        }
    }

    class FileLogger : ILogger,IPing
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");

        }

        public void Ping()
        {
            Console.WriteLine("FileLogger for throw ping");
        }
    }

    class SmsLogger : ILogger,IPing
    {
        public void Log()
        {
            Console.WriteLine("Logged to Sms");
        }

        public void Ping()
        {
            Console.WriteLine("SmsLogger for throw ping");

        }
    }

    interface IPing
    {
        void Ping();
    }


    interface ILogger
    {
        void Log();
    }

    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            CustomerManager customerManager1 = new CustomerManager();
            customerManager.Logger= new FileLogger();
            customerManager.Add();
            FileLogger fileLogger = new FileLogger();
            fileLogger.Ping();

            //customerManager1.Pinger = new SmsLogger();

            
            

    

            
            
            
        }
    }
}
