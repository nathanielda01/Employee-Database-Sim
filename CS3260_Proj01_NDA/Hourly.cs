using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Database_Sim
{
    /// <summary>
    /// Hourly class defines an employee that is paid hourly.
    /// </summary>
    public class Hourly : Employee
    { 
        private double hourlyRate;
        private double hoursWorked;

        /// <summary>
        /// Empty Hourly Contructor
        /// </summary>
        public Hourly()
        {
            EmpType = "Hourly";
        }

        /// <summary>
        /// Hourly Constructor
        /// </summary>
        /// <param name="hourlyRate">How much the employee earns per hour</param>
        /// <param name="hoursWorked">How many hours the employee has worked</param>
        public Hourly(double hourlyRate, double hoursWorked)
        {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }

        // Getters & Setters
        public double HourlyRate { get => hourlyRate; set => hourlyRate = value; }
        public double HoursWorked { get => hoursWorked; set => hoursWorked = value; }

        // Lambdas
        /// <summary>
        /// Method to calculate the estimated annual income based
        /// off of a 2080 hour work year.
        /// </summary>
        /// <returns>A double that represents the employees estimated annual income</returns>
        public double EstimatedAnnual() => hourlyRate * 2080;

        /// <summary>
        /// ToString override method
        /// </summary>
        /// <returns>Returns a string containing information about the employee</returns>
        public override string ToString()
        {
            return base.ToString() +
                string.Format("{0:c}", hourlyRate);
        }
    }
}
