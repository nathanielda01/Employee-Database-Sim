
// Purpose: This program will create an Employee database for Archon 
// Industries. It takes user input, assigns an Employee ID # to the new
// employee, and writes the employee's information to a database.
// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Database_Sim
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    enum EType
    {
        EMPLOYEE,
        SALES,
        CONTRACT,
        HOURLY,
        SALARY
    }
}
