using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace dssgyak
{
    public class Order
    {
        public int fullprize;
        public double minutesleft;
        public int fulltime;
        public int fullpenalty;


        public string OrderID { get; set; }
        public int OrderType { get; set; } // 0 GYB, 1 FB, 2 SB
        public int OrderAmount { get; set; }
        public DateTime Deadline { get; set; }
        public int ProfitPerUnit { get; set; }
        public int Penalty { get; set; }
        private static Random random = new Random();

        public Order(string[] line)
        {
           /* _ = line[0] != null ? this.OrderID = line[0] : this.OrderID = RandomString(10);
            _ = line[1] != null ? this.OrderType = int.Parse(line[1]) : this.OrderType = 0; // teljes rendelés kihagyás mert nem biztos mit akar a vevő?
            _ = line[2] != null ? this.OrderAmount = int.Parse(line[2]) : this.OrderAmount = 0; // teljes rendelés kihagyás mert nem biztos mit akar a vevő?
            _ = line[3] != null ? this.Deadline = DateTime.Now : DateTime.Now; //rendesen parsolni a szövegből
            _ = line[4] != null ? this.ProfitPerUnit = int.Parse(line[4]) : this.ProfitPerUnit = 0;
            _ = line[5] != null ? this.Penalty = int.Parse(line[5]) : this.Penalty = 0;
            */

            fullprize = ProfitPerUnit * OrderAmount;
            minutesleft = (Deadline - DateTime.Now).TotalMinutes;  // hátralevő percek (nem vagyok hajlandó dátumokkal számolni)
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
