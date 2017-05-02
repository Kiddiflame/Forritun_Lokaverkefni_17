using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FOR_Lokaverkefni_2017;

namespace For_Lokaverkefni_2017_utfaersla
{
    class Pokemon_Spil
    {
        public Pokemon[] pokemon = new Pokemon[52];

        public void Generate_Deck()
        {
            pokemon[0] = new Pokemon("Pidgeot", 83, 80, 75, 70, 70, 101);
            pokemon[1] = new Pokemon("Rattata", 30, 56, 35, 25, 35, 72);
            pokemon[2] = new Pokemon("Sandslash", 75, 100, 110, 45, 55, 65);
            pokemon[3] = new Pokemon("Nidoqueen", 90, 92, 87, 75, 85, 76);
            pokemon[4] = new Pokemon("Nidoking", 81, 102, 77, 85, 75, 85);
            pokemon[5] = new Pokemon("Ninetales", 73, 76, 75, 81, 100, 100);
            pokemon[6] = new Pokemon("Jigglypuff", 115, 45, 20, 45, 25, 20);
            pokemon[7] = new Pokemon("Dugtrio", 35, 100, 60, 50, 70, 110);
            pokemon[8] = new Pokemon("Arcanine", 90, 110, 80, 100, 80, 95);
            pokemon[9] = new Pokemon("Alakazam", 55, 50, 45, 135, 95, 120);
            pokemon[10] = new Pokemon("Machamp", 90, 130, 80, 65, 85, 55);
            pokemon[11] = new Pokemon("Bellsprout", 50, 75, 35, 70, 30, 40);
            pokemon[12] = new Pokemon("Slowpoke", 90, 65, 65, 40, 40, 15);
            pokemon[13] = new Pokemon("Magneton", 50, 60, 95, 120, 70, 70);
            pokemon[14] = new Pokemon("Mewtwo", 106, 110, 90, 154, 100, 130);
            pokemon[15] = new Pokemon("Lanturn", 125, 58, 58, 76, 76, 67);
            pokemon[16] = new Pokemon("Ampharos", 90, 75, 85, 115, 90, 55);
            pokemon[17] = new Pokemon("Bellossom", 75, 80, 95, 90, 100, 50);
            pokemon[18] = new Pokemon("Quagsire", 95, 85, 85, 65, 65, 35);
            pokemon[19] = new Pokemon("Forretress", 75, 90, 140, 60, 60, 40);
            pokemon[20] = new Pokemon("Steelix", 75, 85, 200, 55, 65, 30);
            pokemon[21] = new Pokemon("Scizor", 70, 130, 100, 55, 80, 65);
            pokemon[22] = new Pokemon("Shuckle", 20, 10, 230, 10, 230, 5);
            pokemon[23] = new Pokemon("Houndoom", 75, 90, 50, 110, 80, 95);
            pokemon[24] = new Pokemon("Lugia", 106, 90, 130, 90, 154, 110);
            pokemon[25] = new Pokemon("Mudkip", 50, 70, 50, 50, 50, 40);
            pokemon[26] = new Pokemon("Ludicolo", 80, 70, 70, 90, 100, 70);
            pokemon[27] = new Pokemon("Shiftry", 90, 100, 60, 90, 60, 80);
            pokemon[28] = new Pokemon("Gardevoir", 68, 65, 65, 125, 115, 80);
            pokemon[29] = new Pokemon("Slaking", 150, 160, 100, 95, 65, 100);
            pokemon[30] = new Pokemon("Aggron", 70, 140, 230, 60, 80, 50);
            pokemon[31] = new Pokemon("Manetric", 70, 75, 60, 105, 60, 105);
            pokemon[32] = new Pokemon("Altaria", 75, 70, 90, 70, 105, 80);
            pokemon[33] = new Pokemon("Milotic", 95, 60, 79, 100, 125, 81);
            pokemon[34] = new Pokemon("Absol", 65, 130, 60, 75, 60, 75);
            pokemon[35] = new Pokemon("Metagross", 80, 135, 130, 95, 90, 70);
            pokemon[36] = new Pokemon("Rayquaza", 105, 150, 90, 150, 90, 95);
            pokemon[37] = new Pokemon("Roserade", 60, 70, 65, 125, 105, 90);
            pokemon[38] = new Pokemon("Bronzong", 67, 89, 116, 79, 116, 33);
            pokemon[39] = new Pokemon("Spiritomb", 50, 92, 108, 92, 108, 35);
            pokemon[40] = new Pokemon("Mamoswine", 110, 130, 80, 70, 60, 80);
            pokemon[41] = new Pokemon("Arceus", 120, 120, 120, 120, 120, 120);
            pokemon[42] = new Pokemon("Excadrill", 110, 135, 60, 50, 65, 88);
            pokemon[43] = new Pokemon("Crustle", 70, 105, 125, 65, 75, 45);
            pokemon[44] = new Pokemon("Cofagrigus", 58, 50, 145, 95, 105, 30);
            pokemon[45] = new Pokemon("Kyurem", 125, 130, 90, 130, 90, 95);
            pokemon[46] = new Pokemon("Aegislash", 60, 50, 150, 50, 150, 60);
            pokemon[47] = new Pokemon("Yveltal", 126, 131, 95, 131, 98, 99);
            pokemon[48] = new Pokemon("Crabominable", 97, 132, 77, 62, 67, 43);
            pokemon[49] = new Pokemon("Golisopod", 75, 125, 140, 60, 90, 40);
            pokemon[50] = new Pokemon("Lunala", 137, 113, 89, 137, 107, 97);
            pokemon[51] = new Pokemon("Kartana", 59, 181, 131, 59, 31, 109);
        }
    }
}
