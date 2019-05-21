using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Database_Sim
{
    /// <summary>
    /// Abstract Employee class
    /// </summary>
    public abstract class Employee
    {
        private int empID;
        private string empType;
        private string firstName;
        private string lastName;

        // Getters & Setters
        public int EmpID { get => empID; set => empID = value; }
        public string EmpType { get => empType; set => empType = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        /// <summary>
        /// Employee class constructor
        /// </summary>
        public Employee()
        {
            empID = 0;
            empType = "";
            firstName = "";
            lastName = "";
        }

        /// <summary>
        /// Employee class constructor
        /// </summary>
        /// <param name="empID">integer that is the employee ID #</param>
        /// <param name="empType">A string that designates whether the emp is full-time or part-time</param>
        /// <param name="firstName">A string that is the first name of the employee</param>
        /// <param name="lastName"></param>
        public Employee(int empID, string empType, string firstName, string lastName)
        {
            this.empID = empID;
            this.empType = empType;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        /// <summary>
        /// General override for ToString() method
        /// </summary>
        /// <returns>A string that contains basic info about Employee object</returns>
        public override string ToString()
        {
            return this.EmpID.ToString() + " " +
                this.LastName + ", " +
                this.FirstName + " " +
                this.EmpType + " ";
        }
    }
}
