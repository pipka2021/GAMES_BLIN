using System;
using System.Text;

namespace ConsoleApp228
{
    class Program
    {
        static string Int2Hex(int value)
        {
            if (value < 0) throw new ArgumentOutOfRangeException("value");
            if (value == 0) return "0";

            string result = ToHex((uint)value).ToString();
            return result;
        }

        static StringBuilder ToHex(uint value)
        {
            StringBuilder buffer;
            if (value <= 0)
            {
                buffer = new StringBuilder();
            }
            else
            {
                buffer = ToHex(value / 16).Append("0123456789ABCDEF"[(int)(value % 16)]);
            }
            return buffer;
        }
        static void Main(string[] args)
        {
            int a;
            do
            {

            
                Console.Write("Input: ");


                if (!Int32.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Это не число");
                }
                else
                {
                    break;
                }

            } while (true);


            Console.WriteLine(Int2Hex(a));

        }
    }
}
