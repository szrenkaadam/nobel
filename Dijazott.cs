using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nobel
{
    class Dijazott
    {
        public int Ev { get; set; }
        public  string Nev { get; set; }
        public string SzHStr { get; set; }

        public (int Szuletes, int? Halal) SzH { get; set; }
        public string Orszag { get; set; }


        
        public Dijazott(string a)
        {
            var v = a.Split(";");

            Ev = int.Parse(v[0]);
            Nev = v[1];
            SzHStr = v[2];
            var szhv = v[2].Split('-');
            int? h = szhv[1].Length == 0 ? null : int.Parse(szhv[1]);
            SzH = (int.Parse(szhv[0]), h);

            Orszag = v[3];
        }
    }
}
