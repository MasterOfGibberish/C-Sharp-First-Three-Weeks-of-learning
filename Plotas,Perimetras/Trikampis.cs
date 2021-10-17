using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plotas_Perimetras
{
    class Trikampis
    {
        public int a, b, c, p;
        public Trikampis(int a, int b, int c, int p)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.p = p;
        }
        public int GautiPerimetra()
        {
            int Perimetras = a + b + c;
            return Perimetras;
        }
        public int GautiPusperimetri()
        {
            int pusperimetris = (a + b + c) / 2;
            return pusperimetris;
        }
        public double GautiTrikampioPlota()
        {
            double TrikampioPlotas = Math.Sqrt(p*(p - a)*(p - b)*(p - c));
            return TrikampioPlotas;
        }
    }
}
