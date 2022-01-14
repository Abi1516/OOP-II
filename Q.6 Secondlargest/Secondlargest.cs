using System;
namespace OOPAssignment
{
    class Secondlargest
    {
static void Main(string[] args)
        {
            int n, i;
            int[] arr1 = new int[50];
 
 
            Console.Write("Input the array : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int max1 = int.MinValue;  
    int max2 = int.MinValue;  
    foreach (int item in arr1)  
    {  
        if (item > max1)  
        {  
            max2 = max1;  
            max1 = item;  
        }  
        else if (item >= max2 && item != max1)  
        {  
            max2 = item;  
        }  
    }  
    Console.WriteLine($"The second largest integer is {max2}");
        
        Console.ReadKey();
        }
}
}