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
            
            //Folyamat f = new Folyamat(CSVFile); // majd ez a rendes programban
            Folyamat f = new Folyamat();

            int a = f.GYB(13);
            int b = f.SB(15);
            f.FB(20);

            f.Kiir();

            Console.WriteLine(a + " " + b);

            Console.ReadKey();
        }
    }
}
