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
    public partial class Updated_Selected_Flower : Form
    {
        private Flowershop.Flowershop shop;
        private FileManagement fileManagement;
        Flower flower;

        String selectedColor = "";

        public Updated_Selected_Flower(Flowershop.Flowershop _shop, FileManagement _fileManagement, Flower _flower)
        {
            this.shop = _shop;
            this.fileManagement = _fileManagement;
            this.flower = _flower;


            InitializeComponent();

            textBox10.Text = flower.type.ToString();
            textBox8.Text = Convert.ToInt32(flower.price).ToString();
            textBox7.Text = flower.quantity.ToString();
            selectedColor = flower.color;

            switch (selectedColor)
            {
                default:
                    radioButton1.Checked = true;
                    break;
                case "yellow":
                    radioButton2.Checked = true;
                    break;
                case "blue":
                    radioButton3.Checked = true;
                    break;
                case "pink":
                    radioButton6.Checked = true;
                    break;
                case "purple":
                    radioButton5.Checked = true;
                    break;
                case "green":
                    radioButton4.Checked = true;
                    break;
                case "black":
                    radioButton7.Checked = true;
                    break;
                case "orange":
                    radioButton8.Checked = true;
                    break;
                case "gray":
                    radioButton9.Checked = true;
                    break;
            }
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
            
            if(textBox10.Text == null || textBox8.Text == null || textBox7.Text == null || selectedColor == "")
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            if (!double.TryParse(textBox8.Text, out double res))
            {
                MessageBox.Show("Price must be a number!");
                return;
            }

            if (!Int32.TryParse(textBox7.Text, out int m))
            {
                MessageBox.Show("Quantity must be a number!");
                return;
            }

            // check if its a valid flowertype
            if (!Enum.TryParse(textBox10.Text, out FlowerTypes type))
            {
                MessageBox.Show("Invalid flower type!");
                return;
            }

            double price = Convert.ToDouble(textBox8.Text);
            if (price < 0)
            {
                MessageBox.Show("Price must be a positive number!");
                return;
            }

            int quantity = Convert.ToInt32(textBox7.Text);
            if (quantity < 0)
            {
                MessageBox.Show("Quantity must be a positive number!");
                return;
            }

            shop.RemoveFlower(flower); fileManagement.RemoveFlower(flower);
            shop.AddFlower(new Flower((FlowerTypes)type, selectedColor, price, quantity));
            fileManagement.AddFlower(new Flower((FlowerTypes)type, selectedColor, price, quantity));

            MessageBox.Show("Flower updated successfully!");
        }
    }
}
