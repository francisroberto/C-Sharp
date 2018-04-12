using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * IFN501 Assessment 2 – Part 1
Individual
Weighting: 15%    Total Marks: 30
Due Date: 9 pm Friday 20th April 2018 (Week 7) 
Submission: Online via Blackboard
Problem Specification: 

 * Write a C# program using only one class containing the Main() method and a number of other methods within that class to calculate the interest paid for a loan from a bank at a fixed interest rate (> 1) for a fixed number of years.
As part of your solution:
•	Write one method to display appropriate instructions to the user.
•	Write only one method to be called two times separately to get the appropriate values from the user for the amount borrowed for two separate loans.
•	Write only one method to be called two times separately to get the appropriate values from the user for the interest rates for two separate loans.
•	Write only one method to be called two times separately to get the appropriate values from the user for the time of the loan in years for two separate loans.
•	Write only one method to be called two times separately to calculate the interests paid for the two loans.
•	Write one method to display the results using appropriate messages , including
o	The loan number, the amount borrowed, interest rate and number of years of the loan 
o	The corresponding interest for each loan,

    Note 1:
When calling each of the methods, pass the arguments as variables only.
Note 2:
1.	The output must be displayed in a readable format. 
2.	Test your code using your own test data covering multiple data sets.

*/

namespace CalculateLoanInterest
{
    class Program
    {
        //public static int loan = 1;
        public static void Main()
        {
            int loan = 1;
            Console.WriteLine("This Program will calculate the interest paid for your loan.");
            DisplayInstructions(ref loan);
            DisplayInstructions(ref loan);
            Console.ReadKey();

        }

        //display appropriate instructions to the user
        public static void DisplayInstructions(ref int loan)
        {
            //int loan = 1;
            double amountBorrowed;
            double interestRate;
            double lengthOfLoan;
            double interestPaid;
            Console.Write("Please Enter Borrowed Amount: ");
            amountBorrowed = GetAmountBorrowed();
            Console.Write("Please Enter Interest Rate In Decimal: ");
            interestRate = GetInterestRates();
            Console.Write("Please Enter Time Of Loan In Years: ");
            lengthOfLoan = GetLoanLength();
            interestPaid = CalculateInterestPaid(interestRate, lengthOfLoan, amountBorrowed);
            DisplayResults(ref loan, amountBorrowed, interestRate, lengthOfLoan, interestPaid);
            Console.ReadKey();

        }

        //get the appropriate values from the user for the amount borrowed
        public static double GetAmountBorrowed()
        {
            double amount = double.Parse(Console.ReadLine());
            return amount;
        }

        //get the appropriate values from the user for the interest rates
        public static double GetInterestRates()
        {
            double rate = double.Parse(Console.ReadLine());
            return rate;

        }

        //get the appropriate values from the user for the time of the loan in years
        public static double GetLoanLength()
        {
            double years = double.Parse(Console.ReadLine());
            return years;
        }

        //to calculate the interests paid for the two loans
        public static double CalculateInterestPaid(double rate, double years, double principal)
        {
            double interestPaid;
            interestPaid = (principal * rate * years) / 100;
            return interestPaid;

        }

        /*display the results using appropriate messages , including
        The loan number, the amount borrowed, interest rate and number
        of years of the loan &
        The corresponding interest for each loan*/


        public static void DisplayResults(ref int loan, double amountBorrowed, double interestRate, double lengthOfLoan, double interestPaid)
        {
            Console.WriteLine("Loan Number: {0}", loan);
            Console.WriteLine("Your Amount Borrowed is {0:$###,###,###,###.##}", amountBorrowed);
            Console.WriteLine("Your Interest Rate is {0:P}", interestRate);
            Console.WriteLine("Your Length Of Loan in years is {0}", lengthOfLoan);
            Console.WriteLine("Your Amount Of Interest Paid is {0:$###,###,###,###.##}", interestPaid);
            loan++;
        }
    }
}
