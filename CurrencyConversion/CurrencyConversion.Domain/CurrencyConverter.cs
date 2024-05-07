namespace CurrencyConversion.Domain;

public class CurrencyConverter
{
    private readonly IRateService _rateService;

    public CurrencyConverter(IRateService rateService)
    {
        _rateService = rateService;
    }

    public Amount Convert(Amount amount, Currency targetCurrency)
    {
        if (!amount.HasSameCurrency(targetCurrency))
        {
            var rate = _rateService.GetRate(amount.GetCurrency(), targetCurrency);
            var result = amount.Multiply(rate);
            return result;
        }
        return amount;
    }
}