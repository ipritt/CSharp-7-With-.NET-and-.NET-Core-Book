using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    //  Employee.cs
    partial class Employee
    {
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
            //get { return empAge; }
            //set { empAge = value; }
            //  Written as Expression-bodied members.
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
        public void GiveBonus(float amount)
        {
            //currPay += amount;
            //  Use properties.
            Pay += amount;
        }

        public void DisplayStats()
        {
            //Console.WriteLine("Name: {0}", empName);
            //Console.WriteLine("ID: {0}", empID);
            //Console.WriteLine("Age: {0}", empAge);
            //Console.WriteLine("Pay: {0}", currPay);
            //  User Properties
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
        }
    }
}
