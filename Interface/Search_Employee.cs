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
    public partial class Search_Employee : Form
    {
        Flowershop.Flowershop _shop;
        public Search_Employee(Flowershop.Flowershop shop)
        {
            _shop = shop;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Searching for: " + textBox1.Text;

            var foundEmployee = _shop.employees.FirstOrDefault(emp =>
        emp.name.ToLower().Contains(textBox1.Text));

            if (foundEmployee != null)
            {
                label3.Text = $"Name: {foundEmployee.name}\nAddress: {foundEmployee.address}\nPhone: {foundEmployee.phone}\nEmail: {foundEmployee.email}";
            }
            else
            {
                MessageBox.Show("No employee found matching the search criteria.", "Search Result");
            }
        }
    }
}
