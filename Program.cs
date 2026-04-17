using System;
using System.Collections.Generic;

// This is the main system class that runs the employee management program
class Program
{
    static void Main(string[] args)
    {
        List<edetails> employees = new List<edetails>();

        Console.WriteLine("=== Employee Management System ===\n");

        Console.Write("How many employees do you want to enter? ");
        int numberOfEmployees = int.Parse(Console.ReadLine());

        // Process each employee using our classes
        for (int i = 0; i < numberOfEmployees; i++)
        {
            Console.WriteLine($"\n--- Employee {i + 1} ---");

            edetails emp = new edetails();
            emp.GetEmployeeDetails();
            employees.Add(emp);
        }

        // Create instances of our helper classes
        Pay payCalculator = new Pay();
        bonus bonusCalculator = new bonus();
        printing printer = new printing();

        // Display results for each employee using lambda with List
        employees.ForEach(emp =>
        {
            double totalHours = emp.GetTotalHours();
            double salary = payCalculator.CalculateWeeklySalary(totalHours);
            double bonusAmount = bonusCalculator.CalculateBonus(salary, totalHours);

            printer.DisplayEmployeeInfo(emp, totalHours, salary, bonusAmount);
        });

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
