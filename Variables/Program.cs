using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    enum Days
    {
        //Enum sabitleri
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
        
    }
    public class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            short number3 = -32768;
            long number2 = 122222222222222;
            byte number4 = 255;
            bool Yanlıs = false;
            bool Dogru =true;
            char karakter = 'c';
            double Value = 1.56;
            decimal desimal = 10.5m;

            //var keyword'ü
            var number7 = 10;
            var kelime = "Fayik";
            number7 = 'c';
            Console.WriteLine(number7);
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);
            //long number3 = 30001200;
            //Console.WriteLine("Number 1 is :{0} {1}",number1);
            Console.WriteLine(number3);
            Console.WriteLine(number2);
            Console.WriteLine(number4);
            Console.WriteLine(Value);
            Console.WriteLine((int)karakter);
        }
    }
}
