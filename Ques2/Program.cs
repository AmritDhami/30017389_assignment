using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************Welcome to the Rotorua holiday's Park Payroll system*********** *****************");

            Console.WriteLine();

            /*Object intstantiation*/
            Employee p1 = new Employee();

            Console.Write("Please enter the employee's first name: ");
            string fname = Console.ReadLine();
            Console.Write("Please enter the employee's last name: ");
            string lname = Console.ReadLine();

            Console.Write($"Please enter your annual gross salary: ");
            p1.Gross = double.Parse(Console.ReadLine());
            Console.Write("Please enter your tax rate: ");

            p1.Tax = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("\n\nThank you, Here is the record you entered ..........");
            Console.WriteLine();


        }
        public class Employee
        {
            //instance variables 
            private string name;
            private double gross;
            private double tax;

            //getters and setters 
            public string Name { get { return name; } set { name = value; } }
            public double Gross { get { return gross; } set { gross = value; } }
            public double Tax { get { return tax; } set { tax = value; } }




            //Method to claculate the employees net salary( after tax)

            public double CalcNet()
            {
                return Gross * (1 - Tax / 100);
            }


            //parameterless constructor 
            public Employee()
            {
                Console.WriteLine(" new Employee recrod created");
            }
        }
    }
}

