using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class searchAlgorthem
    {

        int[] arr = new int[6];

        public void input()
        {
            Console.WriteLine("enter numbers of array");
            for (int i = 0; i < 6; i++)
            {

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.ReadLine();

        }


        public void Bubble_sort()
        {
            for (int i = 0; i < 6; i++)
            {
                int temp = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("   " + arr[i] + "");
            }
        }







        public int linarsearch()
        {
            int value = 13;




            for (int i = 0; i < 6; i++)
            {

                if (arr[i] == value)
                {
                    Console.WriteLine("found");
                    return i;


                } 



            } 
            return -1;


        }
        public int  Binary_search()
        {
            int lowerbound = 0;
            int uperbound = 5;
            int value1 = 42;
            while (uperbound != lowerbound)
            {
                int mid = (lowerbound + uperbound) / 2;

                if (arr[mid] == value1)
                {
                    return mid;
                }
                if (arr[mid] > value1)
                {
                    uperbound = mid - 1;
                }

                else if (arr[mid] < value1)
                {
                    lowerbound = mid + 1;
                }                
            }
            if(uperbound==lowerbound && arr[uperbound]==value1)
            {
                return uperbound;
            }
            return -1;

        }


    }
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter");
            int ch1 = Console.Read();
            int ch2 = Console.Read();
            int ch3 = Console.Read();
            Console.WriteLine(ch1);
            Console.WriteLine(ch2);
            Console.WriteLine(ch3);
            Console.WriteLine(Convert.ToChar(ch1));
            Console.WriteLine(Convert.ToChar(ch2));
            Console.WriteLine(Convert.ToChar(ch3));

//            int n1 = 6;
//int n2 = 4;
//int n3 = n1%n2;
//Console.WriteLine("Remainder of " +n1 +" + " +n2+ " = " + n3);

//            int A = 60;
//            Console.WriteLine(~A);
//            int number1 = 5;
//            int number2 = 4;
//            int product = number1 * number2;
//            Console.WriteLine("{0} * {1} = {2}" , number1,number2,product);

//            int fname,lname;
//            int rollno;
//            Console.WriteLine("Enter your name [First name Last Name] and roll no.");
          //  fname = Console.Read();
            //lname = Console.Read();
           // rollno = Console.Read();
            //Console.WriteLine("First Name: {0}\nLast Name: {1}\nRoll No: {2}", (char)fname, (char)lname, rollno);
            
            
            //int n1 = 1;
            //int n2 = --n1;
            //int n3 = --n1;
            //int n4 = n1--;
            ////  int n5 = n1-- --;   // error
            ////  int n6 = n1 - --n1; // undefined behavior
            //Console.WriteLine("n1 " +n1);
            //Console.WriteLine("n2 " +n2);
            //Console.WriteLine("n3 " +n3);
            //Console.WriteLine("n4 " +n4);



            //Console.WriteLine("Please Enter Your Good Name");

            ////Variable for storing string value 
            ////Accepting and holding values in name variable
            //string name = Console.ReadLine();

            ////Displaying Output
            //Console.WriteLine("Welcome {0} {0} in your first csharp program", name, name);

            ////Holding console screen
            //Console.ReadLine();


            //int num = 0;
            //Console.WriteLine("num "+num);
            //Console.WriteLine("++num " + ++num);
            //Console.WriteLine("num " +num);
            //Console.WriteLine("num++ "+num++);
            //Console.WriteLine("num "+num);
            //Console.WriteLine("--num "+--num);
            //Console.WriteLine("num-- " + num--);
            //Console.WriteLine("num " + num);
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //int number2 = Convert.ToInt16(Console.ReadLine());
            //double number3 = Convert.ToInt64(Console.ReadLine());
            //double number4 = Convert.ToDouble(Console.ReadLine());
            //double number5 = Convert.ToUInt16(Console.ReadLine());
            //uint number6 = Convert.ToUInt32(Console.ReadLine());
            //uint number7 = Convert.ToUInt32(Console.ReadLine());
            //double number8 = Convert.ToInt64(Console.ReadLine());
            //double number9 = Convert.ToDouble(Console.ReadLine());
            //double number10 = Convert.ToUInt16(Console.ReadLine());



        }
    }
}








