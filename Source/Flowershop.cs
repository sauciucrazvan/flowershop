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

        public void DisplayEmployees()
        {
            foreach (Employee e in this.employees)
            {
                e.Display();
            }
        }

        public void AddFlower(Flower f)
        {
            this.stock.Add(f);
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
    }
}
