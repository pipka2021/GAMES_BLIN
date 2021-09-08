using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp228
{
    class Program
    {
        static void Main(string[] args)
        {
            int plr = 0;
            int pc = 0;
            int round = 0;
            string ogo = "";

            Random rnd = new Random();

            
            do
            {
                Console.Write("Name: ");
                Console.ReadLine();
                Console.Clear();
                do
                {
                    Console.WriteLine($"Round\t{++round}\nYou:\t{plr}\nPC :\t{pc}\n");
                    Console.WriteLine($"{ogo}\n");

                    Console.Write("Step: ");

                    //string answer = "камень";//Console.ReadLine();
                    string answer = Console.ReadLine();
                    int pc_ans = rnd.Next(1, 4);
                    Console.WriteLine(pc_ans);
                    if (answer.ToLower() == "камень")
                    {
                        if (pc_ans == 1)
                        {
                            ogo = "Ничья";
                        }
                        else if (pc_ans == 2)
                        {
                            ogo = "Победа";
                            plr++;
                        }
                        else if (pc_ans == 3)
                        {
                            ogo = "Проигрыш";
                            pc++;
                        }
                    }
                    else if (answer.ToLower() == "ножницы")
                    {
                        if (pc_ans == 1)
                        {
                            ogo = "Проигрыш";
                            pc++;
                        }
                        else if (pc_ans == 2)
                        {
                            ogo = "Ничья";
                        }
                        else if (pc_ans == 3)
                        {
                            ogo = "Победа";
                            plr++;
                        }
                    }
                    else if (answer.ToLower() == "бумага")
                    {
                        if (pc_ans == 1)
                        {
                            ogo = "Проигрыш";
                            pc++;
                        }
                        else if (pc_ans == 2)
                        {
                            ogo = "Победа";
                            plr++;
                        }
                        else if (pc_ans == 3)
                        {
                            ogo = "Ничья";
                        }
                    }
                    else
                    {
                        ogo = "неверный ход, используйте: камень, ножницы, бумага";
                        --round;
                    }
                    Console.Clear();
                    if (round == 20)
                    {
                        Console.WriteLine($"Результат\nYou: {plr}\nPC : {pc}\nНажмите любую клавишу для выхода.");
                        Console.ReadKey();
                        break;
                    }

                } while (true);

                break;
            } while (true);
        }
    }
}
