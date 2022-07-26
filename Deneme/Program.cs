using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{   //Bir class birden fazla interface ile implemente edilebilir!!!!!!
    interface IFactory
    {
         int ExitDate { get; set; }
    }
    class Mercedes : ICars,IFactory
    {
        public string Engineer { get ; set ; }
        public int Hp { get ; set ; }
        public string Model { get ; set ; }
        public int ExitDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Exit()
        {
            throw new NotImplementedException();
        }

        public void ModelYear()
        {
            throw new NotImplementedException();
        }

        
    }

    public class Wolksvagen : ICars, IFactory
    {
        public string Engineer { get; set; }
        public int Hp { get; set; }
        public string Model { get; set; }
        public int ExitDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Exit()
        {
            throw new NotImplementedException();
        }

        public void ModelYear()
        {
            throw new NotImplementedException();
        }
    }

    public class Ford : ICars, IFactory
    {
        public string Engineer { get; set; }
        public int Hp { get; set; }
        public string Model { get; set; }
        public int ExitDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Exit()
        {
            throw new NotImplementedException();
        }

        public void ModelYear()
        {
            throw new NotImplementedException();
        }
    }


    public class Exit 
    { 
        public void exit(ICars cars)
        {
            Console.WriteLine(cars.Model);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

            Mercedes mercedes = new Mercedes()
            {
                Engineer = "Fayik",
                Hp = 700,
                Model = "CLA"
            
            };

            Wolksvagen wolksvagen = new Wolksvagen()
            {
                Engineer = "Demir",
                Hp = 500,
                Model = "Passat"
            };

            Ford ford = new Ford()
            {
                Engineer = "Dennis",
                Hp = 1000,
                Model="Fiesta"
            };


            Ford[] ford1 = new Ford[2][{ },{ }];



            Console.WriteLine(ford.Engineer);
            Console.WriteLine(ford.Hp);
            Console.WriteLine(ford.Model);


            Console.WriteLine("*****************");
            Exit exits = new Exit();

            exits.exit(ford);


        }
    }
}
