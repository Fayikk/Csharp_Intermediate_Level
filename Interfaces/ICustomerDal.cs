using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Added");
        }

        public void Delete()
        {
            Console.WriteLine("SQL deleted");
            
        }

        public void Update()
        {
            Console.WriteLine("SQL Updated");

        }
    }
    

    class MySqlCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted");

        }

        public void Update()
        {
            Console.WriteLine("MySql Updated");

        }
    }


    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");

        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");

        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");

        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
