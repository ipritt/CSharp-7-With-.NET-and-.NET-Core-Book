using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        //  Instance-level data.
        public double currBalance;

        //  A static point of data.
        //public static double currInterestRate = 0.04;
        public static double currInterestRate;

        //public SavingsAccount(double balance) => currBalance = balance;

        //public SavingsAccount(double balance)
        //{
        //    currInterestRate = 0.04;    //  This is static data that gets reset evertime new object is created.
        //    currBalance = balance;
        //}

        public SavingsAccount(double balance) => currBalance = balance;

        //  A static constructor!
        //  For when value is not known until runtime.
        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.04;
        }

        //  Static members to get/set interest rate.
        public static void SetInterestRate(double newRate) => currInterestRate = newRate;
        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }
}
