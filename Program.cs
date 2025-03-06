using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowershop
{
    class Program
    {
        static void Main(string[] args)
        {
            Flowershop shop = new Flowershop();
            shop.name = "PARFUMUL FLORILOR";
            shop.address = "DN29, Dumbraveni, 727225";
            shop.phone = "0743623234";
            shop.stock = new List<Flower>
            {
                new Flower("Rose", "Red", 7.99, 100),
                new Flower("Tulip", "Yellow", 5.99, 50),
                new Flower("Daisy", "White", 3.49, 200)
            };
            shop.employees = new List<Employee>
            {
                new Employee("Glabert-Horel Dalan",
                            "Homeless",
                            "07nosimcard",
                            "glaberthoreldalan@gmail.com",
                            2300)
            };

            string opt;
            do
            {
                Console.WriteLine("SH. Display shop details");
                Console.WriteLine("ST. Display stock");
                Console.WriteLine("DE. Display employees");
                Console.WriteLine("AF. Add flower");
                Console.WriteLine("AE. Add employee");
                Console.WriteLine("SF. Search flower");
                Console.WriteLine("SE. Search employee");
                Console.WriteLine("X. Exit");
                Console.Write("Option: ");
                opt = Console.ReadLine();
                Console.WriteLine();
                switch (opt.ToUpper())
                {
                    case "SH":
                        shop.Display();
                        break;
                    case "ST":
                        shop.DisplayStock();
                        break;
                    case "DE":
                        shop.DisplayEmployees();
                        break;
                    case "AF":
                        string type, color; double price; int quantity;
                        Console.WriteLine("Flower Type:");
                        type = Console.ReadLine();
                        Console.WriteLine("Flower Color:");
                        color = Console.ReadLine();
                        Console.WriteLine("Flower Price:");
                        price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Flower Quantity:");
                        quantity = Convert.ToInt32(Console.ReadLine());

                        shop.AddFlower(new Flower(type, color, price, quantity));
                        break;
                    case "AE":
                        string name, address, phone, email; double salary;
                        Console.WriteLine("Employee Name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Employee Address:");
                        address = Console.ReadLine();
                        Console.WriteLine("Phone Number:");
                        phone = Console.ReadLine();
                        Console.WriteLine("Email:");
                        email = Console.ReadLine();
                        Console.WriteLine("Salary:");
                        salary = Convert.ToInt32(Console.ReadLine());

                        shop.AddEmployee(new Employee(name, address, phone, email, salary));
                        break;
                    case "SF":
                        string search;
                        Console.WriteLine("Search flower:");
                        search = Console.ReadLine();
                        foreach (Flower f in shop.stock)
                        {
                            if (f.type == search)
                            {
                                f.Display();
                            }
                        }
                        break;
                    case "SE":
                        string searchEmp;
                        Console.WriteLine("Search employee:");
                        searchEmp = Console.ReadLine();
                        foreach (Employee e in shop.employees)
                        {
                            if (e.name == searchEmp)
                            {
                                e.Display();
                            }
                        }
                        break;
                    case "X":
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            } while (opt != "X");
        }
    }
}