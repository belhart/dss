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

            DateTime d = new DateTime(2020, 7, 18, 18, 0, 0);

            double dd = (d - DateTime.Now).TotalDays;


            Console.WriteLine(dd);

            Console.ReadKey();
        }
    }
}
