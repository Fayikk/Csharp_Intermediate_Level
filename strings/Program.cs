using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Referans tipler
            //metinsel verileri tutmak için kullanılan değişken tipleridir.
            string city = "Brooklyn";
            Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                
                Console.WriteLine(item);
            }
            string city2 = "Callifornia";
            string result = city + city2;
            Console.WriteLine(result);
            Console.WriteLine(string.Format("{} {}",city, city2));
               
        }
    }
}
