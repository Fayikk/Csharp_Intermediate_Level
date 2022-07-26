using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multipl_Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            //multi dimension arrays
            string[,] regions = new string[5, 3]
            {
                {"İstanbul","Kocaeli","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Mersin" },
                {"İzmir","Muğla","Manisa" }
                
            };

            foreach (var item in regions)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");
            for (int i = 0; i < regions.GetUpperBound(0)+1; i++)
            {
                for (int j = 0; j < regions.GetUpperBound(1)+1; j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("**********");
            }
            //regions[0, 0] = "istanbul";
            
        }
    }
}
