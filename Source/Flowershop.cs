using System;
using System.Collections.Generic;
using System.Linq;

namespace Flowershop
{
    public class Flowershop
    {
        // shop name, address, phone number, stock of flowers, employees
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public List<Flower> stock { get; set; }
        public List<Employee> employees { get; set; }

        public Flowershop()
        {
            this.name = String.Empty;
            this.address = String.Empty;
            this.phone = String.Empty;
            this.stock = new List<Flower>();
            this.employees = new List<Employee>();
        }

        public void Display()
        {
            Console.WriteLine("Shop name: " + this.name);
            Console.WriteLine("Address: " + this.address);
            Console.WriteLine("Phone: " + this.phone);
        }

        public void DisplayStock()
        {
            foreach (Flower f in this.stock)
            {
                f.Display();
            }
        }

        public string showStock()
        {
            string result = "";
            foreach (Flower f in this.stock)
            {
                result += f.toString() + "\n";
            }
            return string.IsNullOrEmpty(result) ? "No stock available." : result;
        }

        public void DisplayEmployees()
        {
            foreach (Employee e in this.employees)
            {
                e.Display();
            }
        }

        public string showEmployees()
        {
            string result = "";
            foreach (Employee e in this.employees)
            {
                result += e.toString() + "\n\n";
            }
            return string.IsNullOrEmpty(result) ? "No employees saved." : result;
        }

        public void AddFlower(Flower f)
        {
            this.stock.Add(f);
        }

        public void RemoveFlower(Flower f)
        {
            this.stock.Remove(f);
        }

        public void AddEmployee(Employee e)
        {
            this.employees.Add(e);
        }

        public string FileFormat()
        {
            string result = this.name + ";" + this.address + ";" + this.phone + "\n";
            
            foreach (Flower f in this.stock)
            {
                result += f.FileFormat() + "\n";
            }

            foreach (Employee e in this.employees)
            {
                result += e.FileFormat() + "\n";
            }
            
            return result;
        }

        public string toString()
        {
            if (string.IsNullOrEmpty(this.name) || string.IsNullOrEmpty(this.address) || string.IsNullOrEmpty(this.phone))
            {
                return "No shop information available.";
            }

            return "Address: " + this.address + " | Phone number: +" + this.phone;
        }
    }
}
