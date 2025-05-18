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
    public partial class update_flowers : Form
    {
        private Flowershop.Flowershop shop;
        private FileManagement fileManagement;
        private List<RadioButton> radioButtons = new List<RadioButton>();

        public update_flowers(Flowershop.Flowershop _flowershop, FileManagement _fileManagement)
        {
            InitializeComponent();

            fileManagement = _fileManagement;
            shop = _flowershop;

            CreateRadioButtons();
        }

        private void CreateRadioButtons()
        {
            // Remove existing radio buttons from form and list
            foreach (var rb in radioButtons)
            {
                this.Controls.Remove(rb);
            }
            radioButtons.Clear();

            for (int i = 0; i < shop.stock.Count; i++)
            {
                RadioButton rb = new RadioButton();
                rb.Text = shop.stock[i].toString();
                rb.Name = "rb" + i;
                rb.Location = new Point(15, 10 + (i * 20));
                rb.AutoSize = true;
                rb.Font = new Font("Arial", 11, FontStyle.Regular);
                this.Controls.Add(rb);
                radioButtons.Add(rb);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // If no radio button is selected, show a message box and return
            var selectedRadio = radioButtons.FirstOrDefault(r => r.Checked);
            if (selectedRadio == null)
            {
                MessageBox.Show("Please select a flower to update.");
                return;
            }

            int index = Convert.ToInt32(selectedRadio.Name.Substring(2));
            update_selected_flower updated_Selected_Flower = new update_selected_flower(shop, fileManagement, shop.stock[index]);
            updated_Selected_Flower.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateRadioButtons();
        }
    }
}
