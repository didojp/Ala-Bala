using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boza1
{
    class Program
    {
        static void Main(string[] args)
        {

            var names = new List<string>();
                        
                names.Add("pesho");
                names.Add("Gosho");
                names.Add("Sasho");
                names.Add("Pusho");
                names.Add("Koko");
                names.Add("Sasho");
                 names.Add("Az");
            int length = names.Count;
                      
                Console.WriteLine(string.Join(",",names));
             // names.RemoveAt(2);
             //   Console.WriteLine(string.Join(",", names));
            var otherNames = new List<string>();
                    otherNames.Add("Gina");
                    otherNames.Add("Gosho");
                    otherNames.Add("mimi");
                    otherNames.Add("Duda");
                    otherNames.Add("Masha");
                    otherNames.Add("Kasha");
                    otherNames.Add("Az");
            Console.WriteLine(string.Join(",", otherNames));
            bool equal = false;
            for (int i = 0; i < length; i++)
            {
                if (names[i]==otherNames[i])
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(equal);
                }
            }
            var sum = new List<string>();
            names.Add(otherNames);




        }
    }
}
