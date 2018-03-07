using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class test
    {
        static void Main(string[] args)
        {
            
            string danni = "Pesho, Tosho, Atanas, i Az";
            int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> Gosho = new List<int>(numbers);
            Gosho.Insert(5, 200);
            int[] additional = { 100, 200, 300, 400 };
            Gosho.InsertRange(8, additional);
            Gosho.Sort();
           // Console.WriteLine(string.Join(" ", Gosho));
            Gosho.RemoveAt(8);
            Gosho.Remove(100);
            //  Console.WriteLine(string.Join(" ", Gosho));
            Console.WriteLine(Gosho.Count);
            bool dali = Gosho.Contains(10);
            Console.WriteLine(dali);
            bool baliga = Gosho.Contains(200);
            if (baliga == true)
            {
                Gosho.Insert(12, 150);
                    Gosho.Add(Gosho.ElementAt(8) + Gosho.ElementAt(2));

            }
            else
            {
                Gosho.Insert(12, 250);
            }
            Console.WriteLine(string.Join(",",Gosho));
        }
    }
}
