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

            if (shop == null)
            {
                MessageBox.Show("Failed to load the flowershop. Please check the file or data.");
                return;
            }


            InitializeComponent();

            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();

            flowershop_name.Text = shop.name;
            flowershop_details.Text = shop.toString();
            data.Text = "";

            label8.Text = Flower.showFlowerTypes();
        }

        private void btnShowEmployees_Click(object sender, System.EventArgs e)
        {
            //groupBox2.Show();
            //groupBox3.Hide();
            //groupBox4.Hide();

            //data.Text = shop.showEmployees();
            Show_Employees showEmployees = new Show_Employees(shop);
            showEmployees.Show();

        }

        private void btnShowStock_Click(object sender, System.EventArgs e)
        {
            //groupBox2.Show();
            //groupBox3.Hide();
            //groupBox4.Hide();

            //data.Text = shop.showStock();

            Show_Stock show_Stock = new Show_Stock(shop);
            show_Stock.Show();
        }

        private void btnAddEmployee_Click(object sender, System.EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Show();
            groupBox4.Hide();
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

        private void btnAddFlower_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Show();
            groupBox4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string typeStr = textBox10.Text, color = textBox9.Text, priceStr = textBox8.Text, quantityStr = textBox7.Text;

            if (typeStr == "" || color == "" || priceStr == "" || quantityStr == "")
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            if (!double.TryParse(priceStr, out double res))
            {
                MessageBox.Show("Price must be a number!");
                return;
            }

            if (!Int32.TryParse(quantityStr, out int m))
            {
                MessageBox.Show("Quantity must be a number!");
                return;
            }

            int type = Convert.ToInt32(typeStr);

            if (type < 1 || type > 13)
            {
                MessageBox.Show("Invalid flower type!");
                return;
            }

            double price = Convert.ToDouble(priceStr);

            if (price < 0)
            {
                MessageBox.Show("Price must be a positive number!");
                return;
            }

            int quantity = Convert.ToInt32(quantityStr);

            if (quantity < 0)
            {
                MessageBox.Show("Quantity must be a positive number!");
                return;
            }

            textBox10.Text = textBox9.Text = textBox8.Text = textBox7.Text = "";

            MessageBox.Show("Flower added successfully!");

            shop.AddFlower(new Flower((FlowerTypes)type, color, price, quantity));
            fileManagement.AddFlower(new Flower((FlowerTypes)type, color, price, quantity));
        }
    }
}
