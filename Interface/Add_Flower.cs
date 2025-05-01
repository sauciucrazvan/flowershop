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
    public partial class Add_Flower : Form
    {
        Flowershop.Flowershop _shop;
        FileManagement _fileManagement;

        String selectedColor;

        public Add_Flower(Flowershop.Flowershop shop, FileManagement fileManagement)
        {
            InitializeComponent();
            _shop = shop;
            _fileManagement = fileManagement;

            label8.Text = Flower.showFlowerTypes();

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

            textBox10.Text = textBox8.Text = textBox7.Text = "";

            MessageBox.Show("Flower added successfully!");

            _shop.AddFlower(new Flower((FlowerTypes)type, color, price, quantity));
            _fileManagement.AddFlower(new Flower((FlowerTypes)type, color, price, quantity));
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
    }
}
