using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Database_Sim
{
    /// <summary>
    /// Class to create Sales employee objects
    /// Sealed class as it has not other class
    /// inheriting from it.
    /// </summary>
    public sealed class Sales : Salary
    {
        private double commission;
        private double grossSales;
        private const double COMMISSION_RATE = 0.08;

        /// <summary>
        /// Empty Sales Constructor
        /// </summary>
        public Sales()
        {
            EmpType = "Sales";
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="grossSales">
        /// The total amount in sales the Sales employee
        /// has earned
        /// </param>
        /// <param name="monthlySalary">
        /// Inheritted parameter from Salary class. This is
        /// the gross monthly income paid by the company
        /// </param>
        public Sales(double grossSales, double monthlySalary) : base(monthlySalary)
        {
            this.grossSales = grossSales;
        }

        /// <summary>
        /// Getters & Setters
        /// </summary>
        public double Commission { get => commission; }
        public double GrossSales { get => grossSales; set => grossSales = value; }

        // Lambda Methods
        /// <summary>
        /// CalcCommission sets the commission variable by multiplying
        /// the commission rate with the employee's gross Sales number.
        /// </summary>
        public void CalcCommission() => commission = grossSales * COMMISSION_RATE;
        /// <summary>
        /// GrossAnnualIncome calculates to employee's gross annual income
        /// by adding the employee's commission with the employee's annual
        /// salary which is inheritted from the Salary class
        /// </summary>
        /// <returns>The sum of the commission and annual income</returns>
        public double GrossAnnualIncome() => commission + AnnualSalary();

        /// <summary>
        /// An override method that prints out the employee's
        /// info as a string.
        /// </summary>
        /// <returns>
        /// String that contains basic information about the
        /// employee.
        /// </returns>
        public override string ToString()
        {
            return base.ToString() +
                string.Format(" {0:c}", grossSales);
        }
    }
}
