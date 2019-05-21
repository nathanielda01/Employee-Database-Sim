using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Database_Sim
{
    public partial class Form1 : Form
    {
        BusinessRules br = new BusinessRules();
        public Form1()
        {
            InitializeComponent();
            BusinessRules br = new BusinessRules();
            // Code to run at startup of application.
        }

        /*private void TxtLastName_TextChanged(object sender, EventArgs e)
        {

        }*/ // Don't need this now, but may in the future
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void CBoxEmployeeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * 
             * Code that will add another txtbox to form that will ask for
             * gross sales if Sales is selected.
             * 
             * Code that will also select an ID number for an employee based
             * on what kind of employee they are: Sales: 1000-1999, Contract:
             * 2000-2999, Hourly: 3000-3999, and Salary: 4000-4999
             * 
             */
            ComboBoxFormatter();
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            string _firstName = TxtFirstName.Text;
            string _lastName = TxtLastName.Text;
            string _employeeType = CBoxEmployeeSelector.SelectedItem.ToString().Remove(0, 4);
            /*
             * 
             * Code that will run inputs through correct channels.
             * Code to write employee to database after being clicked.
             * Code to also check that Employee info is inputted correctly.
             * 
             */
            br.CreateEmployee(_firstName, _lastName, _employeeType);
            ComboBoxFormatter();
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtEmpID_TextChanged(object sender, EventArgs e)
        {
            TxtEmpID.ForeColor = Color.Black;
        }

        /// <summary>
        /// Enables and disables txtboxes and btns according to the need of the Form
        /// </summary>
        /// <param name="bLock">bool to determine if things need to be enabled</param>
        private void NamesEnabler(bool bLock)
        {
            if (bLock)
            {
                TxtFirstName.Enabled = true;
                TxtLastName.Enabled = true;

                TxtFirstName.BackColor = DefaultBackColor;
                TxtLastName.BackColor = DefaultBackColor;

                BtnAddEmployee.Enabled = true;
                BtnAddEmployee.ForeColor = DefaultForeColor;
                BtnAddEmployee.BackColor = DefaultBackColor;
            }
            else
            {
                TxtFirstName.Enabled = false;
                TxtLastName.Enabled = false;

                TxtFirstName.BackColor = Color.LightGray;
                TxtLastName.BackColor = Color.LightGray;

                BtnAddEmployee.Enabled = false;
                BtnAddEmployee.BackColor = Color.FromArgb(200, 200, 200);
                BtnAddEmployee.ForeColor = Color.FromArgb(50, 50, 50);
            }
        }

        /// <summary>
        /// formats combo box correctly after a new employee is created.
        /// </summary>
        private void ComboBoxFormatter()
        {
            switch (CBoxEmployeeSelector.SelectedIndex)
            {
                case (int)EType.EMPLOYEE:
                    TxtEmpID.Text = "0000";
                    NamesEnabler(false);
                    break;
                case (int)EType.SALES:
                    TxtEmpID.Text = br.SalesIDs.ToString();
                    NamesEnabler(true);
                    break;
                case (int)EType.CONTRACT:
                    TxtEmpID.Text = br.ContractIDs.ToString();
                    NamesEnabler(true);
                    break;
                case (int)EType.HOURLY:
                    TxtEmpID.Text = br.HourlyIDs.ToString();
                    NamesEnabler(true);
                    break;
                case (int)EType.SALARY:
                    TxtEmpID.Text = br.SalaryIDs.ToString();
                    NamesEnabler(true);
                    break;
                default:
                    break;
            }
        }
    }
}
