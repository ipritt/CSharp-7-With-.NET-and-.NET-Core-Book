using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Data *****\n");
            //SavingsAccount s1 = new SavingsAccount(50);
            //SavingsAccount s2 = new SavingsAccount(100);
            //SavingsAccount s3 = new SavingsAccount(10000.75);

            //Console.WriteLine("Account balance for s1: {0}, interest rate {1}", s1.currBalance, SavingsAccount.currInterestRate);
            //Console.WriteLine("Account balance for s2: {0}, interest rate {1}", s2.currBalance, SavingsAccount.currInterestRate);
            //Console.WriteLine("Account balance for s3: {0}, interest rate {1}", s3.currBalance, SavingsAccount.currInterestRate);

            SavingsAccount s1 = new SavingsAccount(50);
            //  Print the current interest rate.
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            //  Try to change the interest rate.
            SavingsAccount.SetInterestRate(0.08);
            //  Make a second account.
            SavingsAccount s2 = new SavingsAccount(100);
            //  Should print 0.08...right?
            //  Using static constructor
            //  Print the current interest rate.
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            //  Make new object, this does NOT 'reset' the interest rate.
            SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
        }
    }
}
