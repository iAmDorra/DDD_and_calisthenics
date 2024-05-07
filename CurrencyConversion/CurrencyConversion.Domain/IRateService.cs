namespace CurrencyConversion.Domain;

public interface IRateService
{
    Rate GetRate(Currency sourceCurrency, Currency targetCurrency);
}