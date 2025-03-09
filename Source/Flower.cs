using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowershop
{
    class Flower
    {
        // type, price, color, quantity

        public string type { get; set; }
        public string color { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        public Flower()
        {
            this.type = String.Empty;
            this.color = String.Empty;
            this.price = 0.0;
            this.quantity = 0;
        }

        public Flower(string type, string color, double price, int quantity)
        {
            this.type = type;
            this.color = color;
            this.price = price;
            this.quantity = quantity;
        }

        public void Display() {
            Console.WriteLine(this.type + " | Color: " + this.color + " | Price: " + this.price + " RON | Quantity: " + this.quantity);
        }
    }
}
