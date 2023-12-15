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
* 10/1/23
* CSC 253
* David McCarthy
* This program uses inheirtance to make a team leader class from an production worker class and displays the objects values on the form (NEW UPDATE USES
* A CLASS LIBRARY INSTEAD OF HAVING MULTIPLE SEPERATE CLASSES)
*/
namespace WINUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            EmployeeClassLibrary.TeamLeader teamleader = new EmployeeClassLibrary.TeamLeader();
            GetTeamLeader(teamleader);
            displayEmployeeNameLabel.Text = "Employee Name: " + teamleader.EmployeeName;
            displayEmployeeNumberLabel.Text = "Employee Number: " + teamleader.EmployeeNumber.ToString();
            displayShiftNumber.Text = "Shift Number: " + teamleader.ShiftNumber.ToString();
            displayHourlyPayLabel.Text = "Hourly Pay: " + teamleader.HourlyPay.ToString();
            displayMonthlyBonusLabel.Text = "Monthly Pay: " + teamleader.MonthlyBonus.ToString();
            displayTrainingNeededLabel.Text = "Training Needed: " + teamleader.AmountTrainingNeeded.ToString();
            displayTrainingObtainedLabel.Text = "Current Amount of Training Hours: " + teamleader.AmountTrainingObtained.ToString();

        }
        private void GetTeamLeader(EmployeeClassLibrary.TeamLeader teamleader)
        {
            int employeeNumber;
            int shiftNumber;
            double hourlyPay;
            double monthlyBonus;
            double trainingObtained;
            double trainingRequired;
            teamleader.EmployeeName = employeeNameTextBox.Text;
            if (int.TryParse(employeeNumberTextBox.Text, out employeeNumber))
            {
                teamleader.EmployeeNumber = employeeNumber;

                if (int.TryParse(shiftNumberTextBox.Text, out shiftNumber))
                    {
                        teamleader.ShiftNumber = shiftNumber;
                        if (double.TryParse(hourlyPayTextBox.Text, out hourlyPay))
                        {
                            teamleader.HourlyPay = hourlyPay;
                            if (double.TryParse(monthlyBonusTextBox.Text, out monthlyBonus))
                            {
                                teamleader.MonthlyBonus = monthlyBonus;
                                if(double.TryParse(trainingNeededTextBox.Text, out trainingRequired))
                                {
                                    teamleader.AmountTrainingNeeded = trainingRequired;
                                    if(double.TryParse(trainingObtainedTextBox.Text, out trainingObtained))
                                    {
                                    teamleader.AmountTrainingObtained = trainingObtained;
                                    }
                                    else
                                    {
                                    MessageBox.Show("Invalid Amount of Training Obtained");
                                    }
                                }
                                else 
                                {
                                MessageBox.Show("Invalid Amount of Training");
                                }
                            }
                            else
                            {
                            MessageBox.Show("Invalid Monthly Pay");
                            }
                        }
                        else
                        {
                        MessageBox.Show("Invalid HourlyPay");                        
                        }
                    }
                else
                {
                    MessageBox.Show("Invalid Shift Number");
                }
            }
            else
            {
                MessageBox.Show("Invalid Employee Number");
            }
        }
    }
}

