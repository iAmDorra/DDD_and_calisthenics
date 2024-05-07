namespace CurrencyConversion.Domain;

public class Currency
{
    private readonly string value;

    public Currency(string currency)
    {
        value = currency;
    }

    public bool IsEqualTo(Currency other)
    {
        return value == other.value;
    }
}