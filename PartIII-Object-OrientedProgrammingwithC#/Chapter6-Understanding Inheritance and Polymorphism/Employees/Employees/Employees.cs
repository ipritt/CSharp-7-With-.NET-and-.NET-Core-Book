using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    //  Employee.cs
    abstract partial class Employee
    {
        #region old commented code
        //  Accessor (get method).
        //public string GetName()
        //{
        //    return empName;
        //}

        //  Mutator(set method).
        //public void SetName(string name)
        //{
        //    //  Do a check on incoming value
        //    //  before making assignment.
        //    if (name.Length > 15)
        //        Console.WriteLine("Error! Name length exceeds 15 characters!");
        //    else
        //        empName = name;
        //}
        #endregion
        
        //  BenefitsPackage as nested class.
        public class BenefitPackage
        {
            //  BenefitsPackage nests BenefitPackageLevel.
            public enum BenefitPackageLevel
            {
                Standard, Gold, Platinum
            }
            //  Assume we have other members that represent dental/health benefits, and so om.
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }

        //  Contain a BenefitPackage object.
        protected BenefitPackage empBenefits = new BenefitPackage();

        //  Expose certain benefit behaviors of object.
        public double GetBenefitCost()
        { return empBenefits.ComputePayDeduction(); }

        //  Expose object through a custom propert.
        public BenefitPackage Benefits { get; set; }

        //  Properties!
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                else
                    empName = value;
            }
        }

        public int Age
        {
            #region old commented code
            //get { return empAge; }
            //set { empAge = value; }
            //  Written as Expression-bodied members.
            #endregion
            get => empAge;
            set => empAge = value;
        }

        public int ID
        {
            get => empID;
            set => empID = value;
        }

        public float Pay
        {
            get => currPay;
            set => currPay = value;
        }

        public string SocialSecurityNumber
        {
            get => empSSN;
        }

        //  Methods.
        //  Marked as virtual this methon can, but 
        //  doesn't have to be overridden by a derived class.
        public virtual void GiveBonus(float amount)
        {
            #region old commented code
            //currPay += amount;
            #endregion
            //  Use properties.
            Pay += amount;
        }

        public virtual void DisplayStats()
        {
            #region old commented code
            //Console.WriteLine("Name: {0}", empName);
            //Console.WriteLine("ID: {0}", empID);
            //Console.WriteLine("Age: {0}", empAge);
            //Console.WriteLine("Pay: {0}", currPay);
            #endregion
            //  User Properties
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", SocialSecurityNumber);
        }
    }
}
