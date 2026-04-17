using System;

// This class displays all employee information to the screen
public class printing
{
    // This method prints employee details with salary and bonus information
    public void DisplayEmployeeInfo(edetails employee, double totalHours, double salary, double bonusAmount)
    {
        Console.WriteLine("\n========== EMPLOYEE INFORMATION ==========");
        Console.WriteLine($"Employee Name: {employee.Name}");
        Console.WriteLine($"Employee ID: {employee.EmployeeId}");
        Console.WriteLine($"Total Hours Worked: {totalHours} hours");
        Console.WriteLine($"Weekly Salary: R{salary:F2}");
        
        if (bonusAmount > 0)
        {
            Console.WriteLine($"Bonus: R{bonusAmount:F2}");
            Console.WriteLine($"Total Pay: R{(salary + bonusAmount):F2}");
        }
        else
        {
            Console.WriteLine("Bonus: Not applicable");
            Console.WriteLine($"Total Pay: R{salary:F2}");
        }
        
        Console.WriteLine("==========================================\n");
    }
}
