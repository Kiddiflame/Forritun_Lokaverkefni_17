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
    public class Spilastokkar
    {
        private int stat1;
        private int stat2;
        private int stat3;
        private int stat4;
        private int stat5;
        private int stat6;
        private int[] stats;
        private string id;

        public string ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }


        public int Stat1
        {
            get
            {
                return stat1;
            }

            set
            {
                stat1 = value;
            }
        }

        public int Stat2
        {
            get
            {
                return stat2;
            }

            set
            {
                stat2 = value;
            }
        }

        public int Stat3
        {
            get
            {
                return stat3;
            }

            set
            {
                stat3 = value;
            }
        }


        public int Stat4
        {
            get
            {
                return stat4;
            }

            set
            {
                stat4 = value;
            }
        }

        public int Stat5
        {
            get
            {
                return stat5;
            }
            set
            {
                stat5 = value;
            }
        }

        public int Stat6
        {
            get
            {
                return stat6;
            }
            set
            {
                stat6 = value;
            }
        }

        public int[] Stats
        {
            get
            {
                return stats;
            }
            set
            {
                stats = value;
            }
        }
        public Spilastokkar(string ID, int[] sluss)
        {
            ID = id;
            Stats = sluss;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
