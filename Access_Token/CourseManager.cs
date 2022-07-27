using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Token
{//Bir class ya interanl olur yada protected olmaktadır.
 //İç içe classlarda,içerideki class private olarak tanımlanabilmektedir.

    public class CourseManager
    {
        public void Add()
        {

            Course course = new Course();//Interanl eriim bildirgecine sahip olduğu için ulaşılabilmeketdir.     }

        }
        private class NestedClass
        {

        }
      }
}
