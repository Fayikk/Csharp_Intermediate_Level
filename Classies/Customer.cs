using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classies
{
    public class Customer
    {   //bu yapıların hepsi birer field'tır alan tanımlamak'ta denilebilir.

       
        public int ID { get; set; }

        //private string _firstname;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
