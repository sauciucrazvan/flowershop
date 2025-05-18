using Flowershop;
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
    public partial class add_new_entries : Form
    {
        Flowershop.Flowershop shop;
        FileManagement fileManagement;
        String selectedColor = "";

        public add_new_entries(Flowershop.Flowershop shop, FileManagement fileManagement)
        {
            this.shop = shop;
            this.fileManagement = fileManagement;

            InitializeComponent();
        }

        private void CheckChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rbControl)
            {
                if (rbControl.Checked)
                {
                    selectedColor = rbControl.Text;
                }
                else
                {
                    if (selectedColor == rbControl.Text)
                    {
                        selectedColor = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid control triggered the event.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string typeStr = textBox10.Text, color = selectedColor, priceStr = textBox8.Text, quantityStr = textBox7.Text;

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

            if (!Enum.TryParse(typeStr, out FlowerTypes type))
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

            textBox10.Text = textBox8.Text = textBox7.Text = "";

            MessageBox.Show("Flower added successfully!");

            shop.AddFlower(new Flower((FlowerTypes)type, color, price, quantity));
            fileManagement.AddFlower(new Flower((FlowerTypes)type, color, price, quantity));
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

            shop.AddEmployee(new Employee(name, address, phone, email, salary));
            fileManagement.AddEmployee(new Employee(name, address, phone, email, salary));
            this.Close();
        }
    }
}
