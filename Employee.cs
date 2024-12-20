using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03
{
    internal class Employee
    {
        // Fields
        public int Id { get; set; }    // Employee ID
        public string Name { get; set; }    // Employee Name
        public int YearOfBirth { get; set; } // Year of Birth
        public double SalaryLevel { get; set; } // Salary Level
        public static double BasicSalary { get; set; } = 3000; // Basic Salary (shared among all employees)

        // Method to calculate income
        public double GetIncome()
        {
            return SalaryLevel * BasicSalary;
        }

        // Method to display employee information
        public void Display()
        {
            Console.WriteLine("Employee ID: {0}", Id);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Year of Birth: {0}", YearOfBirth);
            Console.WriteLine("Salary Level: {0}", SalaryLevel);
            Console.WriteLine("Basic Salary: {0}", BasicSalary);
            Console.WriteLine("Income: {0}", GetIncome());
            Console.WriteLine();
        }
    }
}
