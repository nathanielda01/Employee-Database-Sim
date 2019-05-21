using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Database_Sim
{
    /// <summary>
    /// Contract class that inherits from the abstract
    /// Employee class. Represents a contracted worker 
    /// hired by the company
    /// </summary>
    public class Contract : Employee
    {
        private double contractWage;

        /// <summary>
        /// Empty Contract Constructor
        /// </summary>
        public Contract()
        {
            EmpType = "Contract";
        }

        /// <summary>
        /// Contract Constructor
        /// </summary>
        /// <param name="contractWage">
        /// Contracted employee's wage
        /// set by the company.
        /// </param>
        public Contract(double contractWage)
        {
            this.contractWage = contractWage;
        }

        // Getters & Setters
        /// <summary>
        /// Gets or sets the contractWage variable to be used
        /// </summary>
        public double ContractWage { get => contractWage; set => contractWage = value; }

        /// <summary>
        /// ToString override method creates a string object
        /// containg info about the contract employee
        /// </summary>
        /// <returns>
        /// string that is a summation of the information
        /// for the contracted employee.
        /// </returns>
        public override string ToString()
        {
            return base.ToString() +
                string.Format("{0:c}", contractWage);
        }
    }
}
