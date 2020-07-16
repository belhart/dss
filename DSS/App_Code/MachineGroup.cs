using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace DSS
{
    class MachinesGroup
    {
        public List<Machine> machines;
        public MachinesGroup perviousProcess;
        public MachinesGroup nextProcess;


        public MachinesGroup(MachinesGroup perviousProcess)
        {
            machines = new List<Machine>();
            this.perviousProcess = perviousProcess;

        }

        //csak a legelső gépnél kell
        public void Start(int mennyit)
        {
            if (perviousProcess == null)
            {
                for (int i = 0; i < mennyit; i++)
                {
                    Machine g = machines.FirstOrDefault(x => x.naplo.Count == machines.Min(y => y.naplo.Count));
                    g.naplo.Add(g.time * g.hanyadikmenet);
                    g.hanyadikmenet++;
                    if (nextProcess != null)
                    {
                        //amint kész továbbpasszolja a cuccot
                        nextProcess.Working(g);
                    }

                }
            }
        }


        void Working(Machine kapottgep)
        {
            // mindig az a gép ami kevesebbet dolgozott
            Machine g = machines.FirstOrDefault(x => x.naplo.Count == machines.Min(y => y.naplo.Count));

            //előző folyamathoz képest
            int eltolodas = kapottgep.naplo.Max();

            // ezt meg én se értem
            if (((g.naplo.Count() != 0) ? g.naplo.Max() : 0) > eltolodas)
            {
                g.naplo.Add(g.naplo.Max() + g.time);
            }
            else
            {
                g.naplo.Add(eltolodas + (g.time));
            }


            g.hanyadikmenet++;
            // ha kell itt is továbbpasszol
            if (nextProcess != null)
            {
                nextProcess.Working(g);
            }

        }


        // csak debuggolás 
        public void Data()
        {
            System.Diagnostics.Debug.WriteLine('\n');
            int i = 1;
            foreach (var item in machines)
            {
                System.Diagnostics.Debug.WriteLine("gep" + i);
                i++;
                foreach (var item2 in item.naplo)
                {
                    System.Diagnostics.Debug.Write(" " + item2);
                }
                System.Diagnostics.Debug.WriteLine('\n');
            }
        }

    }
}
