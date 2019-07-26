using System;
using System.Collections.Generic;
using System.Text;

namespace IntervalTimer
{
    /// <summary>
    /// 
    /// This class is a timer that allows users to set the timer length, 
    /// number of times it runs, and cooldown time if desired.
    /// 
    /// <param name="length" type=int>Duration of the set</param>
    /// <param name="repeatTimes" type=int>Number of sets</param>
    /// <param name="cooldown" type=int>Duration of the cooldown timer if desired</param>
    /// 
    /// </summary>
    
    public class Timer
    {
        public static void Start(int length, int repeatTimes, int cooldown)
        {
            for (var i = 0; i < repeatTimes; i++)
            {
                System.Threading.Thread.Sleep(length * 1000);

                Console.Beep();
                Console.Beep();
                Console.WriteLine();
                Console.WriteLine((i + 1) + " of " + repeatTimes + " sets completed.");
                if (cooldown != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Starting cooldown.");
                    System.Threading.Thread.Sleep(cooldown * 1000);

                    if (i == repeatTimes)
                    {
                       Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Starting set " + (i + 2));
                    }
                    Console.Beep();
                }
            }
        }
    }
}
