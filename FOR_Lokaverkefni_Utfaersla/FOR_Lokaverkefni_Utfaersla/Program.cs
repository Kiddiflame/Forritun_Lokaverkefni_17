﻿using System;
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
    class Program
    {
        Random random = new Random();
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
                    ToppTrumpsPoke();
                    Console.WriteLine("Thank you for playing my game! press enter to exit");
                    Console.ReadKey();
                    break;

                case 2:
                    ToppTrumpsBlood();
                    Console.WriteLine("Thank you for playing my game! press enter to exit");
                    Console.ReadKey();
                    break;

                default:
                    break;
            }
        }

        public static void ToppTrumpsPoke()
        {
            Random random = new Random();
            List<Pokemon> Player_Deck = new List<Pokemon>();
            List<Pokemon> AI_Deck = new List<Pokemon>();
            List<Pokemon> cardPool = new List<Pokemon>();
            Pokemon_Spil stokkur1 = new Pokemon_Spil();

            stokkur1.Generate_Deck();
            for (int i = 0; i < 52; i++)
            {
                if (i % 2 == 0)
                {
                    Player_Deck.Add(stokkur1.pokemon[i]);

                }
                else if (true)
                {
                    AI_Deck.Add(stokkur1.pokemon[i]);

                }
            }
            Player_Deck = pokeshuffle(Player_Deck);
            AI_Deck = pokeshuffle(AI_Deck);
            

            Console.Clear();
            bool player_turn = true;
            int input = 0;
            double[] AVG_Stats = stokkur1.AVG;

            while (Player_Deck.Count > 0 && AI_Deck.Count > 0)
            {
                if (player_turn)//who picks?
                {

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Player: " + Player_Deck.Count + " vs AI: " + AI_Deck.Count);
                        Console.WriteLine("Player's hand: " + Player_Deck[0].ID);
                        Console.WriteLine("\n1. Hp");
                        Console.WriteLine("2. Attack");
                        Console.WriteLine("3. Defense");
                        Console.WriteLine("4. Special Attack");
                        Console.WriteLine("5. Special Defense");
                        Console.WriteLine("6. Speed");

                        Console.Write("Select the stat(the number): ");
                        input = Convert.ToInt16(Console.ReadLine())-1;
                    } while (input < 0 || input > 6);
                    player_turn = false;
                }
                else
                {
                    input = Poke_AI(AI_Deck[0], stokkur1.AVG);
                    player_turn = true;
                }
                Console.Clear();
                if (player_turn)
                {
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("AI picks HP");
                            break;

                        case 2:
                            Console.WriteLine("AI picks Attack");
                            break;

                        case 3:
                            Console.WriteLine("AI picks Defense");
                            break;

                        case 4:
                            Console.WriteLine("AI picks Special attack");
                            break;

                        case 5:
                            Console.WriteLine("AI picks Special defense");
                            break;

                        case 6:
                            Console.WriteLine("AI picks Speed");
                            break;

                    }

                }
                Console.WriteLine("Player: " + Player_Deck[0].Stats[input] + " vs AI: " + AI_Deck[0].Stats[input]);
                Console.WriteLine(Player_Deck[0]);
                Console.WriteLine("vs");
                Console.WriteLine(AI_Deck[0]);
                Console.ReadKey();
                if (Player_Deck[0].Stats[input] == AI_Deck[0].Stats[input])
                {
                    cardPool.Add(Player_Deck[0]);
                    cardPool.Add(AI_Deck[0]);
                    Player_Deck.Remove(Player_Deck[0]);
                    AI_Deck.Remove(AI_Deck[0]);
                }
                else if (Player_Deck[0].Stats[input] > AI_Deck[0].Stats[input])
                {
                    if (random.Next(0, 1) < 0.5)
                    {
                        Player_Deck.Add(Player_Deck[0]);
                        Player_Deck.Add(AI_Deck[0]);
                    }
                    else
                    {
                        Player_Deck.Add(AI_Deck[0]);
                        Player_Deck.Add(Player_Deck[0]);
                    }
                    AI_Deck.Remove(AI_Deck[0]);
                    Player_Deck.Remove(Player_Deck[0]);
                    cardPool = pokeshuffle(Player_Deck);
                    for (int i = 0; i < cardPool.Count();)
                    {
                        Player_Deck.Add(cardPool[0]);
                        cardPool.Remove(cardPool[0]);
                    }
                }
                else
                {
                    if (random.Next(0, 1) < 0.5)
                    {
                        AI_Deck.Add(AI_Deck[0]);
                        AI_Deck.Add(Player_Deck[0]);
                    }
                    else
                    {
                        AI_Deck.Add(Player_Deck[0]);
                        AI_Deck.Add(AI_Deck[0]);
                    }
                    Player_Deck.Remove(Player_Deck[0]);
                    AI_Deck.Remove(AI_Deck[0]);
                    cardPool = pokeshuffle(cardPool);
                    for (int i = 0; i < cardPool.Count();)
                    {
                        AI_Deck.Add(cardPool[0]);
                        cardPool.Remove(cardPool[0]);
                    }
                }
            }
            Console.ReadKey();


        }

        public static void ToppTrumpsBlood()
          {
          Random random = new Random();
            List<Bloodborne> Player_Deck2 = new List<Bloodborne>();
            List<Bloodborne> AI_Deck2 = new List<Bloodborne>();
            List<Bloodborne> cardPool = new List<Bloodborne>();
            Bloodborne_Spil stokkur2 = new Bloodborne_Spil(); 
            stokkur2.Generate_Deck();
            for (int i = 0; i < 52; i++)
            {
                if (i % 2 == 0)
                {
                    Player_Deck2.Add(stokkur2.hunter[i]);

                }
                else if (true)
                {
                    AI_Deck2.Add(stokkur2.hunter[i]);

                }
            }
            Player_Deck2 = shuffle(Player_Deck2);
            AI_Deck2 = shuffle(AI_Deck2);
            

            Console.Clear();
            bool player_turn = true;
            int input = 0;
            double[] AVG_Stats = stokkur2.AVG;

            while (Player_Deck2.Count > 0 && AI_Deck2.Count > 0)
            {
                if (player_turn)//who picks?
                {

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Player: " + Player_Deck2.Count + " vs AI: " + AI_Deck2.Count);
                        Console.WriteLine("Player's hand: " + Player_Deck2[0].ID);
                        Console.WriteLine("\n1. Vitality");
                        Console.WriteLine("2. Endurance");
                        Console.WriteLine("3. Strength");
                        Console.WriteLine("4. Skill");
                        Console.WriteLine("5. Bloodtinge");
                        Console.WriteLine("6. Arcane");

                        Console.Write("Select the stat(the number): ");
                        input = Convert.ToInt16(Console.ReadLine())-1;
                    } while (input < 0 || input > 6);
                    player_turn = false;
                }
                else
                {
                    input = Blood_AI(AI_Deck2[0], stokkur2.AVG);
                    player_turn = true;
                }
                Console.Clear();
                if (player_turn)
                {
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("AI picks Vitality");
                            break;

                        case 2:
                            Console.WriteLine("AI picks Endurance");
                            break;

                        case 3:
                            Console.WriteLine("AI picks Strength");
                            break;

                        case 4:
                            Console.WriteLine("AI picks Skill");
                            break;

                        case 5:
                            Console.WriteLine("AI picks Bloodtinge");
                            break;

                        case 6:
                            Console.WriteLine("AI picks Arcane");
                            break;

                    }

                }
                Console.WriteLine("Player: " + Player_Deck2[0].Stats[input] + " vs AI: " + AI_Deck2[0].Stats[input]);
                Console.WriteLine(Player_Deck2[0]);
                Console.WriteLine("vs");
                Console.WriteLine(AI_Deck2[0]);
                Console.ReadKey();
                if (Player_Deck2[0].Stats[input] == AI_Deck2[0].Stats[input])
                {
                    cardPool.Add(Player_Deck2[0]);
                    cardPool.Add(AI_Deck2[0]);
                    Player_Deck2.Remove(Player_Deck2[0]);
                    AI_Deck2.Remove(AI_Deck2[0]);
                }
                else if (Player_Deck2[0].Stats[input] > AI_Deck2[0].Stats[input])
                {
                    if (random.Next(0, 1) < 0.5)
                    {
                        Player_Deck2.Add(Player_Deck2[0]);
                        Player_Deck2.Add(AI_Deck2[0]);
                    }
                    else
                    {
                        Player_Deck2.Add(AI_Deck2[0]);
                        Player_Deck2.Add(Player_Deck2[0]);
                    }
                    AI_Deck2.Remove(AI_Deck2[0]);
                    Player_Deck2.Remove(Player_Deck2[0]);
                    cardPool = shuffle(Player_Deck2);
                    for (int i = 0; i < cardPool.Count();)
                    {
                        Player_Deck2.Add(cardPool[0]);
                        cardPool.Remove(cardPool[0]);
                    }
                }
                else
                {
                    if (random.Next(0, 1) < 0.5)
                    {
                        AI_Deck2.Add(AI_Deck2[0]);
                        AI_Deck2.Add(Player_Deck2[0]);
                    }
                    else
                    {
                        AI_Deck2.Add(Player_Deck2[0]);
                        AI_Deck2.Add(AI_Deck2[0]);
                    }
                    Player_Deck2.Remove(Player_Deck2[0]);
                    AI_Deck2.Remove(AI_Deck2[0]);
                    cardPool = shuffle(cardPool);
                    for (int i = 0; i < cardPool.Count();)
                    {
                        AI_Deck2.Add(cardPool[0]);
                        cardPool.Remove(cardPool[0]);
                    }
                }
            }
            Console.ReadKey();
          }


        public static int Poke_AI(Pokemon poke, double[] AVG)
        {
            double[] shift = new double[8];
            for (int i = 0; i < AVG.Length; i++)
            {
                shift[i] = poke.Stats[i] / AVG[i];
            }
            for (int i = 0; i < 8; i++)
            {
                if (shift[i] == shift.Max())
                {
                    return i;
                }
            }
            return 1;
        }

        public static int Blood_AI(Bloodborne poke, double[] AVG)
        {
            double[] shift = new double[8];
            for (int i = 0; i < AVG.Length; i++)
            {
                shift[i] = poke.Stats[i] / AVG[i];
            }
            for (int i = 0; i < 8; i++)
            {
                if (shift[i] == shift.Max())
                {
                    return i;
                }
            }
            return 1;
        }




        public static List<Pokemon> pokeshuffle(List<Pokemon> Holly)
        {
            List<Pokemon> oldone = Holly;
            List<Pokemon> newone = new List<Pokemon>();
            int init;
            Random rand = new Random();
            for (int i = 0; i < oldone.Count;)//rennur þangað til að stokkur klárast
            {
                init = rand.Next(0, oldone.Count);
                newone.Add(oldone[init]);
                oldone.Remove(oldone[init]);
            }
            return newone;
        }
        public static List<Bloodborne> shuffle(List<Bloodborne> Holly)
        {
            List<Bloodborne> oldone = Holly;
            List<Bloodborne> newone = new List<Bloodborne>();
            int init;
            Random rand = new Random();
            for (int i = 0; i < oldone.Count;)//rennur þangað til að stokkur klárast
            {
                init = rand.Next(0, oldone.Count);
                newone.Add(oldone[init]);
                oldone.Remove(oldone[init]);
            }
            return newone;

        }

      
    }

}
