using System;
using System.Threading;
using System.Collections.Generic;

namespace ConsoleApp228
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;

            List<char> user_letters = new List<char>();

            bool endgamecheck = false;

            int plr_counts = 0, plr1_score = 0, plr2_score = 0, plr3_score = 0, cur_plr = 0;
            
            do
            {


                Console.Write("Players: ");


                if (!Int32.TryParse(Console.ReadLine(), out plr_counts))
                {
                    Console.WriteLine("Это не число");
                }
                else
                {
                    if (plr_counts < 1 || plr_counts > 3) Console.WriteLine("игроков должно быть от 1 до 3");
                    else break;
                }

            } while (true);

            do
            {
                Console.Write("Word: ");

                word = Console.ReadLine();

                Console.WriteLine($"Вы ввели слово \"{word}\"");
                Thread.Sleep(1500);
                Console.Clear();
                break;
            } while (true);




            //Console.Write("Input: ");
            //user_letters.Add(Console.ReadKey().KeyChar);
            if (plr_counts == 1) 
                cur_plr = 1;
            do
            {
                
                
                endgamecheck = false;
                for (int i = 0; i < word.Length; i++)
                {
                    
                    bool f = false;
                    for (int a = 0; a < user_letters.Count; a++)
                    {
                        if (user_letters[a] == word[i])
                        {
                            f = true;
                            break;
                        }
                    }

                    if (f) Console.Write(word[i]); else { endgamecheck = true; Console.Write("*"); }
                }
                Console.WriteLine("");
                Console.WriteLine("");
                

                 if (!endgamecheck) { Console.Clear(); break; }
                if (plr_counts != 1)
                {
                    if (plr_counts != 1)
                        cur_plr = (cur_plr == plr_counts) ? 0 : cur_plr;
                    cur_plr++;

                }
                string plr_name = "Player " + cur_plr;
                Console.Write($"[{plr_name}] Answer: ");

                string temp = Console.ReadLine();

                if (temp.Length == 1)
                {
                    user_letters.Add(temp[0]);
                }
                else
                {
                    if (temp == word)
                    {
                        break;
                    }
                }

                Console.Clear();
            } while (true);
            if(plr_counts == 1)
            Console.WriteLine("Победа!");
            else
            {
                Console.WriteLine($"Победил игрок {cur_plr}!");
            }
            Console.ReadKey();
        }
    }
}
