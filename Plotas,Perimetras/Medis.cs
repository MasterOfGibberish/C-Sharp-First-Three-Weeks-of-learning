using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plotas_Perimetras
{
    class Medis
    {

        public int sakuSkaicius { get; private set; }
  
        public Medis()
        {
            sakuSkaicius = 0;
          
        }
        public void Augimas()
        {
            sakuSkaicius = sakuSkaicius + 1;

        }

    }
}