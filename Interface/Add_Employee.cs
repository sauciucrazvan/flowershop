using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flowershop;

namespace Interface
{
    public partial class Add_Employee : Form
    {
        Flowershop.Flowershop _shop;
        FileManagement _fileManagement;

        public Add_Employee(Flowershop.Flowershop shop, FileManagement fileManagement)
        {
            _shop = shop;
            _fileManagement = fileManagement;

            InitializeComponent();        
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            string name = textBox1.Text, address = textBox2.Text, phone = textBox3.Text, email = textBox4.Text, salaryStr = textBox5.Text;

            if (name == "" || address == "" || phone == "" || email == "" || salaryStr == "")
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            if (!Int32.TryParse(salaryStr, out int n))
            {
                MessageBox.Show("Salary must be a number!");
                return;
            }

            int salary = Convert.ToInt32(salaryStr);
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";

            MessageBox.Show("Employee added successfully!");

            _shop.AddEmployee(new Employee(name, address, phone, email, salary));
            _fileManagement.AddEmployee(new Employee(name, address, phone, email, salary));
        }
    }
}
