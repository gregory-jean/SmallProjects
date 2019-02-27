using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double CashGiven;
            int AmountRemaining;
            int HundredsReturned = 0;
            int FiftysReturned = 0;
            int TwentysReturned = 0;
            int TensReturned = 0;
            int FivesReturned = 0;
            int OnesReturned = 0;
            
            string CashGivenString = Console.ReadLine();
            
            // TODO define currency ammounts, implement into program
            Currency Dollar = new Currency()
            {
                Value = 100
            };
            Currency Quarter = new Currency()
            {
                Value = 25
            };

            // Convert string to double
            double.TryParse(CashGivenString, out CashGiven);


            // * 100 and convert to int for use in for loops
            CashGiven = CashGiven * 100;
            AmountRemaining = Convert.ToInt32(CashGiven);

            // TODO Create method for conversion to reduce code repitition.

            // Calculate how many 100 dollar bills are returned.
            for (int i = AmountRemaining; AmountRemaining >= 10000; i -= 10000)
            {
                HundredsReturned++;
                AmountRemaining = AmountRemaining - 10000;
            }
            Console.WriteLine("One hundred dollar bills returned : " + HundredsReturned);

            // Calculate how many 50 dollar bills are returned.
            for (int i = AmountRemaining; AmountRemaining >= 5000; i -= 5000)
            {
                FiftysReturned++;
                AmountRemaining = AmountRemaining - 5000;
            }
            Console.WriteLine("Fifty dollar bills returned : " + FiftysReturned);

            // Calculate how many 20 dollar bills are returned.
            for (int i = AmountRemaining; AmountRemaining >= 2000; i -= 2000)
            {
                TwentysReturned++;
                AmountRemaining = AmountRemaining - 2000;
            }
            Console.WriteLine("Twenty dollar bills returned : " + TwentysReturned);

            // Calculate how many 10 dollar bills are returned.
            for (int i = AmountRemaining; AmountRemaining >= 1000; i -= 1000)
            {
                TensReturned++;
                AmountRemaining = AmountRemaining - 1000;
            }
            Console.WriteLine("Ten dollar bills returned : " + TensReturned);

            // Calculate how many 5 dollar bills are returned.
            for (int i = AmountRemaining; AmountRemaining >= 500; i -= 500)
            {
                FivesReturned++;
                AmountRemaining = AmountRemaining - 500;
            }
            Console.WriteLine("Five dollar bills returned : " + FivesReturned);

            // Calcualte how many 1 dollar bills returned.
            for (int i = AmountRemaining; AmountRemaining >= 100; i-=100)
            {
                OnesReturned++;
                AmountRemaining = AmountRemaining - 100;
            }

            Console.WriteLine("One dollar bills returned : " + OnesReturned);

            Console.WriteLine("Change remaining : " + AmountRemaining);

            // TODO Calculate remianing change values.

            Console.ReadLine();


        }
    }
}
