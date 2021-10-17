using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plotas_Perimetras
{
    class Kvadratas
    {
        public int a, b;
        public Kvadratas (int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int GautiKeturkampioPlota()
        {
            int Keturkampioplotas = a*b;
            return Keturkampioplotas;
        }
        public int GautiKeturkampioPerimetra()
        {
            int KeturkampiopPerimetra = (a + b)*2;
            return KeturkampiopPerimetra;
        }
    }
}
