using System;
namespace OOPAssignment
{
    class Reverse
    {
        static void Main(string[] args)
        {
            string str, RevString = "";
Console.WriteLine("Enter a sentence to reverse : ");
str = Console.ReadLine();
string[] newLine = str.Split(' ');
for (int x = newLine.Length - 1; x >= 0; x--)
{
    RevString = RevString + " " + newLine[x];
}
Console.WriteLine("Reverse sentence is : {0}", RevString);
Console.ReadKey();
        }
    }
}