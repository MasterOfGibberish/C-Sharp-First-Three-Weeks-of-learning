using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plotas_Perimetras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apskritascs manoApskritimas = new Apskritascs(11);
            //double gautasPlotas = manoApskritimas.GautiPlota();
            //manoApskritimas.R = 20;
            //double gautasPlotas2 = manoApskritimas.GautiPlota();
            //Console.WriteLine($"{gautasPlotas2}");
            //Console.ReadLine();

            //Apskritascs manoApskritimas = new Apskritascs(11);
            //double gautasILGIS = manoApskritimas.GautiIlgi();
            //Console.WriteLine($"{gautasILGIS }");
            //Console.ReadLine();\
            ////////////////////////////////////////////////

            //Kvadratas manoStaciakampis = new Kvadratas(10,20);
            //int gautasplotas = manoStaciakampis.GautiKeturkampioPlota();
            //Console.WriteLine($"{gautasplotas}");
            //Console.ReadLine();

            //Kvadratas manoStaciakampis = new Kvadratas(10, 20);
            //int gautasperimetras = manoStaciakampis.GautiKeturkampioPerimetra();
            //Console.WriteLine($"{gautasperimetras}");
            //Console.ReadLine();
            ////////////////////////////////////////////
            ///
            //Trikampis manoTrikampis = new Trikampis(10, 20, 60, 50);
            //int gautasperimetras = manoTrikampis.GautiPerimetra();
            //Console.WriteLine($"{gautasperimetras}");
            //Console.ReadLine();

            //Trikampis manoTrikampis1 = new Trikampis(10, 20, 60, 50);
            //int gautaspurperimetris = manoTrikampis1.GautiPusperimetri();
            //Console.WriteLine($"{gautaspurperimetris}");
            //Console.ReadLine();

            //Trikampis manoTrikampis2 = new Trikampis(10, 20, 60, 10000);
            //double gautasplotas = manoTrikampis2.GautiTrikampioPlota();
            //Console.WriteLine($"{gautasplotas}");
            //Console.ReadLine();
            ////////////////////////////////
            //Medis

            Medis manoMedis = new Medis();
            bool auginti_medi = true;
            while (auginti_medi != false)
            {
                Console.WriteLine("Ar norite auginti medi?");
                string Ivestis = Console.ReadLine();
                auginti_medi = Ivestis == "taip";
                
                if (auginti_medi )
                {
                    manoMedis.Augimas();
                }

            }
            Console.WriteLine($"{manoMedis.sakuSkaicius}");
            Console.ReadLine();
        }
    }
}
