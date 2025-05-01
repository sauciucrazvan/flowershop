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
    public partial class Search_Flower : Form
    {
        Flowershop.Flowershop _shop;
        public Search_Flower(Flowershop.Flowershop shop)
        {
            _shop = shop;
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == null && textBox2.Text == null)
            {
                MessageBox.Show("Please enter at least one search criteria.", "Search Error");
                return;
            }

            label1.Text = "Searching for: " + (textBox1.Text ?? textBox1.Text) + (textBox2.Text ?? " [color: " + textBox2.Text + "]");

            var foundFlower = _shop.stock.FirstOrDefault(flower =>
            flower.type.ToString().ToLower().Contains(textBox1.Text.ToLower()) &&
            flower.color.ToLower().Contains(textBox2.Text.ToLower()));

            if (foundFlower != null)
            {
                label3.Text = $"Type: {foundFlower.type}\nColor: {foundFlower.color}\nPrice: {foundFlower.price} RON\nQuantity: {foundFlower.quantity}";
            }
            else
            {
                MessageBox.Show("No flower found matching the search criteria.", "Search Result");
            }
        }
    }
}
