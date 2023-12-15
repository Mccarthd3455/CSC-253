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
* 10/15/23
* CSC 253
* David McCarthy
* Allows user to search and display certain employees by typing in their name and also has a button to show all of the tables employees.
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
            this.tableAdapterManager.UpdateAll(this.personnelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.personnelDataSet.Employees);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.SearchName(this.personnelDataSet.Employees, searchTextBox.Text);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.personnelDataSet.Employees);
        }
    }
}
