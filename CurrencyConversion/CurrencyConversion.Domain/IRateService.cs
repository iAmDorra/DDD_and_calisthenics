namespace CurrencyConversion.Domain;

public interface IRateService
{
    double GetRate(string sourceCurrency, string targetCurrency);
}