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
* 11/27/2023
* CSC 253
* David McCarthy
* This program is a continuation of MW5HW3 and this variation allows the user to sort the table in ascending order by a min and a 
* max price also the datagrid view is now sorted by price in ascending order by default
**/
namespace WINUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductDataContext db = new ProductDataContext();
            var results = from product in db.Products
                          select product;
            productDataGridView.DataSource = results;
            productDataGridView.Sort(productDataGridView.Columns[3], ListSortDirection.Ascending);
        }

        private void searchProductNumberbutton_Click(object sender, EventArgs e)
        {
            ProductDataContext db = new ProductDataContext();
            string ProductNumber = productNumberTextBox.Text;
            var results = from product in db.Products
                          where product.Product_Number.Contains(ProductNumber)
                          select product;
            productDataGridView.DataSource = results;
        }

        private void searchDescriptionButton_Click(object sender, EventArgs e)
        {
            ProductDataContext db = new ProductDataContext();
            string Description = descriptionTextBox.Text;
            var results = from product in db.Products
                          where product.Description.Contains(Description)
                          select product;
            productDataGridView.DataSource = results;
        }

        private void resetTableButton_Click(object sender, EventArgs e)
        {
            ProductDataContext db = new ProductDataContext();
            var results = from product in db.Products
                          select product;
            productDataGridView.DataSource = results;
            productDataGridView.Sort(productDataGridView.Columns[3], ListSortDirection.Ascending);
        }

        private void sortByMinMax_Click(object sender, EventArgs e)
        {
            ProductDataContext db = new ProductDataContext();
            string maxPrice = maxPriceTextBox.Text;
            decimal max = decimal.Parse(maxPrice);
            string minPrice = minPriceTextBox.Text;
            decimal min = decimal.Parse(minPrice);
            var results = from product in db.Products
                          where product.Price <= max && product.Price >= min
                          select product;
            productDataGridView.DataSource = results;
            productDataGridView.Sort(productDataGridView.Columns[3], ListSortDirection.Ascending);
        }
    }
}
