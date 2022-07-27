using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Token
{
    //private erişim bildirgeci sadece ve sadece tanımlandığı blok içerisinden ulaşılabiler bir yapıdır. 
    //protected'ta priavte gibi tanımlandığı blok içreisnde heryerde geçerlidir.
    //Ancak protected inherit edildiği sınıflarda kullanılabilmektedir.
   //İnternal bağlı olduğu proje içerisinde(assembly)'de herhangi bir şekilde engelle karşıalşmadan o proje içerisinde herhangi bir noktadan erişilebilir anlamına gelmektedir.
    
    class Customer
    {
        // Default olarak private değişkendir. 
        protected int id;
        private string name;
    }
    class Student:Customer
    {
        public void save()
        {
            Customer customer = new Customer();
            id = 2;
            Console.WriteLine(id);
            
        }
    }
    //Bir class'ın default değeri internal'dır.
    class Course
    {
        public string Name { get; set; }
    }

    public class Program
    {

        static void Main(string[] args)
        {
            Student student = new Student();
            student.save();
        }
    }
}
