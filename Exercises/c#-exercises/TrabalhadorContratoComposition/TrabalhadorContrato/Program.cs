using System;
using System.Globalization;
using TrabalhadorContrato.Entities;
using TrabalhadorContrato.Entities.Enums;

namespace TrabalhadorContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptname = Console.ReadLine();
            Console.WriteLine("Enter work data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior / MidLevel / Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /*Instanciar departamento*/
            Department dept = new Department(deptname);

            /*Instanciar worker*/
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts for this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write($"Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write($"Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration(hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.addContract(contract);
            }
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndyear = Console.ReadLine();
            int month = int.Parse(monthAndyear.Substring(0, 2));
            int year = int.Parse(monthAndyear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for: " + monthAndyear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
