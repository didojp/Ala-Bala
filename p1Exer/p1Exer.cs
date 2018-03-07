using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1Exer
{
    class p1Exer
    {
        static void Main(string[] args)
        {
            
            string commands;
            var phonebook = new Dictionary<string, string>();
            while ((commands = Console.ReadLine()) != "END")
            {
                string[] input = Console.ReadLine().Split();

                string command = input[0];
                string name = input[1];

                switch (command)
                {
                      string number = input[2];
                    case "A":


                  
                        if (phonebook.ContainsKey(name))
                        {
                            phonebook[name] = number; //писане в речника. key-value???
                        }
                        else
                        {
                            phonebook.Add(name, number);
                        }
                       

                        break;

                    case "S":
                        
                            if (phonebook.ContainsKey(name))
                            {
                             string foundNumber = phonebook[name];

                                Console.WriteLine($"{name} -> {foundNumber}");
                            }
                            else
                            {
                                Console.WriteLine($"Contact {name} does not exist.");
                            }
                        break;
                       
                
               
                }
            }
            
           
        }
    }
}
