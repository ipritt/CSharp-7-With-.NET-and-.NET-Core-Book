using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    sealed class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson(string fullname, int age, int empID, float currPay, string ssn, int numbOfSales)
            : base(fullname, age, empID, currPay, ssn, numbOfSales)
        {

        }
    }
}
