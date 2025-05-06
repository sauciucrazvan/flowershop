using Flowershop;
using System;
using System.IO;
using System.Windows.Forms;

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

            flowershop_name.Text = shop.name;
            flowershop_details.Text = shop.toString();

        }

        private void btnShowEmployees_Click(object sender, System.EventArgs e)
        {
            Show_Employees showEmployees = new Show_Employees(shop);
            showEmployees.Show();

        }

        private void btnShowStock_Click(object sender, System.EventArgs e)
        {
            Show_Stock show_Stock = new Show_Stock(shop);
            show_Stock.Show();
        }

        private void btnAddEmployee_Click(object sender, System.EventArgs e)
        {
            Add_Employee addEmployee = new Add_Employee(shop, fileManagement);
            addEmployee.Show();
        }

        private void btnAddFlower_Click(object sender, EventArgs e)
        {
            Add_Flower addFlower = new Add_Flower(shop, fileManagement);
            addFlower.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search_Employee searchEmployee = new Search_Employee(shop);
            searchEmployee.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search_Flower searchFlower = new Search_Flower(shop);
            searchFlower.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update_Flower updateFlower = new Update_Flower(shop, fileManagement);
            updateFlower.Show();
        }
    }
}
