using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowershop
{
    class Flowershop
    {
        // shop name, address, phone number, stock of flowers, employees
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public Flower[] stock { get; set; }
        public Employee[] employees { get; set; }

        public Flowershop()
        {
            this.name = String.Empty;
            this.address = String.Empty;
            this.phone = String.Empty;
            this.stock = new Flower[0];
            this.employees = new Employee[0];
        }
    }
}
