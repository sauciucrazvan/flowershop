using System;

namespace Flowershop
{
    public enum FlowerTypes
    {
        Undefined = 0,
        Rose = 1,
        Tulip = 2,
        Lily = 3,
        Orchid = 4,
        Sunflower = 5,
        Daisy = 6,
        Daffodil = 7,
        Peony = 8,
        Iris = 9,
        Lavender = 10,
        Lilac = 11,
        Poppy = 12,
        Dahlia = 13
    }
    public class Flower
    {
        // type, price, color, quantity

        public FlowerTypes type { get; set; }
        public string color { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        public Flower()
        {
            this.type = FlowerTypes.Undefined;
            this.color = String.Empty;
            this.price = 0.0;
            this.quantity = 0;
        }

        public Flower(FlowerTypes type, string color, double price, int quantity)
        {
            this.type = type;
            this.color = color;
            this.price = price;
            this.quantity = quantity;
        }

        public void Display() {
            Console.WriteLine(this.type + " | Color: " + this.color + " | Price: " + this.price + " RON | Quantity: " + this.quantity);
        }

        public static void DisplayFlowerTypes() => Console.WriteLine("Types: Rose (1), Tulip (2), Lily (3), Orchid (4), Sunflower (5), Daisy (6), Daffodil (7), Peony (8), Iris (9), Lavender (10), Lilac (11), Poppy (12), Dahlia (13)\n");
    }
}
