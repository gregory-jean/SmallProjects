using System;
using System.Timers;

namespace IntervalTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is an interval timer.");
            Console.WriteLine("You will provide the interval length, cooldown length between sets, and the number of sets ran.");

            // Set the interval length
            Console.WriteLine("How long would you like interval length to be (in seconds)?");

            Duration intervalDuration = new Duration();
            
            // Validate the user input as an int
            string intAnswer = Console.ReadLine();
            int X;
            while(!Int32.TryParse(intAnswer, out X))
            {
                Console.WriteLine("Not a valid number, try again.");
                intAnswer = Console.ReadLine();
            }
            
            intervalDuration.Length = X;
            Console.WriteLine($"Interval duration is {intervalDuration.Length}");



            // Set the cooldown length
            Console.WriteLine("How long would you like cooldown length to be (in seconds)?");

            Duration coolDownDuration = new Duration();

            // Validate the user input as an int
            string cdAnswer = Console.ReadLine();
            while (!Int32.TryParse(cdAnswer, out X))
            {
                Console.WriteLine("Not a valid number, try again.");
                cdAnswer = Console.ReadLine();
            }

            coolDownDuration.Length = X;
            Console.WriteLine($"Cooldown duration is {coolDownDuration.Length}");



            // Set the number of sets
            Console.WriteLine("How many sets do you want?");

            Duration sets = new Duration();

            // Validate the user input as an int
            string setsAnswer = Console.ReadLine();
            while (!Int32.TryParse(setsAnswer, out X))
            {
                Console.WriteLine("Not a valid number, try again.");
                setsAnswer = Console.ReadLine();
            }

            sets.Length = X;
            Console.WriteLine($"Number of sets is {sets.Length}");

            // Display the data to user before starting.
            Console.WriteLine();
            Console.WriteLine($"Interval length: {intervalDuration.Length} seconds");
            Console.WriteLine($"Cooldown length: {coolDownDuration.Length} seconds");
            Console.WriteLine($"Number of sets: {sets.Length}");

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("The program will now run " + sets.Length + " sets of " + intervalDuration.Length + " second intervals.");
            Console.WriteLine();
            Console.WriteLine("You will be notified with a double Beep after each set.");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Press Enter to start.");
            Console.ReadLine();

            Console.WriteLine("Starting set 1");

            // Start timer
            Timer.Start(intervalDuration.Length, sets.Length, coolDownDuration.Length);


            // TODO: Investigate how to get console app to play sound clip from folder.
        }
    }
}
