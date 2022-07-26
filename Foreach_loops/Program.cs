using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_loops
{
    public class Program
    {
        static void Main(string[] args)
        {
            var number = 10;

         //var result=   number==10 =>  "girilen sayı 10'a eşittir" ? "Girilen sayı 10'a eşit değilidir";

            string[] personal = new string[3] { "Mustafa", "Füsun", "Ecem" };
            foreach (var item in personal)
            {

                Console.WriteLine(item);
            }

        
        }
    }
}
