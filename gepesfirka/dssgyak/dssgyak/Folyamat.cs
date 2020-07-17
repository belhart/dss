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
        #region machines
        GepCsoport gcs1;
        GepCsoport gcs2;
        GepCsoport gcs3;
        GepCsoport gcs4;
        GepCsoport gcs5;
        GepCsoport gcs6;
        List<Megrendeles> megrendeles;

        Gep cutter1;
        Gep cutter2;
        Gep cutter3;
        Gep cutter4;
        Gep cutter5;
        Gep cutter6;

        Gep bender1;
        Gep bender2;

        Gep welder1;
        Gep welder2;
        Gep welder3;

        Gep tester1;

        Gep painter1;
        Gep painter2;
        Gep painter3;
        Gep painter4;

        Gep packer1;
        Gep packer2;
        Gep packer3;

        #endregion
        void Hierarchy()
        {
            gcs1 = new GepCsoport(null);
            gcs2 = new GepCsoport(gcs1);
            gcs3 = new GepCsoport(gcs2);
            gcs4 = new GepCsoport(gcs3);
            gcs5 = new GepCsoport(gcs4);
            gcs6 = new GepCsoport(gcs5);

            gcs1.kovetkezofolyamat = gcs2;
            gcs2.kovetkezofolyamat = gcs3;
            gcs3.kovetkezofolyamat = gcs4;
            gcs4.kovetkezofolyamat = gcs5;
            gcs5.kovetkezofolyamat = gcs6;



            cutter1 = new Gep();
            cutter2 = new Gep();
            cutter3 = new Gep();
            cutter4 = new Gep();
            cutter5 = new Gep();
            cutter6 = new Gep();

            gcs1.gepek.Add(cutter1);
            gcs1.gepek.Add(cutter2);
            gcs1.gepek.Add(cutter3);
            gcs1.gepek.Add(cutter4);
            gcs1.gepek.Add(cutter5);
            gcs1.gepek.Add(cutter6);

            bender1 = new Gep();
            bender2 = new Gep();

            gcs2.gepek.Add(bender1);
            gcs2.gepek.Add(bender2);

            welder1 = new Gep();
            welder2 = new Gep();
            welder3 = new Gep();

            gcs3.gepek.Add(welder1);
            gcs3.gepek.Add(welder2);
            gcs3.gepek.Add(welder3);

            tester1 = new Gep();

            gcs4.gepek.Add(tester1);

            painter1 = new Gep();
            painter2 = new Gep();
            painter3 = new Gep();
            painter4 = new Gep();

            gcs5.gepek.Add(painter1);
            gcs5.gepek.Add(painter2);
            gcs5.gepek.Add(painter3);
            gcs5.gepek.Add(painter4);

            packer1 = new Gep();
            packer2 = new Gep();
            packer3 = new Gep();

            gcs6.gepek.Add(packer1);
            gcs6.gepek.Add(packer2);
            gcs6.gepek.Add(packer3);
        }
        public Folyamat(string CSVFile)
        {
            Hierarchy();
        }


        public Folyamat()
        {
            
           

        }

        void MachineSetUp(int firsttime, int secondtime, int thirdtime, int fourthtime, int fifthtime, int sixthtime)
        {
            foreach (var item in gcs1.gepek)
            {
                item.ido = firsttime;
            }

            foreach (var item in gcs2.gepek)
            {
                item.ido = secondtime;
            }

            foreach (var item in gcs3.gepek)
            {
                item.ido = thirdtime;
            }

            foreach (var item in gcs4.gepek)
            {
                item.ido = fourthtime;
            }

            foreach (var item in gcs5.gepek)
            {
                item.ido = fifthtime;
            }

            foreach (var item in gcs6.gepek)
            {
                item.ido = sixthtime;
            }

           



        }

        public int GYB(int db)
        {

            MachineSetUp(5, 10, 8, 5, 12, 10);

            gcs1.Kezdes(db);
            return gcs6.gepek.FirstOrDefault(x => x.naplo.Max() == gcs6.gepek.Max(y => y.naplo.Max())).naplo.Max();


        }

        public int FB(int db)
        {
            MachineSetUp(8, 16, 12, 5, 20, 15);

            gcs1.Kezdes(db);

            return gcs6.gepek.FirstOrDefault(x => x.naplo.Max() == gcs6.gepek.Max(y => y.naplo.Max())).naplo.Max();

        }

        public int SB(int db)
        {
            MachineSetUp(6, 15, 10, 5, 15, 12);

            gcs1.Kezdes(db);

            return gcs6.gepek.FirstOrDefault(x => x.naplo.Max() == gcs6.gepek.Max(y => y.naplo.Max())).naplo.Max();
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
