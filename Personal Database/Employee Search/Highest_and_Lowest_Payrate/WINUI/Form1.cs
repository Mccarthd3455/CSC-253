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
* 10/22/2023
* CSC 253
* David McCarthy
* This program will pop up a message box telling you either the max hourly pay or the min hourly pay depending on what button you 
* press
*/
namespace WINUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeesDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeesDataSet.Employees);

        }

        private void maxPayButton_Click(object sender, EventArgs e)
        {
            decimal maxPay;
            maxPay = (decimal)this.employeesTableAdapter.MaxPay();
            MessageBox.Show("Maximum Pay from all employees is: " + maxPay.ToString("C"));
        }

        private void minPayRateButton_Click(object sender, EventArgs e)
        {
            decimal minPay;
            minPay = (decimal)this.employeesTableAdapter.MinPay();
            MessageBox.Show("Minimum Pay from all employees is: " + minPay.ToString("C"));
        }
    }
}
