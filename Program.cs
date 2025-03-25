using System;
using System.Collections.Generic;

namespace Flowershop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "flowershop.txt";
            if (args.Length != 0)
                fileName = args[0];

            FileManagement fileManagement = new FileManagement(fileName);
            Flowershop shop = fileManagement.LoadFlowershop();

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
                Console.WriteLine("C. Clear console");
                Console.WriteLine("X. Exit");
                Console.Write("Option: ");
                opt = Console.ReadLine();
                Console.WriteLine();
                switch (opt.ToUpper())
                {
                    case "S":
                        fileManagement.SaveFlowershop(shop);
                        break;
                    case "SH":
                        shop.Display();
                        Console.WriteLine();
                        break;
                    case "ST":
                        shop.DisplayStock();
                        Console.WriteLine();
                        break;
                    case "DE":
                        shop.DisplayEmployees();
                        Console.WriteLine();
                        break;
                    case "AF":
                        string color; double price; int quantity, type;

                        Console.WriteLine("Flower Type. Enter the desired flower's ID:");
                        Flower.DisplayFlowerTypes();
                        type = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Flower Color:");
                        color = Console.ReadLine();
                        
                        Console.WriteLine("Flower Price:");
                        price = Convert.ToDouble(Console.ReadLine());
                        
                        Console.WriteLine("Flower Quantity:");
                        quantity = Convert.ToInt32(Console.ReadLine());

                        shop.AddFlower(new Flower((FlowerTypes) type, color, price, quantity));
                        fileManagement.AddFlower(new Flower((FlowerTypes)type, color, price, quantity));
                        Console.WriteLine();
                        Console.WriteLine("Succesfully added the new flower to the shop stock!");
                        Console.WriteLine();
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
                        fileManagement.AddEmployee(new Employee(name, address, phone, email, salary));
                        Console.WriteLine();
                        Console.WriteLine("Succesfully added the new employee to the shop!");
                        Console.WriteLine();
                        break;
                    case "SF":
                        string search;
                        Console.WriteLine("Search flower. Enter the deisred flower's ID:");
                        Flower.DisplayFlowerTypes();
                        search = Console.ReadLine();

                        FlowerTypes flowerType = (FlowerTypes)Convert.ToInt32(search);

                        foreach (Flower f in shop.stock)
                        {
                            if (f.type == flowerType)
                            {
                                f.Display();
                            }
                        }

                        Console.WriteLine();
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

                        Console.WriteLine();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "X":
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        Console.WriteLine();
                        break;
                }
            } while (opt != "X" && opt != "x");
        }
    }
}