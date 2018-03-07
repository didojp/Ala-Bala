using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threats
{
    class threats
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();

            while (!input.Equals("3:1"))
            {
                string[] commands = input.Split();   //делим входа на съставните елементи, които ще дават условието
                string command = commands[0];
                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);

                switch (command)
                {
                    case "merge":
                        var concatElem = string.Join("", elements.Skip(startIndex).Take(endIndex + 1).ToArray());

                        elements.RemoveRange(startIndex, endIndex + 1);
                        elements.Insert(startIndex, concatElem);

                        break;

                    case "divide":

                        int startIndexDivide = int.Parse(commands[0]);
                        int partitionsCount = int.Parse(commands[2]);

                        List<string> result = divideEqual(elements[startIndexDivide], partitionsCount);
                        elements.RemoveAt(startIndexDivide);
                        elements.InsertRange(startIndexDivide, result);
                        break;


                }
                input = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", elements));
        }

        static List<string> divideEqual(string word, int divide)
        {
                    List<string> result = new List<string>();
                    int partitionsCount = word.Length / divide;
                    while (word.Length >= partitionsCount)
                    {
                        string element = word.Substring(0, partitionsCount);
                        result.Add(element);
                        word = word.Substring(partitionsCount);

                    }

                    result.Add(word);

                    if (result.Count==divide)
                    {
                        return result;
                    }
                    else
                    {
                        string concatEl = "";
                        concatEl += result[result.Count - 2];
                        concatEl += result[result.Count - 1];

                        result.Remove(result[result.Count - 1]);
                        result.Remove(result[result.Count - 1]);

                        result.Add(concatEl);
                        return result;

                     }
                    

        }


            

        
    }
}
