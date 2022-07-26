using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Program
    {
        static void Add()
        {
            Console.WriteLine("Added!!!");
        }
        static int Add2(int number1,int number2)
        {
            var result= number1 + number2;
            return result;
        }
        //default parametreler ile çalışmak
        //default parametreler herzaman son metod olmak zorundadır.
        static int Add3(ref int number1,int number2=30)
        {
            return number1 + number2;
        }
        static int Add4(int number1,int number2)
        {
            number1 = 100;//metod içerisindeki değer baskındır.Çünkü static komuttan çağırma işlemi gerçekleştirdiğimiz zaman fonksiyonun içerisine gidecektir ve baskıon olan değişkeni alacaktır.
            return (number1 + number2);
        }

        //method overloading
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        
        //Overload edilen metod
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }
        
        //params kullanımı
        static int Add5(params int[] numbers)
        {
            return numbers.Sum();
        }

        static void Main(string[] args)
        {
            //Dont repeat yourself.
            //Add();
            ////var result2 = Add3(1);
            //var result1=Add2(10, 20);

            ////int number1 = 20;
            ////int number2 = 30;
            ////int result=Add4(ref int number1, int number);
            ////Console.WriteLine(result);  
            //Console.WriteLine(result1);
            ////Console.WriteLine(result2);
            ///
            Console.WriteLine(Add5(1, 2, 3, 4, 5, 6, 7, 8));

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 8));


            Console.ReadLine();
        }
        
    }
}
