using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        //  Field data.
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;

        //  Constructors.
        public Employee() { }
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay, "") { }
        public Employee(string name, int age, int id, float pay, string ssn)
        {
            //  Use properties to prevent duplicate validation code.
            //empName = name;
            //empID = id;
            //empAge = age;
            //currPay = pay;
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;

            //  Oops! This is no longer possible if the property is read only.
            //SocialSecurityNumber = ssn;
            //  Woudl have to use underlying empSSN member variable to set from constructor.
            //  Check incoming ssn paramter as required and then set the value.
            empSSN = ssn;
        }
    }
}
