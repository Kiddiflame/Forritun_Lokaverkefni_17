﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR_Lokaverkefni_2017
{
    public class Spilastokkar
    {
        /*Geymir grunnspilastokka, allir stokkar eru 30 spil, öll spil hafa stattanna sem fylgja þeim, hafa random function svo hægt sé að draga spil almennilega, hendir eru 5 spil samtals*/
        //Grunnur fyrir clasanna

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
        }
        public Spilastokkar(string ID, int[] stats)   
        {
            ID = id;
            Stat1 = stats[0];
            Stat2 = stats[1];
            Stat3 = stats[2];
            Stat4 = stats[3];
            Stat5 = stats[4];
            Stat6 = stats[5];
        }

        public override string ToString()
        {
            return base.ToString();
        }

        }

   


    }

