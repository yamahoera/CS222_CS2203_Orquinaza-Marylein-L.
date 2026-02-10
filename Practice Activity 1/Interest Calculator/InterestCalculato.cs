using System;

public class InterestCalculator
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Principal Amount: ");
        double principal = double.Parse(Console.ReadLine());
        
        Console.Write("Enter rate of interest: ");
        double interest = double.Parse(Console.ReadLine());
        
        Console.Write("Enter time in years: ");
        double time = double.Parse(Console.ReadLine());
        double SimpleInterest = (principal * interest * time) / 100;
        
        Console.WriteLine("Simple Interest: {0:F2}", SimpleInterest);
    }
}