using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR_Lokaverkefni_2017_Klasasafn
{
    //Kristinn Logi Jakobsson
    //kiddiflame@gmail.com
    //20. april. 2017
    public class Pokemon:Spilastokkar
    {
        public Pokemon(string id, int stat1, int stat2, int stat3, int stat4, int s_defense, int speed)
       : base(id, new int[] { stat1, stat2, stat3, stat4, s_defense, speed })
        {

            ID = id;
        }

        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int S_Attack { get; set; }

        public override string ToString()
        {
            return "Name: " + ID + "\nHP: " + Stats[0] + "\nAttack:" + Stats[1] + "\nDefense: " + Stats[2] + "\nSpecial Attack: " + Stats[3] + "\nSpecial Defense: " + Stats[4] + "\nSpeed: " + Stats[5];
        }
    }
}
