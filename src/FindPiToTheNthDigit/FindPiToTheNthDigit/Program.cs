namespace FindPiToTheNthDigit
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int piDigitLength = 0;
            do
            {
                Console.WriteLine("What digit would you like to find Pi to?");
                string PiDigitLengthString = Console.ReadLine();

                try
                {
                    piDigitLength = int.Parse(PiDigitLengthString);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input, enter a number using the numerical pad.");
                }
            }
            while (piDigitLength == 0);

            Console.WriteLine(GetPie(piDigitLength));
        }

        private static string GetPie(int piDigitLength)
        {
            string output;
            try
            {
                // TODO: find way to calc Pi
                output = $"{Math.PI}".Substring(0, piDigitLength + 1);
            }
            catch (Exception)
            {
                output = null;
            }

            return output;
        }
    }
}