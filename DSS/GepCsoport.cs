using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace DSS
{
    class GepCsoport
    {
        public List<Gep> gepek;
        public GepCsoport elozofolyamat;
        public GepCsoport kovetkezofolyamat;


        public GepCsoport(GepCsoport elozofolyamat)
        {
            gepek = new List<Gep>();
            this.elozofolyamat = elozofolyamat;

        }

        //csak a legelső gépnél kell
        public void Kezdes(int mennyit)
        {
            if (elozofolyamat == null)
            {
                for (int i = 0; i < mennyit; i++)
                {
                    Gep g = gepek.FirstOrDefault(x => x.naplo.Count == gepek.Min(y => y.naplo.Count));
                    g.naplo.Add(g.ido * g.hanyadikmenet);
                    g.hanyadikmenet++;
                    if (kovetkezofolyamat != null)
                    {
                        //amint kész továbbpasszolja a cuccot
                        kovetkezofolyamat.Dolgozik(g);
                    }

                }
            }
        }


        void Dolgozik(Gep kapottgep)
        {
            // mindig az a gép ami kevesebbet dolgozott
            Gep g = gepek.FirstOrDefault(x => x.naplo.Count == gepek.Min(y => y.naplo.Count));

            //előző folyamathoz képest
            int eltolodas = kapottgep.naplo.Max();

            // ezt meg én se értem
            if (((g.naplo.Count() != 0) ? g.naplo.Max() : 0) > eltolodas)
            {
                g.naplo.Add(g.naplo.Max() + g.ido);
            }
            else
            {
                g.naplo.Add(eltolodas + (g.ido));
            }


            g.hanyadikmenet++;
            // ha kell itt is továbbpasszol
            if (kovetkezofolyamat != null)
            {
                kovetkezofolyamat.Dolgozik(g);
            }

        }


        // csak debuggolás 
        public void Adatok()
        {
            Console.WriteLine();
            int i = 1;
            foreach (var item in gepek)
            {
                Console.WriteLine("gep" + i);
                i++;
                foreach (var item2 in item.naplo)
                {
                    Console.Write(" " + item2);
                }
                Console.WriteLine();
            }
        }

    }
}
