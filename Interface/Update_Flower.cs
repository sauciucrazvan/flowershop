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
    public partial class Update_Flower : Form
    {
        private Flowershop.Flowershop shop;
        private FileManagement fileManagement;

        public Update_Flower(Flowershop.Flowershop _flowershop, FileManagement _fileManagement)
        {
            InitializeComponent();

            fileManagement = _fileManagement;
            shop = _flowershop;

            for (int i = 0; i < shop.stock.Count; i++)
            {
                RadioButton rb = new RadioButton();
                rb.Text = shop.stock[i].toString();
                rb.Name = "rb" + i;
                rb.Location = new Point(10, 50 + (i * 20));
                rb.AutoSize = true;
                this.Controls.Add(rb);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Updated_Selected_Flower updated_Selected_Flower = new Updated_Selected_Flower(shop, fileManagement, shop.stock[Convert.ToInt32(this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name.Substring(2))]);
            updated_Selected_Flower.Show();
        }
    }
}
