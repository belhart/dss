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
            AllOrder ao = new AllOrder();
            ao.OneOrderValue(ao.orders.First());
            ao.Show(ao.orders.First());

            Console.ReadKey();
        }
    }
}
