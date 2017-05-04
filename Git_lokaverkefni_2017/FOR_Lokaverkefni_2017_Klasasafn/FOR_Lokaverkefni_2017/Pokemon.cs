using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR_Lokaverkefni_2017
{
    public class Pokemon : Spilastokkar
    {
        /*Hrutaspil erfir reglurnar frá spilastokkar en inniheldur sér spilin og statta*/

        public Pokemon(string id, int stat1, int stat2, int stat3, int stat4, int s_defense, int speed)
        : base(id, new int[]{stat1, stat2, stat3, stat4, s_defense, speed})
        {
            HP = stat1;
            Attack = stat2;
            Defense = stat3;
            S_Attack = stat4;
        }

        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int S_Attack { get; set; }

        public override string ToString()
        {
            return "Name: "+ID+"\nHP: "+Stat1+"Attack:" +Stat2+"\nDefense: "+Stat3+"\nSpecial Attack: "+Stat4+"\nSpecial Defense: "+Stat5+"\nSpeed: "+Stat6;
        }
    }
}

