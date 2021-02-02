/// Jonghwan Lee, 000811948
/// Nov 21, 2020
/// 
/// Lab Assignment 4 (Fall 2020)
/// 
/// I, Jonghwan Lee, 000811948 certify that this material is my original work.  
/// No other person's work has been used without due acknowledgement.
///
/// This class was originally made by Nicholas J. Corkigian.
/// For the purpose of the lab assignment 4, this program was revised to follow the instruction. 
/// 
using System;

/// <summary>
/// This class describes the employee.
/// </summary>
public class Employee 
{
    public string Name { get; set; }    // employee name
    public int Number { get; set; }     // employee number
    public decimal Rate { get; set; }   // hourly rate
    public double Hours { get; set; }   // weekly hours
    public decimal Gross { get; set; }  // gross pay

    /// <summary>
    /// Default constructor for Employee
    /// </summary>
    public Employee()
	{
	}

    /// <summary>
    /// Four-argument constructor for Employee
    /// </summary>
    /// <param name="name">Employee name</param>
    /// <param name="number">Employee number</param>
    /// <param name="rate">Hourly rate of pay</param>
    /// <param name="hours">Hours worked in a week</param>
    public Employee(string name, int number, decimal rate, double hours)
    {
        Name = name;
        Number = number;
        Rate = rate;
        Hours = hours;

		if (hours < 40)
			Gross = (decimal)hours * rate;
		else
			Gross = (40.0m * rate) + (((decimal)hours - 40.0m) * rate * 1.5m);
	}

	/// <summary>
	/// Method to display Employee
	/// </summary>
	public override string ToString()
	{
        return $"{Name,-20}  {Number:D5}  {Rate,6:C}  {Hours:#0.00}  {Gross,9:C}";
    }

}

