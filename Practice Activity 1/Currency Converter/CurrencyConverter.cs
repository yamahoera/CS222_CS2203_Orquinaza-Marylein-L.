using System;

public class CurrencyConverter
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Amount in USD: ");
        double amount = double.Parse(Console.ReadLine());
        
        Console.Write("Enter exchange rate from USD to EUR: ");
        double currency = double.Parse(Console.ReadLine());
        
        double ExchangeRate = amount * currency;
        
        Console.WriteLine("Amount in EUR: {0:F2}", ExchangeRate);
    }
}