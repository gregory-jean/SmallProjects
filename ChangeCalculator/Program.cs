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
            int AmountRemaining =0;
            int HundredsReturned = 0;
            int FiftysReturned = 0;
            int TwentysReturned = 0;
            int TensReturned = 0;
            int FivesReturned = 0;
            int OnesReturned = 0;
            int ReturnedValue = 0;

            string CashGivenString = Console.ReadLine();



            int CalculateAmountReturned(int RemainingChange, int CurrentCurrencyCalculated, int CurrencyAmount)
            {
               
                for (int i = RemainingChange; RemainingChange >= CurrencyAmount; i -= CurrencyAmount)
                {
                    CurrentCurrencyCalculated++;
                    RemainingChange = RemainingChange - CurrencyAmount;
                }

                ReturnedValue = CurrentCurrencyCalculated;
                AmountRemaining = (AmountRemaining - (CurrentCurrencyCalculated * CurrencyAmount));
                return ReturnedValue;
            }

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

            // Calculate and print number of bills returned.
            HundredsReturned = CalculateAmountReturned(AmountRemaining, HundredsReturned, 10000);
            FiftysReturned = CalculateAmountReturned(AmountRemaining, FiftysReturned, 5000);
            TwentysReturned = CalculateAmountReturned(AmountRemaining, TwentysReturned, 2000);
            TensReturned = CalculateAmountReturned(AmountRemaining, TensReturned, 1000);
            FivesReturned = CalculateAmountReturned(AmountRemaining, FivesReturned, 500);
            OnesReturned = CalculateAmountReturned(AmountRemaining, OnesReturned, 100);

            Console.WriteLine();
            Console.WriteLine("100's given\t" + HundredsReturned);
            Console.WriteLine("50's given\t" + FiftysReturned);
            Console.WriteLine("20's given\t" + TwentysReturned);
            Console.WriteLine("10's given\t" + TensReturned);
            Console.WriteLine("5's given\t" + FivesReturned);
            Console.WriteLine("1's given\t" + OnesReturned + System.Environment.NewLine);
            
            Console.WriteLine("Amount Remaining: " + AmountRemaining + " cents." + System.Environment.NewLine);

            // TODO Calculate remianing change values.

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();

        }
    }
}
