using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNo9
{
    class Program
    {
        static void Main(string[] args)
        {

            string[][] members = new string[2][]{
		new string[]{"Celeste", "Mathurin", "Alex", "Germain"},
		new string[]{"Jeremy", "Mathew", "Anselme", "Frederique"} };


tring firstname;
tring lastname;


firstname = "Misbah Perveen";
lastname = "Misbah Perveen";

//Compare two string value and returns 0 for true and -1 for false
Console.WriteLine("==========COMPARE TO============");
Console.WriteLine(firstname.CompareTo(lastname));

//Check whether specified value exists or not in string
Console.WriteLine("==========CONTAINS============");
Console.WriteLine(firstname.Contains("veen"));

//Check whether specified value is the last character of string
Console.WriteLine("==========ENDS WITH============");
Console.WriteLine(firstname.EndsWith("n"));

//Compare two string and returns true and false
Console.WriteLine("==========EQUALS============");
System.Console.WriteLine(firstname.Equals(lastname));

//Returns type of string
Console.WriteLine("==========GET TYPE============");
Console.WriteLine(firstname.GetType());

//Returns code type of string
Console.WriteLine("==========GET TYPE CODE============");
Console.WriteLine(firstname.GetTypeCode());

//Returns the first index position of specified valuethe first index position of specified value
Console.WriteLine("==========INDEX OF============");
Console.WriteLine(firstname.IndexOf("e"));

//Covert string into lower case
Console.WriteLine("==========TO LOWER============");
Console.WriteLine(firstname.ToLower());

//Convert string into Upper case
Console.WriteLine("==========TO UPPER============");
Console.WriteLine(firstname.ToUpper());

//Insert substring into string
Console.WriteLine("==========INSERT============");
Console.WriteLine(firstname.Insert(0, "Hello"));

//Returns the last index position of specified value
Console.WriteLine("==========LAST INDEX OF============");
Console.WriteLine(firstname.LastIndexOf("e"));

//Returns the Length of String
Console.WriteLine("==========LENGTH============");
Console.WriteLine(firstname.Length);

//Deletes all the characters from begining to specified index.
Console.WriteLine("==========REMOVE============");
Console.WriteLine(firstname.Remove(5));

// Replace the character
Console.WriteLine("==========REPLACE============");
Console.WriteLine(firstname.Replace('e', 'i'));

Console.WriteLine("==========SPLIT WITH VALUE============");
string[] splitE = firstname.Split(new char[] { 'e' }); //Split the string based on specified value
for (int i = 0; i < splitE.Length; i++)
{
    Console.WriteLine(splitE[i]);
}

Console.WriteLine("==========SPLIT============");
string[] split = firstname.Split(); //Split the string based on specified value

for (int i = 0; i < split.Length; i++)
{
    Console.WriteLine(split[i]);
}


//Check wheter first character of string is same as specified value
Console.WriteLine("==========START WITH============");
Console.WriteLine(firstname.StartsWith("S"));

//Returns substring
Console.WriteLine("==========SUBSTRING============");
Console.WriteLine(firstname.Substring(2, 5));

//Converts an string into char array.
Console.WriteLine("==========TO CHAR ARRAY============");
Console.WriteLine(firstname.ToCharArray());

//It removes starting and ending white spaces from string.
Console.WriteLine("==========TRIM============");
Console.WriteLine(firstname.Trim());
           
            
        }
    }
}