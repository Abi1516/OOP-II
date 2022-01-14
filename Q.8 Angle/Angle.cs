using System;
namespace OOPAssignment
{
    class Angle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hours : ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter Minutes : ");
            int minutes = int.Parse(Console.ReadLine());
            
            double hourInDegrees = (hours * 30) + (minutes * 30.0 / 60);
            double minuteInDegrees = minutes * 6;
            double difference = Math.Abs(hourInDegrees - minuteInDegrees);
            if (difference > 180)
            {
                difference = 360 - difference;
            }
            Console.WriteLine($"Angle between {hours} hour and {minutes} minute is {difference} degrees");
            Console.ReadKey();
        }
    }
}