using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dssgyak
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Folyamat f = new Folyamat();

            f.GYB(17);

            f.Kiir();
           
            Console.ReadKey();
        }
    }
}
