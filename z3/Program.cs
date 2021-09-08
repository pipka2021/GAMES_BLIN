using System;
using System.Text;

namespace ConsoleApp228
{
    class Program
    {

        static void Password(int level)
        {
            string all_alph = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";

            //string alp_l2 = "1234567890";
            //string alp_l3 = "!@#$%^&*()";

            if (level == 2 )
            {
                all_alph += "1234567890";
            }
            if (level == 3)
            {
                all_alph += "1234567890";
                all_alph += "!@#$%^&*()";
            }

            Random rnd = new Random();
            string pass = "";
            for (int i = 0; i < 15; i++)
            {
                pass += all_alph[rnd.Next(0, all_alph.Length)];
            }
            Console.WriteLine(pass);
        }

        static void Main(string[] args)
        {
            //int ans = 0;
            Console.WriteLine("Выберите уровень зашиты (1,2,3)");
            do
            {
                Console.Write("Input: ");

                string ans = Console.ReadLine();

                if (ans == "1")
                {
                    Password(1);
                }
                else if (ans == "2")
                {
                    Password(2);
                }
                else if (ans == "3")
                {
                    Password(3);
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }

            } while (true);
        }
    }
}
