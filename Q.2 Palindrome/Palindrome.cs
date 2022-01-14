using System;
namespace OOPAssignment
{
    public class Palindrome
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            string name = Console.ReadLine();
            string reverse = string.Empty;
            
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }
            
            if (name == reverse)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("not Palindrome");
            }
            Console.ReadKey();
        }
    }
}