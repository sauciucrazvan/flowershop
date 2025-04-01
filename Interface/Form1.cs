using Flowershop;
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

            InitializeComponent();

            flowershop_name.Text = shop.name;
            flowershop_details.Text = shop.toString();
            data.Text = "";
        }

        private void btnShowEmployees_Click(object sender, System.EventArgs e)
        {
            groupBox2.Show();
            
            data.Text = shop.showEmployees();
        }

        private void btnShowStock_Click(object sender, System.EventArgs e)
        {
            groupBox2.Show();

            data.Text = shop.showStock();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            groupBox2.Hide();
        }
    }
}
