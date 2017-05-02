using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FOR_Lokaverkefni_2017;

namespace For_Lokaverkefni_2017_utfaersla
{
    class Program
    {
        static void Main(string[] args)
        {
            Bloodborne_Spil stokkur = new Bloodborne_Spil();
            stokkur.Generate_Deck();
            Pokemon_Spil stokkur2 = new Pokemon_Spil();
            stokkur2.Generate_Deck();

           

              

        }
    }
}
