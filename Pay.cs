using System;

// This class handles salary calculation for employees
public class Pay
{
    private double hourlyRate = 20.0;

    // Delegate for calculating salary
    public delegate double CalculateSalaryDelegate(double hours);

    // This method calculates the weekly salary based on hours worked
    public double CalculateWeeklySalary(double totalHours)
    {
        CalculateSalaryDelegate salaryCalc = hours => hours * hourlyRate;
        return salaryCalc(totalHours);
    }

    // This method allows setting a custom hourly rate
    public void SetHourlyRate(double rate)
    {
        hourlyRate = rate;
    }
}
