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
            Stopwatch s = new Stopwatch();
            s.Start();
            Folyamat f = new Folyamat();

            f.GYB(1000*30);

            s.Stop();
            f.Kiir();

            Console.WriteLine("++++++++++++++" + s.ElapsedMilliseconds);
           
            Console.ReadKey();
        }
    }
}
