using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DSS
{
    class Processor
    {
        MachinesGroup MachineGroup1;
        MachinesGroup MachineGroup2;
        MachinesGroup MachineGroup3;
        MachinesGroup MachineGroup4;
        MachinesGroup MachineGroup5;
        MachinesGroup MachineGroup6;
        List<Order> orders;


        public Processor(string CSVFile)
        {

        }
        public Processor()
        {

        }

        // csak szépítés 
        MachinesGroup MachinesGroupMaker(int time, int machineNumber, MachinesGroup pervious)
        {
            MachinesGroup gcs = new MachinesGroup(pervious);
            for (int i = 0; i < machineNumber; i++)
            {
                gcs.machines.Add(new Machine(time));
            }
            return gcs;


        }

        public void GYB(int db)
        {

            MachineGroup1 = MachinesGroupMaker(5, 6, null);

            MachineGroup2 = MachinesGroupMaker(10, 2, MachineGroup1);

            MachineGroup3 = MachinesGroupMaker(8, 3, MachineGroup2);

            MachineGroup4 = MachinesGroupMaker(5, 1, MachineGroup3);

            MachineGroup5 = MachinesGroupMaker(12, 4, MachineGroup4);

            MachineGroup6 = MachinesGroupMaker(10, 3, MachineGroup5);

            MachineGroup1.nextProcess = MachineGroup2;
            MachineGroup2.nextProcess = MachineGroup3;
            MachineGroup3.nextProcess = MachineGroup4;
            MachineGroup4.nextProcess = MachineGroup5;
            MachineGroup5.nextProcess = MachineGroup6;

            MachineGroup1.Start(db);


        }

        public void FB(int db)
        {
            MachineGroup1 = MachinesGroupMaker(8, 6, null);

            MachineGroup2 = MachinesGroupMaker(16, 2, MachineGroup1);

            MachineGroup3 = MachinesGroupMaker(12, 3, MachineGroup2);

            MachineGroup4 = MachinesGroupMaker(5, 1, MachineGroup3);

            MachineGroup5 = MachinesGroupMaker(20, 4, MachineGroup4);

            MachineGroup6 = MachinesGroupMaker(15, 3, MachineGroup5);

            MachineGroup1.nextProcess = MachineGroup2;
            MachineGroup2.nextProcess = MachineGroup3;
            MachineGroup3.nextProcess = MachineGroup4;
            MachineGroup4.nextProcess = MachineGroup5;
            MachineGroup5.nextProcess = MachineGroup6;

            MachineGroup1.Start(db);
        }

        public void SB(int db)
        {
            MachineGroup1 = MachinesGroupMaker(6, 6, null);

            MachineGroup2 = MachinesGroupMaker(15, 2, MachineGroup1);

            MachineGroup3 = MachinesGroupMaker(10, 3, MachineGroup2);

            MachineGroup4 = MachinesGroupMaker(5, 1, MachineGroup3);

            MachineGroup5 = MachinesGroupMaker(15, 4, MachineGroup4);

            MachineGroup6 = MachinesGroupMaker(12, 3, MachineGroup5);

            MachineGroup1.nextProcess = MachineGroup2;
            MachineGroup2.nextProcess = MachineGroup3;
            MachineGroup3.nextProcess = MachineGroup4;
            MachineGroup4.nextProcess = MachineGroup5;
            MachineGroup5.nextProcess = MachineGroup6;

            MachineGroup1.Start(db);
        }

        // csak debuggolás
        public void Kiir()
        {

            System.Diagnostics.Debug.WriteLine("1---------------------------------1");
            MachineGroup1.Data();
            System.Diagnostics.Debug.WriteLine("2---------------------------------2");
            MachineGroup2.Data();
            System.Diagnostics.Debug.WriteLine("3---------------------------------3");
            MachineGroup3.Data();
            System.Diagnostics.Debug.WriteLine("4---------------------------------4");
            MachineGroup4.Data();
            System.Diagnostics.Debug.WriteLine("5---------------------------------5");
            MachineGroup5.Data();
            System.Diagnostics.Debug.WriteLine("6---------------------------------6");
            MachineGroup6.Data();
        }


    }
}
