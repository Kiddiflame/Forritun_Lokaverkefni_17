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



            Console.WriteLine("Veldu stokk:");
            Console.WriteLine("\n1: Pokemon");
            Console.WriteLine("\n2: Bloodborne");
            Console.WriteLine("\n0: Hætta");

            int input_value = 0;

            input_value = Convert.ToInt32(Console.ReadLine());
            switch (input_value)
            {
                case 1:
                    
                    break;

                case 2:
                    Bloodborne_Spil stokkur2 = new Bloodborne_Spil();
                    stokkur2.Generate_Deck();
                    break;

                default:
                    break;
            }
        }

           public void ToppTrumpsPoke()
           {
              
                List<Pokemon> Player_Deck = new List<Pokemon>();
                List<Pokemon> AI_Deck = new List<Pokemon>();
                
                Pokemon_Spil stokkur1 = new Pokemon_Spil();
                stokkur1.Generate_Deck();
                for (int i = 0; i < 52 i++)
                {
                    if ()
	                {
		                
	                }
                }
             

           }

         /*public void ToppTrumpsBlood()
           {
                do
            {
                
                
            } while ();

           }*/

        }
    }

