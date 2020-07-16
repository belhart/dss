using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dssgyak
{
    class Folyamat
    {
        GepCsoport gcs1;
        GepCsoport gcs2;
        GepCsoport gcs3;
        GepCsoport gcs4;
        GepCsoport gcs5;
        GepCsoport gcs6;
        List<Megrendeles> megrendeles;


        public Folyamat(string CSVFile)
        {
            
        }
        public Folyamat()
        {

        }

        // csak szépítés 
        GepCsoport GepCsoportMaker(int ido,int gepekszama,GepCsoport elozo)
        {
            GepCsoport gcs = new GepCsoport(elozo);
            for (int i = 0; i < gepekszama; i++)
            {
                gcs.gepek.Add(new Gep(ido));
            }
            return gcs;


        }

        public void GYB(int db)
        {
            
             gcs1 =  GepCsoportMaker(5, 6, null);

             gcs2 = GepCsoportMaker(10, 2, gcs1);

             gcs3 = GepCsoportMaker(8, 3, gcs2);

             gcs4 = GepCsoportMaker(5, 1, gcs3);

             gcs5 = GepCsoportMaker(12, 4, gcs4);

             gcs6 = GepCsoportMaker(10, 3, gcs5);

            gcs1.kovetkezofolyamat = gcs2;
            gcs2.kovetkezofolyamat = gcs3;
            gcs3.kovetkezofolyamat = gcs4;
            gcs4.kovetkezofolyamat = gcs5;
            gcs5.kovetkezofolyamat = gcs6;

            gcs1.Kezdes(db);


        }

        public void FB(int db)
        {
            gcs1 = GepCsoportMaker(8, 6, null);

            gcs2 = GepCsoportMaker(16, 2, gcs1);

            gcs3 = GepCsoportMaker(12, 3, gcs2);

            gcs4 = GepCsoportMaker(5, 1, gcs3);

            gcs5 = GepCsoportMaker(20, 4, gcs4);

            gcs6 = GepCsoportMaker(15, 3, gcs5);

            gcs1.kovetkezofolyamat = gcs2;
            gcs2.kovetkezofolyamat = gcs3;
            gcs3.kovetkezofolyamat = gcs4;
            gcs4.kovetkezofolyamat = gcs5;
            gcs5.kovetkezofolyamat = gcs6;

            gcs1.Kezdes(db);
        }

        public void SB(int db)
        {
            gcs1 = GepCsoportMaker(6, 6, null);

            gcs2 = GepCsoportMaker(15, 2, gcs1);

            gcs3 = GepCsoportMaker(10, 3, gcs2);

            gcs4 = GepCsoportMaker(5, 1, gcs3);

            gcs5 = GepCsoportMaker(15, 4, gcs4);

            gcs6 = GepCsoportMaker(12, 3, gcs5);

            gcs1.kovetkezofolyamat = gcs2;
            gcs2.kovetkezofolyamat = gcs3;
            gcs3.kovetkezofolyamat = gcs4;
            gcs4.kovetkezofolyamat = gcs5;
            gcs5.kovetkezofolyamat = gcs6;

            gcs1.Kezdes(db);
        }

        // csak debuggolás
        public void Kiir()
        {

            Console.WriteLine("1---------------------------------1");
            gcs1.Adatok();
            Console.WriteLine("2---------------------------------2");
            gcs2.Adatok();
            Console.WriteLine("3---------------------------------3");
            gcs3.Adatok();
            Console.WriteLine("4---------------------------------4");
            gcs4.Adatok();
            Console.WriteLine("5---------------------------------5");
            gcs5.Adatok();
            Console.WriteLine("6---------------------------------6");
            gcs6.Adatok();
        }

       
    }
}
