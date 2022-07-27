using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//virtual ile override etme işlemini gerçekleştiriyoruz.
//Virtual metod ile isteyen isetdiği metodları ezme özelliğine sahiptir.
namespace Virtual_Methods
{
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }
    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql server");
        }
    }

    class MySql : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by MySql server");
        }
    }

    class Oracle:Database 
    {
            

    }
   

    public class Program
    {
        static void Main(string[] args)
        {
            //Virtual metodu ile override işlemi yapılmış metodları barındıran sınıflar.
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

            Console.WriteLine("**************");

            Oracle oracle=new Oracle();
            oracle.Add();

            


        }
    }
}
