using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static string series1_1(int val)
        {
            string series = "";
            if(val == 0)
            {
                return "";
            }
            else
            {
                series += (val * 2)+"\t";
                return series +""+series1_1(val-1);
            }
        }
        static string series1_2(int val, int initial)
        {
            string series = "";
            if (val < initial)
            {
                return "";
            }
            else
            {
                series += (initial * 2)+"\t";
                return series + "" + series1_2(val, initial+1);
            }
        }
        static int series2(int val)
        {
            int previousVal;
            if (val == 0)
            {
                return 0;
            }
            else
            {
                previousVal = 3* val;
                return previousVal + series2(val - 1);
            }
        }
        static int series3(int val)
        {
            int previousVal;
            if (val == 1)
            {
                return 1;
            }
            else
            {
                previousVal = (int)Math.Pow(2, val);
                return previousVal + series3(val - 1);
            }
        }
        static int series4(int val)
        {
            int previousVal;
            if(val <9)
            {
                return val;
            }
            else { 
                previousVal = (val % 10);
                val = val / 10;
                return previousVal + series4(val);
            }
        }
        static unsafe void Main(string[] args)
        {
            //int value1 = 20;
            //int value2 = 40;
            //int* p1 = &value1;
            //int* p2 = &value2;
            //Console.WriteLine();

            //char valu1 = '2';
            //char valu2 = '4';
            //char* p3 = &valu1;
            //char* p4 = &valu2;
            //Console.WriteLine((int)p3);
            Console.WriteLine(series1_1(5));
            Console.WriteLine(series1_2(5, 1));
            Console.WriteLine(series2(2));
            Console.WriteLine(series3(2));
            Console.WriteLine(series4(543));
        }
    }
}
