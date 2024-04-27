namespace CurrencyConversion.Domain;

public interface IRateService
{
    Rate GetRate(string sourceCurrency, string targetCurrency);
}