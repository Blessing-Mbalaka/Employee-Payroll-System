using System;
using System.Collections.Generic;

// This class stores employee information and their daily work hours
public class edetails
{
    public string Name { get; set; }
    public long EmployeeId { get; set; }
    public List<double> HoursWorkedPerDay { get; set; }

    public edetails()
    {
        HoursWorkedPerDay = new List<double>();
    }

    // This method collects employee details from the user
    public void GetEmployeeDetails()
    {
        Console.Write("Enter Employee Name: ");
        Name = Console.ReadLine();

        Console.Write("Enter Employee ID: ");
        EmployeeId = long.Parse(Console.ReadLine());

        Console.WriteLine("Enter hours worked for each day:");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Day {i}: ");
            double hours = double.Parse(Console.ReadLine());
            HoursWorkedPerDay.Add(hours);
        }
    }

    // This method calculates total hours worked in the week
    public double GetTotalHours()
    {
        double total = 0;
        HoursWorkedPerDay.ForEach(hours => total += hours);
        return total;
    }
}
