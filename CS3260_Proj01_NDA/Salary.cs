using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Database_Sim
{
    /// <summary>
    /// Salary class defines an employee that is paid in salary.
    /// </summary>
    public class Salary : Employee
    {
        private double monthlySalary;

        /// <summary>
        /// Empty Salary Constructor
        /// </summary>
        public Salary()
        {
            EmpType = "Salary";
        }

        /// <summary>
        /// Salary Constructor
        /// </summary>
        /// <param name="monthlySalary">
        /// A double that represents the monthly
        /// income of a salary employee
        /// </param>
        public Salary(double monthlySalary)
        {
            this.monthlySalary = monthlySalary;
        }

        // Getters & Setters
        public double MonthlySalary { get => monthlySalary; set => monthlySalary = value; }

        // Lampdas
        /// <summary>
        /// Calculates the annual income of a salary employee
        /// </summary>
        /// <returns>A double that represents the annual salary of the employee</returns>
        public double AnnualSalary() => monthlySalary * 12;

        /// <summary>
        /// ToString override method
        /// </summary>
        /// <returns>Returns a string containing information about the employee</returns>
        public override string ToString()
        {
            return base.ToString() +
                string.Format("{0:c} per month", monthlySalary);
        }
    }
}
