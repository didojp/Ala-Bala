using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class CountRealNums
    {
        static void Main(string[] args)
        {
            List<double>
                       
            nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            
            int length = nums.Count;   
          
            var count = 0;

            for (int i = 0; i < length; i++)
            {
                if (nums[i]== nums[i++])
                {
                    count++;
                }
                Console.WriteLine($"{i} + {count}");
            }



            //for (int i = 0; i < length; i++)
            //{
            //    string n = Console.ReadLine();
            //    nums.Add(n);
            //}

            // List<double> numbers = nums.Select(x => double.Parse(x)).ToList();
            //  var numbers1 = nums.Select(x => Convert.ToDouble(x)).ToList();
            // List<int> nums = new List<int>();
            //var nums = new List<string>(n);


        }
    }
}
