using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowershop
{
    public class FileManagement
    {
        private string numeFisier;
        public FileManagement(string numeFisier)
        {
            this.numeFisier = numeFisier;

            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddEmployee(Employee e)
        {
            using (StreamWriter swFisierText = File.AppendText(numeFisier))
            {
                swFisierText.WriteLine(e.FileFormat());
            }
        }

        public void AddFlower(Flower f)
        {
            using (StreamWriter swFisierText = File.AppendText(numeFisier))
            {
                swFisierText.WriteLine(f.FileFormat());
            }
        }

        public void ReadEmployees(List<Employee> employees)
        {
            using (StreamReader srFisierText = new StreamReader(numeFisier))
            {
                string linie;
                while ((linie = srFisierText.ReadLine()) != null)
                {
                    string[] date = linie.Split(';');
                    employees.Add(new Employee(date[0], date[1], date[2], date[3], Convert.ToDouble(date[4])));
                }
            }
        }

        public void ReadFlowers(List<Flower> flowers)
        {
            using (StreamReader srFisierText = new StreamReader(numeFisier))
            {
                string linie;
                while ((linie = srFisierText.ReadLine()) != null)
                {
                    string[] date = linie.Split(';');
                    flowers.Add(new Flower((FlowerTypes)Convert.ToInt32(date[0]), date[1], Convert.ToDouble(date[2]), Convert.ToInt32(date[3])));
                }
            }
        }

        public void SaveFlowershop(Flowershop shop)
        {
            using (StreamWriter swFisierText = new StreamWriter(numeFisier))
            {
                swFisierText.WriteLine(shop.name);
                swFisierText.WriteLine(shop.address);
                swFisierText.WriteLine(shop.phone);

                foreach (Flower f in shop.stock)
                {
                    swFisierText.WriteLine(f.FileFormat());
                }
                
                foreach (Employee e in shop.employees)
                {
                    swFisierText.WriteLine(e.FileFormat());
                }
            }
        }

        public Flowershop LoadFlowershop()
        {
            using (StreamReader srFisierText = new StreamReader(numeFisier))
            {
                string name = srFisierText.ReadLine();
                string address = srFisierText.ReadLine();
                string phone = srFisierText.ReadLine();

                List<Flower> flowers = new List<Flower>();
                List<Employee> employees = new List<Employee>();

                string linie;
                while ((linie = srFisierText.ReadLine()) != null)
                {
                    string[] date = linie.Split(';');
                    if (date.Length == 5) // Employee
                    {
                        employees.Add(new Employee(date[0], date[1], date[2], date[3], Convert.ToDouble(date[4])));
                    }
                    else if (date.Length == 4) // Flower
                    {
                        flowers.Add(new Flower((FlowerTypes)Convert.ToInt32(date[0]), date[1], Convert.ToDouble(date[2]), Convert.ToInt32(date[3])));
                    }
                }

                return new Flowershop
                {
                    name = name,
                    address = address,
                    phone = phone,
                    stock = flowers,
                    employees = employees
                };
            }
        }
    }
}
