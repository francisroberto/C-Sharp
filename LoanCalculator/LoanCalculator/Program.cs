using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    class Program
    {
        static void Main()
        {
            double amountBorrowed1;
            double interestRate1;
            int loanLength1;
            double interestPaid1;
            double amountBorrowed2;
            double interestRate2;
            double interestPaid2;
            int loanLength2;

            Console.WriteLine("This Program will calculate " +
                "the amount of interest you will pay for your loans.");

            // Loan 1
            Console.WriteLine("Loan Number: {0}", 1);
            DisplayInstructions("amount borrowed");
            amountBorrowed1 = GetAmountBorrowed();
            DisplayInstructions("interest rate");
            interestRate1 = GetInterestRate();
            DisplayInstructions("loan period");
            loanLength1 = GetLoanPeriod();
            interestPaid1 = CalculateInterest(amountBorrowed1, interestRate1,
                loanLength1);

            // Loan 2
            Console.WriteLine("Loan Number: {0}", 2);
            DisplayInstructions("amount borrowed");
            amountBorrowed2 = GetAmountBorrowed();
            DisplayInstructions("interest rate");
            interestRate2 = GetInterestRate();
            DisplayInstructions("loan period");
            loanLength2 = GetLoanPeriod();
            interestPaid2 = CalculateInterest(amountBorrowed2, interestRate2,
                loanLength2);

            DisplayResults(1, amountBorrowed1, interestRate1,
                loanLength1, interestPaid1, 2, amountBorrowed2,
                interestRate2, loanLength2, interestPaid2);

            Console.ReadKey();
        }

        public static void DisplayInstructions(string info)
        {            
           Console.Write("Enter {0} : ", info);
        }

        public static double GetAmountBorrowed()
        {
            double amount = double.Parse(Console.ReadLine());
            return amount;
        }

        public static double GetInterestRate()
        {
            double rate = (double.Parse(Console.ReadLine())) / 100;
            return rate;
        }

        public static int GetLoanPeriod()
        {
            int time = int.Parse(Console.ReadLine());
            return time;
        }

        public static double CalculateInterest(double amount, double rate,
            int time)
        {
            double interest = (amount * rate * time) / 100;
            return interest;
        }
        public static void DisplayResults(int loanNumber1, double amount1,
            double rate1, int time1, double interest1, 
            int loanNumber2, double amount2,
            double rate2, int time2, double interest2)
        {
            // Loan 1
            Console.WriteLine("For Loan Number {0}", loanNumber1);
            Console.WriteLine("Where the amount borrowed is {0:c} for {1} years " +
                "with interest rate of {2:p}, ", amount1, time1, rate1);
            Console.WriteLine("The interest you will be paying is {0:c}", interest1);

            // Loan 2
            Console.WriteLine("For Loan Number {0}", loanNumber2);
            Console.WriteLine("Where the amount borrowed is {0:c} for {1} years " +
                "with interest rate of {2:p}, ", amount2, time2, rate2);
            Console.WriteLine("The interest you will be paying is {0:c}", interest2); 
        }
    }
}


