using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNo7
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////Example 1

            char Reply;

            do
            {

                Console.WriteLine("Decision (y,n): ");
                Reply = Convert.ToChar(Console.ReadLine());

            } while ((Reply == 'y') || (Reply == 'Y'));
            //////////
            //////// Example 02

            //int i = 0, num = 0;
            //string primeNumbers = "";    //Empty String
            //for (i = 1; i <= 50; i++)
            //{
            //    int counter = 0;
            //    for (num = i; num >= 1; num--)
            //    {
            //        if (i % num == 0)
            //        {
            //            counter = counter + 1;
            //        }
            //    }
            //    if (counter == 2)
            //    {
            //        primeNumbers = primeNumbers + i + " ";      //Appended the Prime number to the String
            //    }
            //}
            //Console.WriteLine("Prime numbers from 1 to 100 are :");
            //Console.WriteLine(primeNumbers);


            ////////////////example 3

            int Counter1 = 0, Counter2 = 0, Counter3 = 0, Counter4 = 0, Counter5 = 0;
            ++Counter1;
            for (int i = 1; i <= 5; i++)
            {
                ++Counter2;
                for (int j = 1; j <= 5; j++)
                {
                    ++Counter3;
                }
                ++Counter4;
            }
            ++Counter5;
            Console.WriteLine("Counter1: " + Counter1);
            Console.WriteLine("Counter2: " + Counter2);
            Console.WriteLine("Counter3: " + Counter3);
            Console.WriteLine("Counter4: " + Counter4);
            Console.WriteLine("Counter5: " + Counter5);


            //////////////example 4

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            //Console.WriteLine("\n\n");
            //for (int i = 4; i >=0; i--)
            //{
            //    for (int j = i; j >= 0; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            //Console.WriteLine("\n\n");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (i==0||j==0||i==4||j==4)
            //        {
            //            Console.Write(" *");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
                    
            //    }
            //    Console.WriteLine("");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (i == 0 || j == 0 || i == 4 || j == 4)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write("");
            //        }

            //    }
            //    Console.WriteLine("");
            //}














        }
    }
}
