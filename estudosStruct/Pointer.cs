using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace estudosStruct
{
    struct Pointer
    {
        public double x, y;

        // topico de alocação de memoria;
        public string nameProduct;
        public double value;
        public int quantity;

       

        public override string ToString()
        {
            return "{ " + x + ", " + y + " }" ;
        }


    }
}
