using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = -30, value2 = 30, value3 = 10;
            double rstAbs = Math.Abs(value1);
            Console.WriteLine("Absolute value of " +value1+" is "+rstAbs);

            double rstCeiling = Math.Ceiling(24.2);
            Console.WriteLine("Ceiling value of 24.2 is "+rstCeiling);

            double rstFloor = Math.Floor(24.9);
            Console.WriteLine("Floor value of 24.9 is " + rstFloor);

            double rstCos = Math.Acos(value2);
            Console.WriteLine("Cos value of "+value2+"is " + rstCos);

            double rstSin = Math.Sin(value2);
            Console.WriteLine("Sin value of "+value2+"is " + rstSin);

            double rstTan = Math.Tan(value2);
            Console.WriteLine("Tan value of " + value2 + "is " + rstTan);

            double rstExp = Math.Exp(value2);
            Console.WriteLine("Exp value of " + value2 + "is " + rstExp);

            double rstLog = Math.Log(value2);
            Console.WriteLine("Log value of " + value2 + "is " + rstLog);

        }
    }
}
