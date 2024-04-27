namespace CurrencyConversion.Domain;

public class CurrencyConverter
{
    private readonly IRateService _rateService;

    public CurrencyConverter(IRateService rateService)
    {
        _rateService = rateService;
    }

    public double Convert(double amount, string sourceCurrency, string targetCurrency)
    {
        if (sourceCurrency != targetCurrency)
        {
            var rate = _rateService.GetRate(sourceCurrency, targetCurrency);
            var result = new Amount(amount).Multiply(rate);
            amount = result.GetValue();
        }
        return amount;
    }
}