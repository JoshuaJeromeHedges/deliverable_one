using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacationType;
            var musical = "newOrleans";
            var tropical = "beach vacation in Mexico";
            var adventurous = "Whitewater Rafting the Grand Canyon";

            string output2 =
            musical = "New Orleans";
            tropical = "beach vacation in Mexico";
            adventurous = "Whitewater Rafting the Grand Canyon";


            string groupSize;
            string firstClass = Convert.ToString(1 | 2);
            string helicopter = Convert.ToString(3 | 5);
            string charterFlight = Convert.ToString(6);

            string output = 
            firstClass = "first class";
            helicopter = "helicopter";
            charterFlight = "charter flight";

            Console.Write("What type of trip would you like to take, musical, tropical, or adventurous?");
            vacationType = (Console.ReadLine());
            Console.Write("How many are in your group?");
            groupSize = (Console.ReadLine());

            Console.WriteLine("Since you’re a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + output + " to " + output2);

            Console.ReadKey();













        }
    }
}
