﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dssgyak
{
    class Gep
    {
        public int hanyadikmenet = 1;

        // mikor fejezte be a termékeket
        public List<int> naplo;
        // mennyi idő alatt csinál 1et
        public int ido;
        public string name;
        

        public Gep()
        {
            naplo = new List<int>();
            
        }
    }
}
