﻿using System;

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
        // type\nprice\ncolor\nquantity

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

        public string toString()
        {
            return "• " + this.type + " [color: " + this.color + ", price: " + this.price + " RON, quantity: " + this.quantity + "]";
        }

        public string FileFormat()
        {
            return (int) this.type + ";" + this.color + ";" + this.price + ";" + this.quantity;
        }

        public static void DisplayFlowerTypes() => Console.WriteLine("Types: Rose (1)\nTulip (2)\nLily (3)\nOrchid (4)\nSunflower (5)\nDaisy (6)\nDaffodil (7)\nPeony (8)\nIris (9)\nLavender (10)\nLilac (11)\nPoppy (12)\nDahlia (13)\n");
        public static string showFlowerTypes() => "Types:\nRose (1)\nTulip (2)\nLily (3),\nOrchid (4)\nSunflower (5)\nDaisy (6),\nDaffodil (7)\nPeony (8)\nIris (9),\nLavender (10)\nLilac (11)\nPoppy (12),\nDahlia (13)\n";
    }
}
