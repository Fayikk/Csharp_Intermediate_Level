using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
         //Dictionary'de anahtar,değer hangi türde olduğunu belirtmemiz gerekecektir. 
            Dictionary<string,int> dictionary =new Dictionary<string, int>();
            dictionary.Add("table", 1);
            dictionary.Add("Book", 2);
            dictionary.Add("computer", 3);

            var result = dictionary["computer"];
            Console.WriteLine(result);

            Dictionary<string,string> dictionary1=new Dictionary<string,string>();
            dictionary1.Add("software", "yazılım");
            dictionary1.Add("Department", "Bölüm");
            dictionary1.Add("Artifical Intelligence", "Yapay Zeka");

            var result1 = dictionary1["software"];
            Console.WriteLine(result1);
            
            foreach (var item in dictionary1)
            {

                Console.WriteLine("Dictionary\n {0} : {1}", item.Key, item.Value);
                //Console.WriteLine(item.Key);
                //Console.WriteLine(item.Value);
            }


            var result3 = dictionary1.ContainsKey("Department");//ContainsKey() METODU İLE BOOLEAN DEĞER TİPİ İLE TRUE YADA FALSSE DEĞER DÖNDÜRECEKTİR. 
            Console.WriteLine(result3);
        
        }
    }
}
