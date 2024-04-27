namespace CurrencyConversion.Domain;

public class Amount
{
    private readonly double value;

    public Amount(double value)
    {
        this.value = value;
    }

    public double GetValue()
    {
        return value;
    }

    public Amount Multiply(Rate rate)
    {
        return new Amount(value * rate.GetValue());
    }
}