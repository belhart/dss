using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSS
{
    class Gep
    {
        public int hanyadikmenet = 1;

        // mikor fejezte be a termékeket
        public List<int> naplo;
        // mennyi idő alatt csinál 1et
        public int ido;


        public Gep(int ido)
        {
            naplo = new List<int>();
            this.ido = ido;
        }
    }
}
