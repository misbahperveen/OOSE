using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labno10
{
    class Program
    {
        static void Main(string[] args)
        {
            Method3(3);
            Method3();
        }
        static void Method3(int x)
        {
            Console.WriteLine("Method3(int x)");
        }
        static void Method3()
        {
            Console.WriteLine("Method3()");
        }
    
    }
}
