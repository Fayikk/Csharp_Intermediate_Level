using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {

            string sentence = "My name is Fayik vznd";
            var result= sentence.Length;
            var result2 = sentence.Clone();//Bu clonelama ifadei ile bir değişkne daha oluşturmuş olduk.
            //sentence = "My name is BLA BLA";
            bool result3 = sentence.EndsWith("d");
            bool result4 = sentence.StartsWith("s");
            //bir stringte belli bir karakteri veya ifadeyi aramak için kullanılır ındexof() karakteri.

            var result5 = sentence.IndexOf("name");//name'in kaçıncı karakterden başladığına bize gösterecektir.
            var result6 = sentence.IndexOf("");
            var result7 = sentence.LastIndexOf("Fayik");//Burada indexof ile aynı işlmeleri gerçekleştirilr ancak aramaya sondan başlanacaktır.

            //bir cümleye veya bir ifadeye başka bir ifade veya ifade dizisi eklemek iiçin kullamnılır.Insert ifadesi.
            var result8 = sentence.Insert(2, "docker");
            Console.WriteLine(result8);

            //Metni paraçalamak için substring() metodu kullanılır.
            var result9 = sentence.Substring(2);

            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();

            //Replace metodu sayesinde istenen karakterlerin değişmesini istediğimiz karakterleri değişecektir.
            var result12 = sentence.Replace(" "," -");



            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result7);
            Console.WriteLine(result6);
            //boşluk bir karakter olarak sayılacaktır.
            Console.WriteLine(result5);
            Console.WriteLine(result4);
            Console.WriteLine(result3);
            Console.WriteLine(sentence);
            Console.WriteLine(result2);  
        }
    }
}
