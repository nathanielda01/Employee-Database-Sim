using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Database_Sim
{
    public sealed class BusinessRules
    {
        // private variables
        private int salesIDs = (int)EType.SALES * 1000;
        private int contractIDs = (int)EType.CONTRACT * 1000;
        private int hourlyIDs = (int)EType.HOURLY * 1000;
        private int salaryIDs = (int)EType.SALARY * 1000;
        private List<Employee> empList = new List<Employee>();
        
        /// <summary>
        /// BusinessRules constructor
        /// </summary>
        public BusinessRules()
        {
            // Creates required 10 refs in the BusinessRules indexer
            CreateList();
        }

        /// <summary>
        /// BusinessRules Indexer
        /// </summary>
        /// <param name="i">
        /// The index for the list to direct which Employee
        /// object to return
        /// </param>
        /// <returns>The Employee object selected by the indexer</returns>
        public Employee this[int i]
        {
            get { return empList[i]; }
            set
            {
                empList.Add(value);
                // EmpIDRefactor();
                SetEmployeeID(value); // The indexer will also assign Employee IDs when adding an emp to indexer
            }
        }

        /// <summary>
        /// Getters & Setters
        /// </summary>
        public int Length { get => empList.Count; }
        public int SalesIDs { get => salesIDs; }
        public int ContractIDs { get => contractIDs; }
        public int HourlyIDs { get => hourlyIDs; }
        public int SalaryIDs { get => salaryIDs; }

        /// <summary>
        /// Method to set an Employee object's EmpID variable
        /// </summary>
        /// <param name="emp">The Employee object that needs an empID</param>
        public void SetEmployeeID(Employee emp)
        {
            switch (emp.EmpType)
            {
                case "Sales":
                    emp.EmpID = salesIDs;
                    salesIDs++;
                    break;
                case "Contract":
                    emp.EmpID = contractIDs;
                    contractIDs++;
                    break;
                case "Hourly":
                    emp.EmpID = hourlyIDs;
                    hourlyIDs++;
                    break;
                case "Salary":
                    emp.EmpID = salaryIDs;
                    salaryIDs++;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Creates an specialized Employee object and stores it in the Indexer
        /// </summary>
        /// <param name="fn">first name</param>
        /// <param name="ln">last name</param>
        /// <param name="etype">employee type</param>
        public void CreateEmployee(string fn, string ln, string etype)
        {
            switch (etype)
            {
                case "Sales":
                    Sales newSalesEmployee = new Sales();
                    newSalesEmployee.FirstName = fn;
                    newSalesEmployee.LastName = ln;
                    this[this.Length] = newSalesEmployee;
                    break;
                case "Contract":
                    Contract newContractEmployee = new Contract();
                    newContractEmployee.FirstName = fn;
                    newContractEmployee.LastName = ln;
                    this[this.Length] = newContractEmployee;
                    break;
                case "Hourly":
                    Hourly newHourlyEmployee = new Hourly();
                    newHourlyEmployee.FirstName = fn;
                    newHourlyEmployee.LastName = ln;
                    this[this.Length] = newHourlyEmployee;
                    break;
                case "Salary":
                    Salary newSalaryEmployee = new Salary();
                    newSalaryEmployee.FirstName = fn;
                    newSalaryEmployee.LastName = ln;
                    this[this.Length] = newSalaryEmployee;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Method used to create 10 different Employee objects and store them into 
        /// the BusinessRules class
        /// </summary>
        public void CreateList()
        {
            Sales jim = new Sales(); jim.FirstName = "Jim"; jim.LastName = "Jax"; jim.MonthlySalary = 1250; jim.GrossSales = 40_000;
            Sales jack = new Sales(); jack.FirstName = "Jack"; jack.LastName = "Gabe"; jack.MonthlySalary = 1100; jack.GrossSales = 25_000;
            Contract art = new Contract(); art.FirstName = "Art"; art.LastName = "Bomber"; art.ContractWage = 46.75;
            Contract dave = new Contract(); dave.FirstName = "Dave"; dave.LastName = "Davidson"; dave.ContractWage = 25.45;
            Hourly jeff = new Hourly(); jeff.FirstName = "Jeff"; jeff.LastName = "Dillon"; jeff.HourlyRate = 13.50;
            Hourly carl = new Hourly(); carl.FirstName = "Carl"; carl.LastName = "Black"; carl.HourlyRate = 12.25;
            Salary gary = new Salary(); gary.FirstName = "Gary"; gary.LastName = "Boggs"; gary.MonthlySalary = 4500;
            Salary leah = new Salary(); leah.FirstName = "Leah"; leah.LastName = "Leatherman"; leah.MonthlySalary = 6000;
            Salary katie = new Salary(); katie.FirstName = "Katie"; katie.LastName = "Adams"; katie.MonthlySalary = 6500;
            Salary nate = new Salary(); nate.FirstName = "Nate"; nate.LastName = "Anderton"; nate.MonthlySalary = 5500;
            this[0] = jim; this[1] = jack; this[2] = art;
            this[3] = dave; this[4] = jeff; this[5] = carl;
            this[6] = gary; this[7] = leah; this[8] = katie;
            this[9] = nate;
        }

        /// <summary>
        /// Method that expands the EmpID range when needed
        /// </summary>
        public void EmpIDRefactor()
        {
            // Code to increase number of usable employee ID codes
        }
    }
}
