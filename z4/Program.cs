using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp228
{
    class Program
    {
        struct stat 
        {
           public string name;
           public int count;
        }
        static void Main(string[] args)
        {
            string path = @"somefile.txt";
            string data = "";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    data = sr.ReadToEnd();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            List<stat> statistic = new List<stat>();
            string[] meow = data.Split(' ');

            List<string> originalList = new List<string>();

            for (int i = 0; i < meow.Length; i++)
            {
                originalList.Add(meow[i]);
            }


            List<string> outputList = new List<string>();

            foreach (var g in originalList.GroupBy(x => x).Select(x => x.ToList()))
            {
                var index = 1;
                foreach (var item in g)
                {
                    outputList.Add(string.Format("{0}[{1}]", item, index++));
                }
            }

            int abobus = 0;

            for (int i = 0; i < outputList.Count; i++)
            {
                int a;
                Int32.TryParse(outputList[i][outputList[i].Length - 2].ToString(), out a);
                if (abobus < a)
                {
                    abobus = a;
                    
                }
            }
            int iter = 0;
            Console.WriteLine($"Слова, которые повторяются больше всего ({abobus} раз)");
            for (int i = 0; i < outputList.Count; i++)
            {
                int a;
                Int32.TryParse(outputList[i][outputList[i].Length - 2].ToString(), out a);
                if (a == abobus)
                {
                    outputList[i] = outputList[i].Substring(0, outputList[i].Length - 3);
                    Console.WriteLine($"{++iter}. \"{outputList[i]}\"");

                }
            }

            //bool found = false;

        }
    }
}
