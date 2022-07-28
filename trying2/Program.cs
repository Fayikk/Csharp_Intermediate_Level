using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trying2
{
    public class Car
    {
        public int Year { get; set; }
        public string Brand { get; set; }
        public string  Model { get; set; }

    }


    public class Program
    {
        static void Main(string[] args)
        {
            ArraySegmen1();
            Cars();
            List<string> deneme = new List<string> { "Yazılım", "Tıp", "Ekonomi" }; //type safe sağlanması açısından kullanılırç

            foreach (var d1 in deneme)
            {
                Console.WriteLine(d1);
            }

            Console.WriteLine("********************");

            for (int i = 0; i < deneme.Capacity-1; i++)
            {
                Console.WriteLine(deneme[i]);
            }


        }


        

        
        
        private static void Cars()
        {
            List<Car> car = new List<Car>();
            car.Add(new Car { Brand = "Ford", Model = "Focus", Year = 2018 });
            car.Add(new Car { Brand = "Bugatti", Model = "Veyron", Year = 2020 });

            foreach (var c1 in car)
            {
                Console.WriteLine(c1.Brand);
                Console.WriteLine(c1.Model);
                Console.WriteLine(c1.Year);

                Console.WriteLine("*********");



            }
        }

        private static void ArraySegmen1()
        {
            ArrayList deneme = new ArrayList();//not type safe

            deneme.Add("Fayik");
            deneme.Add(1);
            deneme.Add('a');
            deneme.Add(1.2d);

            foreach (var d1 in deneme)
            {
                Console.WriteLine(d1);
            }
        }
    }
}
