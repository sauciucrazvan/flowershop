using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class search_data : Form
    {
        private Flowershop.Flowershop shop;
        public search_data(Flowershop.Flowershop shop)
        {
            this.shop = shop;
            InitializeComponent();

            // remove the first column with that select thingy
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;

            dataGridView1.Columns.Add("EmployeeName", "Name");
            dataGridView1.Columns["EmployeeName"].Width = 140;
            dataGridView1.Columns.Add("EmployeeSalary", "Salary");
            dataGridView1.Columns.Add("EmployeePhone", "Phone");
            dataGridView1.Columns.Add("EmployeeAddress", "Address");
            dataGridView1.Columns.Add("EmployeeEmail", "Email");

            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Columns.Add("FlowerType", "Type");
            dataGridView2.Columns["FlowerType"].Width = 175;
            dataGridView2.Columns.Add("FlowerColor", "Color");
            dataGridView2.Columns.Add("FlowerPrice", "Price");
            dataGridView2.Columns.Add("FlowerQuantity", "Quantity");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Searching for: " + textBox1.Text;

            var foundEmployees = shop.employees
                .Where(emp => emp.name.ToLower().Contains(textBox1.Text.ToLower()))
                .ToList();

            if (foundEmployees.Any())
            {
                dataGridView1.Rows.Clear();
                foreach (var emp in foundEmployees)
                {
                    dataGridView1.Rows.Add(emp.name, emp.salary + " RON", emp.phone, emp.address, emp.email);
                }
                label3.Text = $"{foundEmployees.Count} employee(s) found.";
            }
            else
            {
                dataGridView1.Rows.Clear();
                label3.Text = string.Empty;
                MessageBox.Show("No employee found matching the search criteria.", "Search Result");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) && string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter at least one search criteria.", "Search Error");
                return;
            }

            label6.Text = "Searching for: " + (textBox2.Text ?? "") + (string.IsNullOrWhiteSpace(textBox3.Text) ? "" : "[color: " + textBox3.Text + "]");

            var foundFlowers = shop.stock
                .Where(flower =>
                    (string.IsNullOrWhiteSpace(textBox2.Text) || flower.type.ToString().ToLower().Contains(textBox2.Text.ToLower())) &&
                    (string.IsNullOrWhiteSpace(textBox3.Text) || flower.color.ToLower().Contains(textBox3.Text.ToLower())) &&
                    (!checkBox1.Checked || flower.quantity <= 10) &&
                    (!checkBox2.Checked || flower.price <= 20)
                )
                .ToList();

            dataGridView2.Rows.Clear();

            if (foundFlowers.Any())
            {
                foreach (var flower in foundFlowers)
                {
                    dataGridView2.Rows.Add(
                        flower.type.ToString(),
                        flower.color,
                        flower.price + " RON",
                        flower.quantity
                    );
                }
                label7.Text = $"{foundFlowers.Count} flower(s) found.";
            }
            else
            {
                label7.Text = string.Empty;
                MessageBox.Show("No flower found matching the search criteria.", "Search Result");
            }
        }
    }
}
