using System;

// This class calculates bonus payments for employees
public class bonus
{
    // Delegate for bonus calculation
    public delegate double CalculateBonusDelegate(double salary, double hours);

    // This method calculates bonus based on total hours worked
    public double CalculateBonus(double salary, double totalHours)
    {
        CalculateBonusDelegate bonusCalc = (sal, hrs) =>
        {
            if (hrs > 50)
                return sal * 0.15;
            else if (hrs > 45)
                return sal * 0.10;
            else
                return 0;
        };

        return bonusCalc(salary, totalHours);
    }
}
