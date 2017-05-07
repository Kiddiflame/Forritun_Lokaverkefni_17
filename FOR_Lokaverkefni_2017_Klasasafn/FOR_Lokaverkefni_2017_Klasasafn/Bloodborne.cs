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
    public class Bloodborne: Spilastokkar
    {
        public Bloodborne(string id, int stat1, int stat2, int stat3, int stat4, int Bloodtinge, int Arcane)
          : base(id, new int[] { stat1, stat2, stat3, stat4, Bloodtinge, Arcane })
        {
            ID = id;

        }

        /*public int Vitality{get; set;}
        public int Endurance { get; set; }
        public int Strength { get; set; }
        public int Skill { get; set; }*/

        public override string ToString()
        {
            return "Name: " + ID + "\nVitality: " + Stats[0] + "\nStrength:" + Stats[1] + "\nEndurance: " + Stats[2] + "\nSkill: " + Stats[3] + "\nBloodtinge: " + Stats[4] + "\nArcane: " + Stats[5];
        }
    }
}
