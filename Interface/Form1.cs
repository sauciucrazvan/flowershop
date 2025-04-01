using Flowershop;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace Interface
{
    
    public partial class Form1 : Form
    {
        FileManagement fileManagement;
        Flowershop.Flowershop shop;

        public Form1()
        {
            string fileLoc = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            fileManagement = new FileManagement(fileLoc + "\\flowershop.txt");
            shop = fileManagement.LoadFlowershop();

            InitializeComponent();

            groupBox2.Hide();
            groupBox3.Hide();

            flowershop_name.Text = shop.name;
            flowershop_details.Text = shop.toString();
            data.Text = "";
        }

        private void btnShowEmployees_Click(object sender, System.EventArgs e)
        {
            groupBox2.Show();
            groupBox3.Hide();

            data.Text = shop.showEmployees();
        }

        private void btnShowStock_Click(object sender, System.EventArgs e)
        {
            groupBox2.Show();
            groupBox3.Hide();

            data.Text = shop.showStock();
        }

        private void btnAddEmployee_Click(object sender, System.EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Show();

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string name = textBox1.Text, address = textBox2.Text, phone = textBox3.Text, email = textBox4.Text, salaryStr = textBox5.Text;

            if (name == "" || address == "" || phone == "" || email == "" || salaryStr == "")
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            if(!Int32.TryParse(salaryStr, out int n))
            {
                MessageBox.Show("Salary must be a number!");
                return;
            }

            int salary = Convert.ToInt32(salaryStr);
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";

            MessageBox.Show("Employee added successfully!");

            shop.AddEmployee(new Employee(name, address, phone, email, salary));
            fileManagement.AddEmployee(new Employee(name, address, phone, email, salary));

        }
    }
}
