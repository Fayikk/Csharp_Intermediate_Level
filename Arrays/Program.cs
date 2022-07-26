using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            //referans tip stringler.
            //string student1 = "Fayik";
            //string student2 = "Derin";
            //string student3 = "Bambam";
            //string tanımlaması aşağıdaki gibi yapılmaktadır.
            string[] students=new string[3];
            students[0] = "Engin";
            students[1] = "Mustafa";
            students[2] = "Ecem";

            //array tanımı 2
            string[] students1 = new[] {"fayik","deren","salih"};


            //array tanımı3
            string[] students2 = { "tanımlamla"};

            //array tanımı4 
            string[] students3 = new string[3] { "bu", "bir", "denemedir" };
            foreach (var item in students1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("******");
            foreach (var item in students3)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("*******");

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
