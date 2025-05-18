using System.Windows.Forms;

namespace Interface
{
    public partial class view_data : Form
    {
        private Flowershop.Flowershop shop;
        public view_data(Flowershop.Flowershop shop)
        {
            this.shop = shop;
            InitializeComponent();

            // remove the first column with that select thingy
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;


            dataGridView1.Columns.Add("FlowerType", "Type");
            dataGridView1.Columns["FlowerType"].Width = 200;
            dataGridView1.Columns.Add("FlowerPrice", "Price");
            dataGridView1.Columns.Add("FlowerColor", "Color");
            dataGridView1.Columns.Add("FlowerQuantity", "Quantity");

            //Add every flower to the data view grid list
            foreach (var flower in shop.stock)
            {
                dataGridView1.Rows.Add(
                    flower.type,
                    flower.price + " RON", 
                    flower.color,
                    flower.quantity);
            }

            
            dataGridView2.Columns.Add("EmployeeName", "Name");
            dataGridView2.Columns["EmployeeName"].Width = 140;
            dataGridView2.Columns.Add("EmployeeSalary", "Salary");
            dataGridView2.Columns.Add("EmployeePhone", "Phone");
            dataGridView2.Columns.Add("EmployeeAddress", "Address");
            dataGridView2.Columns.Add("EmployeeEmail", "Email");

            //Add every employee to the data view grid list
            foreach (var employee in shop.employees)
            {
                dataGridView2.Rows.Add(
                    employee.name,
                    employee.salary + " RON",
                    employee.phone,
                    employee.address,
                    employee.email
                    );
            }

        }
    }
}
