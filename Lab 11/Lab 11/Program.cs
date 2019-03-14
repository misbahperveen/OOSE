using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 7, 5, 3, 4, 2 };
            int temp;
            for (int i = 1; i < input.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (input[j] < input[j - 1])
                    {
                        temp = input[j];
                        input[j] = input[j - 1];
                        input[j - 1] = temp;
                    }
                }
            }
            foreach (int v in input)
            {
                Console.Write(v+" | ");
            }

            /////////////////Task 1
           // int val = 4353543;
           // check(ref val);
           // Console.WriteLine(val);

          // string[] numEng = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
          //
          // int value = 92323;
          // Console.WriteLine(numEng[value%10]);
        }
        static void check(ref int val)
        {
            string result = "";
            int previousVal;
            while ( val >0)
            {
                previousVal = (val % 10);
                
                result += previousVal.ToString();
                val = val / 10;
            }
            val = Convert.ToInt32(result);
        }
    }
}
