﻿using System;
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

            f.GYB(17);
            f.GYB(10);
            f.Kiir();

            Console.ReadKey();
        }
    }
}
