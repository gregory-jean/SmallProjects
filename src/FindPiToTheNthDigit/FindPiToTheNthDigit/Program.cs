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

                if (int.TryParse(PiDigitLengthString, out piDigitLength))
                {
                    string pie = GetPie(piDigitLength);
                    if (pie != null)
                    {
                        Console.WriteLine(pie);
                        break;
                    }
                }

                Console.WriteLine("Invalid Input, enter a number using the numerical pad.");
            }
            while (true);

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