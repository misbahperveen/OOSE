using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNo5
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "DS";
            switch (a)
            {
                case "ab":
                   Console.WriteLine("abc"); 
                case "DS": Console.WriteLine("abc"); break;
            }
            
            Console.WriteLine(sizeof(decimal));
Console.WriteLine("Enter simple expression: ");
int Left;
int Right;
char Operator;
Left = Convert.ToInt32(Console.ReadLine());
Operator = Convert.ToChar(Console.ReadLine());
Right = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Left + " " + Operator + " " + Right);
switch (Operator)
{
    case '+': Console.WriteLine(Left + Right); break;
    case '-': Console.WriteLine(Left - Right); break;
    case '*': Console.WriteLine(Left * Right); break;
    case '/': Console.WriteLine(Left / Right); break;
    default: Console.WriteLine("Illegal operation"); break;
}

        }
    }
}
