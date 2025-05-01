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
    public partial class Show_Stock : Form
    {
        public Show_Stock(Flowershop.Flowershop shop)
        {
            InitializeComponent();

            label1.Text = shop.showStock();
        }
    }
}
