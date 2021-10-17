using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plotas_Perimetras
{
    class Apskritascs
    {
        public double R;
        public double GautiPlota()
        {
            double plotas = Math.PI * R*R;
            return plotas;
        }
        public double GautiIlgi()
        {
            double ilgis = 2*Math.PI*R;
            return ilgis;
        }
        public Apskritascs (double r)
        {
            R = r;
        }
    }
}
