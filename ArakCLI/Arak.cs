using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArakCLI
{
    public class Arak
    {
        public Arak(int december, int januar, string kod, string megnevezes)
        {
            December = december;
            Januar = januar;
            Kod = kod;
            Megnevezes = megnevezes;
        }

        public Arak(string sor) 
        {
            string[] temp = sor.Split('\t');
            Kod = temp[0];
            Megnevezes = temp[1].Split(",")[0];
            Januar = int.Parse(temp[2]);
            December = int.Parse(temp[3]);
        }

        public int December { get;  set; }
        public int Januar { get;  set; }
        public string Kod { get;  set; }
        public string Megnevezes { get;  set; }

        public int Valtozas()
        {
            return December - Januar;
        }

    }
}
