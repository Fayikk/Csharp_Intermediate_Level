using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritancee
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string City { get; set; }
    }
    class Student:Person
    {
        public string Department { get; set; }
    }
//bir sınıf birden fazla sınıf ile kalıtım alamazlar.



    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer=new Customer();
            Person[] person=new Person[3]
            {
                new Customer{FirstName="Fayik"},
                new Student{FirstName="Bambam"},
                new Person{FirstName="Mustafa fevzi"}
            };

            foreach (var human in person)
            {
                Console.WriteLine(human.FirstName);
            }
            
        }
    }
}
