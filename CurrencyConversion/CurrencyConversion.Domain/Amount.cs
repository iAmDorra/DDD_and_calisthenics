namespace CurrencyConversion.Domain;

internal class Amount
{
    private readonly double amount;

    public Amount(double amount)
    {
        this.amount = amount;
    }

    public double GetValue()
    {
        return amount;
    }
}