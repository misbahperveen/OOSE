using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNo8
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] Nums = new int[5];
            //int count = 0, sum = 0;
            //while (count<5)
            //{
            //    Console.WriteLine("Enter number {0}",count+1);
            //    Nums[count] = Convert.ToInt32(Console.ReadLine());
            //    sum += Nums[count];
            //    count++;
            //}

            //Console.Clear();

            //for (int i = 0; i < Nums.Length; i++)
            //{
            //    Console.WriteLine("Value {0} is {1}",i+1,Nums[i]);
            //}

            //Console.WriteLine("Sum of {0} values is: {1}", count, sum);

            ///////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////

            int[,] Matrix = new int[3, 3];
            Console.WriteLine("Matrix.Length {0}", Matrix.Length);
            Console.WriteLine("Matrix.GetLength(0) {0}", Matrix.GetLength(0));
            Console.WriteLine("Matrix.GetLength(1) {0}", Matrix.GetLength(1));
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter value of Matrix[{0},{1}]: ",i,j);
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.Clear();
            Console.WriteLine("Input Matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t ", Matrix[i,j]);
                }
                Console.WriteLine();

            }


            /////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////




            int[] Marks={56,76,18,76,25,45};

            foreach (int Mark in Marks)
            {
                if (Mark < 50)
                    Console.WriteLine("{0} : Fail", Mark);
            }

        }
    }
}
