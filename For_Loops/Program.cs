using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loops
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1 den 100 kadar olan çift sayıları ekrana yazdırın.
            for (int i = 1; i < 101; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");

        }
    }
}
