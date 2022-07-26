using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Loops
{
    public class Program
    {
        static void Main(string[] args)
        {
            var karakter = 'a';
            var sayac = 0;

            Console.WriteLine(karakter);
            //do
            //{
            //    sayac++;
            //    Console.WriteLine(sayac);
            //    Console.WriteLine("devam etmek istermisiniz(y/n)");

            //} while (karakter=='n');
            do
            {
                sayac++;
                Console.WriteLine(sayac);
            } while (sayac<10);
        }
    }
}
