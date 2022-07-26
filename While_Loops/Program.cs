using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loops
{
    public class Program
    {
        static void Main(string[] args)
        {   //while ile belli bir şart sağlanana kadar döngü çalışmaya devam edecektir.
            var sayac = 0;
            while (sayac<=100)
            {
                sayac++;
                Console.WriteLine(sayac);
            }
        }
    }
}
