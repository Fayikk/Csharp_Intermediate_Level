using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_And_reference
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int boolean,enum double decimal value type
            int number1 = 10;
            int number2 = 20;
            
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);
            Console.WriteLine(10);

            string[] cities = new string[] { "Ankara", "Adana", "Diyarbakır" };
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };
            cities2 = cities;
            //cities2 cities'in referansını tuttuğu için .net garbage collector sayesinde tutulmayan referans' belleekteki alanı atacaktır.
            cities[0] = "İstanbul";
            foreach (var city in cities2)
            {

                Console.WriteLine(city);
            }
            




        }
    }
}
