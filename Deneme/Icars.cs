using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public interface ICars
    {
         string Engineer { get; set; }
         int Hp { get; set; }
        string Model { get; set; }

        void ModelYear();
        void Exit();

    }
}
