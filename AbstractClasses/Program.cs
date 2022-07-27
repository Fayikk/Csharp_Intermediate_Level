using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Abstractlarda birer class'tır.
//İnterfaceler ile virtual metodlarının mixleme gibi düşünebiliriz.
namespace AbstractClasses
{
    //Abstract class'lar ile hem tamamlanmış hemde tamamlanmamış metodlar yapabiliyorsunuz.
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete(); 
    }
    class SqlServer : Database
    {
        //içi dolu olmayan virtual metodtur.
        //Herkesin ayrı ayrı implemente etmesi gereklidir.
        public override void Delete()
        {
            throw new NotImplementedException();
        }
    }

    class Oracle : Database
    {
        
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");

        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Abstract classlarda interface'ler gibi newlenemezler.
            Database db = new Oracle();
            db.Delete();
            db.Add();

            //Oracle o = new Oracle();
            //o.Add();
            //o.Delete();
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            sqlServer.Delete();
        }
    }
}
