using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR_Lokaverkefni_2017
{
    public class Bloodborne: Spilastokkar
    {
        /*Stodhestaspil erfir reglurnar frá spilastokkar en inniheldur sér spilin og statta*/
        
        public Bloodborne(int stat1, int stat2, int stat3, int stat4, int Bloodtinge, int Arcane)
        :base(stat1, stat2, stat3, stat4)
        {
            Vitality = stat1;
            Endurance = stat2;
            Strength = stat3;
            Skill = stat4;
        }

        public int Vitality{get; set;}
        public int Endurance { get; set; }
        public int Strength { get; set; }
        public int Skill { get; set; }
    }
}
