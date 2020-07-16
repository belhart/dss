using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DSS
{
    public class Megrendeles
    {
        public string MegrendelesID { get; set; }
        public int MegrendelesTipus { get; set; } // 0 GYB, 1 FB, 2 SB
        public int MegrendelesSzam { get; set; }
        public DateTime Hatarido { get; set; }
        public int ProfitPerDB { get; set; }
        public int Buntetes { get; set; }
        private static Random random = new Random();

        public Megrendeles(string[] line)
        {
            _ = line[0] == null ? this.MegrendelesID = line[0] : this.MegrendelesID = RandomString(10);
            _ = line[1] == null ? this.MegrendelesTipus = int.Parse(line[1]) : this.MegrendelesTipus = 0; // teljes rendelés kihagyás mert nem biztos mit akar a vevő?
            _ = line[2] == null ? this.MegrendelesSzam = int.Parse(line[2]) : this.MegrendelesSzam = 0; // teljes rendelés kihagyás mert nem biztos mit akar a vevő?
            _ = line[3] == null ? this.Hatarido = DateTime.Now : DateTime.Now; //rendesen parsolni a szövegből
            _ = line[4] == null ? this.ProfitPerDB = int.Parse(line[4]) : this.ProfitPerDB = 0;
            _ = line[5] == null ? this.Buntetes = int.Parse(line[5]) : this.Buntetes = 0;
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
