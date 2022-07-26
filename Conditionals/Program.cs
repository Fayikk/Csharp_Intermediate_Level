using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public class Program
    {
        static void Main(string[] args)
        {
            var number = 10;
            ////Console.WriteLine(number == 10 ? "Number is 10" : "Value error");
            //if (number == 10)
            //{
            //    Console.WriteLine("Number is 9");

            //}
            //else if (number == 11)
            //{
            //    Console.WriteLine("Girilen sayı 10 degerinden büyüktür");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen sayı değeri hatalıdır.");
            //}
            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("sayının değeri 10'dir");
            //        break;
            //}

            if (number>=0 && number<=100)
            {

                Console.WriteLine("Number is Beetwen 0-100");
            }
            else if (number>100 && number<=200) {
            
                Console.WriteLine("Number is Beetwen 101-200");

            }
            else
            {
                Console.WriteLine("Value error");
            }


            Console.ReadLine();
        }
    }
}
