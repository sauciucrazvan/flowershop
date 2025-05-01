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
    public partial class Show_Employees : Form
    {
        public Show_Employees(Flowershop.Flowershop shop)
        {
            InitializeComponent();

            label1.Text = shop.showEmployees();
        }
    }
}
