using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
* 9/24/23
* CSC 253
* David McCarthy
* This program uses inheritance to make a shift supervisor class based off of the employee class and displays the shift supervisors values 
*/
namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            ShiftSupervisor shiftsupervisor = new ShiftSupervisor();
            GetShiftSupervisor(shiftsupervisor);
            displayEmployeeNameLabel.Text = "Employee Name: " + shiftsupervisor.EmployeeName;
            displayEmployeeNumberLabel.Text = "Employee Number: " + shiftsupervisor.EmployeeNumber.ToString();
            displayAnnualSalaryLabel.Text = "Annual Salary: " + shiftsupervisor.AnnualSalary.ToString("c");
            displayAnnualProductionBonusLabel.Text = "Annual Production Bonus: " + shiftsupervisor.AnnualProductionBonus.ToString("c");

        }
        private void GetShiftSupervisor(ShiftSupervisor shiftSupervisor)
        {
            int employeeNumber;
            double annualSalary;
            double annualProductionBonus;
            shiftSupervisor.EmployeeName = employeeNameTextBox.Text;
            if (int.TryParse(employeeNumberTextBox.Text, out employeeNumber))
            {
                shiftSupervisor.EmployeeNumber = employeeNumber;

                if (double.TryParse(annualSalaryTextBox.Text, out annualSalary))
                {
                    shiftSupervisor.AnnualSalary = annualSalary;
                    if (double.TryParse(annualProductionBonusTextBox.Text, out annualProductionBonus))
                    {
                        shiftSupervisor.AnnualProductionBonus = annualProductionBonus;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Annual Production Bonus");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Annual Salary");
                }
            }
            else
            {
                MessageBox.Show("Invalid Employee Number");
            }
        }
    }
}
