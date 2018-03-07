using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threat2
{
    class threats2
    {
        static void Main(string[] args)
        {
            
            var input = Console.ReadLine().Split(' ').ToList();
            string[] command = Console.ReadLine().Split().ToArray();
            string operation = command[0];
            int startIndex = int.Parse(command[1]);
            int endIndex = int.Parse(command[2]);
            while (command!= "3:1")
            {
                if (operation == "merge")
                {

                    var concatIndex = string.Join("", input.Skip(startIndex).Take(endIndex).ToArray());

                    input.Insert(startIndex, concatIndex);
                    input.RemoveRange(startIndex + 1, endIndex - startIndex);


                    foreach (var item in input)
                    {
                        Console.Write(item + " ");

                    }
                }
                if (operation=="divide")
                {
                    // сплитване на масив, стринг, кълцане и манипулации със съставните
                    // презаписване с речник
                    "djdjja eiei fn dajfie"

                    int startIndexDivide = int.Parse(command[1]);
                    int particionsCount = int.Parse(command[2]);

                    List<string> rusult = divideEquall(elements[startIndexDivide], particionsCount);
                    input.RemoveAt(startIndexDivide);
                    input.InsertRange(startIndexDivide, result);

                    //divideEqual(elements[startIndexDivide], partitionsCount);

                }
          

            }
            
        }
    }
}
//Ivo Johny Tony Bony Mony
//merge 0 3
//merge 3 4
//merge 0 3
//3:1