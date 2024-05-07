namespace CurrencyConversion.Domain;

public class Amount
{
    private readonly double value;
    private readonly Currency currency;

    public Amount Multiply(Rate rate)
    {
        return new Amount(rate.Multiply(value), currency);
    }

    public Amount(double value, Currency currency)
    {
        this.value = value;
        this.currency = currency;
    }

    public double GetValue()
    {
        return value;
    }

    public bool HasSameCurrency(Currency targetCurrency)
    {
        return this.currency.IsEqualTo(targetCurrency);
    }

    public Currency GetCurrency()
    {
        return this.currency;
    }
}