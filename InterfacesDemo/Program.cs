using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//   INTERFACE SEGREGATİON PRİNCİPLE
namespace InterfacesDemo
{//şirkette çeşitli çalışanlar mevcut,işçiler yöneticiler ve robotlar.
    interface IWorker
    {
        void Work();
        
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    //bir class birden fazla interface'i implemente edebilir.
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Employee : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }









    public class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
            new Manager(),
            new Employee(),
            new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats=new IEat[2]
            {
            new Manager(),
            new Employee()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

            ISalary[] salaries=new ISalary[2]
            {
            new Manager(),
            new Employee()
            };
            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }
        }
    }
}
