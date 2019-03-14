using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    class Program
    {

        static int fac(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * fac(n - 1);
        }
        static void Main(string[] args)
        {
            char play, hint;
            int age, num, secret = 0000;
            Console.WriteLine("Do you want to play Secret Number Guessing Game? (Y/N)");
            play = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Want any hint ? (Y/N)");
            hint = Convert.ToChar(Console.ReadLine());
            if ((hint == 'Y') || (hint == 'y'))
            {
                Console.WriteLine("HINT= `Enter a four digit number`");


                Console.Write("Enter your age: ");
                age = Convert.ToInt32(Console.ReadLine());
                if (age >= 5)
                {
                    for (int i = 5; i >= 0; i--)
                    {
                        Console.Write("Enter your guess= ");
                        num = Convert.ToInt32(Console.ReadLine());
                        if (num < 0000)
                        {
                            Console.WriteLine("Elert program is stopped! Your guessed value has only 3 digits");
                            break;
                        }
                        if (num == secret)
                        {
                            Console.WriteLine("You have guessed it!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Uhh ohh! Wrong guess. You\'ve Lost chance no:{0} ,{0} left ", i);
                        }

                    }
                }
                else
                {
                    Console.WriteLine("You are too young!");
                }
            }
            else
            {
                Console.WriteLine("Next time maybe!");
            }


            //int a = 6, b = 5;
            //Console.WriteLine(a*=b);

            //for (int i = 2; i < 10; i++)
            //{
            //    Environment.Exit(2);
            //    int n1 = 4 * fac(i);
            //    int n2=3 * fac(i-1);
            //    double result = n1 /n2;
            //    Console.WriteLine(result-Math.Pow((i-1),2));

            //}
        }
    }
}
