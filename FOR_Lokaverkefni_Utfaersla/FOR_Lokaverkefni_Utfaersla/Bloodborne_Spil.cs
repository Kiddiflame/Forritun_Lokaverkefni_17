using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FOR_Lokaverkefni_2017_Klasasafn;

namespace FOR_Lokaverkefni_Utfaersla
{
    //Kristinn Logi Jakobsson
    //kiddiflame@gmail.com
    //20. april. 2017
    class Bloodborne_Spil
    {
        public Bloodborne[] hunter = new Bloodborne[52];
        public double[] AVG = new double[6];
        public Bloodborne_Spil()
        {
            Generate_Deck();
            double[] AVG1 = new double[52];
            double[] AVG2 = new double[52];
            double[] AVG3 = new double[52];
            double[] AVG4 = new double[52];
            double[] AVG5 = new double[52];
            double[] AVG6 = new double[52];
            for (int i = 0; i < 52; i++)
            {
                AVG1[i] = hunter[i].Stat1;
                AVG2[i] = hunter[i].Stat2;
                AVG3[i] = hunter[i].Stat3;
                AVG4[i] = hunter[i].Stat4;
                AVG5[i] = hunter[i].Stat5;
                AVG6[i] = hunter[i].Stat6;
            }

            AVG[0] = AVG1.Average();
            AVG[1] = AVG2.Average();
            AVG[2] = AVG3.Average();
            AVG[3] = AVG4.Average();
            AVG[4] = AVG5.Average();
            AVG[5] = AVG6.Average();

        }
        public void Generate_Deck()
        {

            hunter[0] = new Bloodborne("Dumplestiltskin", 100, 100, 100, 1, 1, 1 );
            hunter[1] = new Bloodborne("Papa Mozarella", 10, 15, 10, 70, 40, 70);
            hunter[2] = new Bloodborne("Grampa Dumple", 18, 14, 13, 60, 50, 60);
            hunter[3] = new Bloodborne("Dumpé", 20, 15, 10, 20, 40, 40);
            hunter[4] = new Bloodborne("Beardman", 19, 80, 10, 10, 12, 40);
            hunter[5] = new Bloodborne("Protonathan", 10, 20, 30, 45, 50, 60);
            hunter[6] = new Bloodborne("JoJo", 30, 20, 30, 50, 15, 20);
            hunter[7] = new Bloodborne("GioGio", 40, 21, 33, 42, 51, 23);
            hunter[8] = new Bloodborne("Wolo", 16, 25, 34, 43, 52, 61);
            hunter[9] = new Bloodborne("Hinterman", 30, 21, 31, 49, 31, 42);
            hunter[10] = new Bloodborne("Kaiserneko", 93, 42, 4, 79, 7, 71);
            hunter[11] = new Bloodborne("Takahata", 56, 18, 34, 17, 29, 88);
            hunter[12] = new Bloodborne("Lanipator", 21, 47, 73, 87, 67, 12);
            hunter[13] = new Bloodborne("Alifluro", 30, 19, 39, 48, 15, 18);
            hunter[14] = new Bloodborne("Anderson", 16, 37, 59, 41, 36, 28);
            hunter[15] = new Bloodborne("Big Ali", 65, 53, 8, 30, 33, 27);
            hunter[16] = new Bloodborne("Jack", 9, 55, 25, 58, 12, 10);
            hunter[17] = new Bloodborne("Mark", 29, 7, 27, 25, 65, 45);
            hunter[18] = new Bloodborne("Hoenheim", 86, 1, 35, 45, 64, 52);
            hunter[19] = new Bloodborne("Sebastian", 60, 64, 74, 4, 64, 76);
            hunter[20] = new Bloodborne("Nubian", 29, 74, 23, 2, 9, 11);
            hunter[21] = new Bloodborne("Scar", 65, 57, 47, 53, 52, 23);
            hunter[22] = new Bloodborne("Edward", 12, 1, 96, 42, 94, 68);
            hunter[23] = new Bloodborne("Dubley", 24, 56, 64, 50, 88, 4);
            hunter[24] = new Bloodborne("Elric", 51, 42, 22, 42, 31, 9);
            hunter[25] = new Bloodborne("Joseph", 60, 13, 63, 88, 28, 14);
            hunter[26] = new Bloodborne("Marianna", 75, 77, 40, 14, 31, 19);
            hunter[27] = new Bloodborne("Hiruluk", 10, 10, 10, 10, 10, 10);
            hunter[28] = new Bloodborne("Bege", 58, 87, 83, 63, 59, 74);
            hunter[29] = new Bloodborne("X Drake", 42, 5, 3, 33, 60, 60);
            hunter[30] = new Bloodborne("Mihawk", 50, 90, 90, 20, 30, 20);
            hunter[31] = new Bloodborne("Shanks", 32, 95, 95, 40, 25, 25);
            hunter[32] = new Bloodborne("Jinbe", 20, 44, 29, 48, 43, 29);
            hunter[33] = new Bloodborne("Kars", 49, 78, 8, 40, 27, 23);
            hunter[34] = new Bloodborne("Esidisi", 40, 70, 6, 35, 25, 18);
            hunter[35] = new Bloodborne("Whammu", 52, 80, 34, 25, 25, 15);
            hunter[36] = new Bloodborne("Goerge", 15, 25, 15, 25, 15, 25);
            hunter[37] = new Bloodborne("Arlong", 10, 20, 10, 40, 14, 14);
            hunter[38] = new Bloodborne("Kuma", 20, 25, 31, 32, 54, 48);
            hunter[39] = new Bloodborne("Hawkins", 90, 12, 43, 23, 29, 54);
            hunter[40] = new Bloodborne("Boa Marigold", 60, 14, 15, 23, 15, 50);
            hunter[41] = new Bloodborne("Crocodile", 20, 12, 43, 23, 29, 54);
            hunter[42] = new Bloodborne("Weevil", 24, 80, 80, 2, 2, 5);
            hunter[43] = new Bloodborne("Jones", 53, 49, 85, 3, 23, 12);
            hunter[44] = new Bloodborne("Capn' Kid", 87, 17, 33, 25, 55, 54);
            hunter[45] = new Bloodborne("Garp", 67, 12, 43, 23, 78, 54);
            hunter[46] = new Bloodborne("Blackbeard", 56, 12, 43, 23, 29, 54);
            hunter[47] = new Bloodborne("Rubert", 19, 12, 27, 23, 29, 54);
            hunter[48] = new Bloodborne("Lola", 34, 12, 43, 23, 29, 76);
            hunter[49] = new Bloodborne("Charlotte", 38, 12, 43, 23, 29, 54);
            hunter[50] = new Bloodborne("Ricky", 94, 1, 43, 23, 29, 54);
            hunter[51] = new Bloodborne("Neptune", 73, 12, 43, 19, 29, 54);
        }
      
    }
}
