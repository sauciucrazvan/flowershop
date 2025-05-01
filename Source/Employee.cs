using System;

namespace Flowershop
{
    public class Employee
    {
        // full name, phone number, email, salary, address
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public double salary { get; set; }

        public Employee()
        {
            this.name = String.Empty;
            this.address = String.Empty;
            this.phone = String.Empty;
            this.email = String.Empty;
            this.salary = 0.0;
        }

        public Employee(string name, string address, string phone, string email, double salary)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.salary = salary;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + this.name + "\t\t Address: " + this.address + "\t Phone: " + this.phone + "\nEmail: " + this.email + "\t Salary: " + this.salary + " RON");
        }

        public string toString()
        {
            return "• Name: " + this.name + " \tAddress: " + this.address + "\tPhone: " + this.phone + "\n   Email: " + this.email + "\tSalary: " + this.salary + " RON";
        }

        public string FileFormat()
        {
            return this.name + ";" + this.address + ";" + this.phone + ";" + this.email + ";" + this.salary;
        }
    }
}
