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

        public Spilastokkar(int stat1, int stat2, int stat3, int stat4)   
        {
            Stat1 = stat1;
            Stat2 = stat2;
            Stat3 = stat3;
            Stat4 = stat4;
        }

        }


    }

