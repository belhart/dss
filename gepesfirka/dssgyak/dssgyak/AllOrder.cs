using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dssgyak
{
    class AllOrder
    {
        public List<Order> orders;
        Folyamat f;

        public AllOrder()
        {
            f = new Folyamat();
            orders = new List<Order>();
            //teszt
            Order o1 = new Order(null);
            o1.Deadline = new DateTime(2020, 7, 18, 18, 0, 0);
            o1.OrderAmount = 1000;
            o1.OrderType = 0;
            o1.Penalty = 20000;
            o1.ProfitPerUnit = 2000;
            o1.fullprize = o1.ProfitPerUnit * o1.OrderAmount;
            o1.minutesleft = (o1.Deadline - DateTime.Now).TotalMinutes;
            orders.Add(o1);
        }

        public void OneOrderValue(Order o)
        {
            if (o.OrderType == 0)
            {
                o.fulltime = f.GYB(o.OrderAmount);
            }
            else if (o.OrderType == 1)
            {
                o.fulltime = f.FB(o.OrderAmount);
            }
            else if (o.OrderType == 2)
            {
                o.fulltime = f.SB(o.OrderAmount);
            }


            double def = o.minutesleft - o.fulltime;

            double d = 0;
            if (def < 0)
            {
                 d = def / 1440;
                if (d % 1 != 0)
                {
                    d = Math.Floor(d);
                }
            }
            o.fullpenalty =Convert.ToInt32( d * o.Penalty);


        }

        public void Show(Order o)
        {
            f.Kiir();

            Console.WriteLine("orderdetails");

            Console.WriteLine("bünti" + o.fullpenalty);
            Console.WriteLine("zsé"+ o.fullprize);
            Console.WriteLine("ido" + o.fulltime);
            Console.WriteLine("csuszas" + (o.minutesleft - o.fulltime));
            Console.WriteLine("osszpénz" + (o.fullprize + o.fullpenalty));

        }


    }
}
