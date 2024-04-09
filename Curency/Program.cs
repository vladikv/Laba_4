using System;
using System.Collections.Generic;
using System.Linq;

class Currency
{
    public string Name { get; set; }
    public double ExchangeRate { get; set; }
}

class CurrencyExchange
{
    private Dictionary<string, int> availableCurrencies; 
    private List<Currency> currencies; 

    public CurrencyExchange()
    {
        currencies = new List<Currency>();
        availableCurrencies = new Dictionary<string, int>();
    }

    public void AddCurrency(Currency currency, int amount)
    {
        currencies.Add(currency);
        availableCurrencies[currency.Name] = amount;
    }

    public void ExchangeCurrency(string fromCurrency, string toCurrency, double amount)
    {
        var from = currencies.FirstOrDefault(c => c.Name == fromCurrency);
        var to = currencies.FirstOrDefault(c => c.Name == toCurrency);

        if (from == null || to == null)
        {
            Console.WriteLine("Invalid currency.");
            return;
        }

        double exchangedAmount = amount * from.ExchangeRate / to.ExchangeRate;
        availableCurrencies[fromCurrency] -= (int)amount;
        availableCurrencies[toCurrency] += (int)exchangedAmount;

        Console.WriteLine($"Exchanged {amount} {fromCurrency} to {exchangedAmount} {toCurrency}");
    }

    public void PrintAvailableCurrencies()
    {
        Console.WriteLine("Available currencies in exchange:");
        foreach (var currency in currencies)
        {
            Console.WriteLine($"{currency.Name} - {availableCurrencies[currency.Name]}");
        }
    }
}



class Program
{
    static void Main(string[] args)
    {
        CurrencyExchange exchange = new CurrencyExchange();

        exchange.AddCurrency(new Currency { Name = "USD", ExchangeRate = 1 }, 1000);
        exchange.AddCurrency(new Currency { Name = "EUR", ExchangeRate = 0.85 }, 800);
        exchange.AddCurrency(new Currency { Name = "GBP", ExchangeRate = 0.72 }, 700);
        exchange.AddCurrency(new Currency { Name = "JPY", ExchangeRate = 110.23 }, 500);
        exchange.AddCurrency(new Currency { Name = "CAD", ExchangeRate = 1.25 }, 600);
        exchange.AddCurrency(new Currency { Name = "AUD", ExchangeRate = 1.30 }, 550);

        exchange.ExchangeCurrency("USD", "EUR", 200);

        exchange.PrintAvailableCurrencies();
    }
}
