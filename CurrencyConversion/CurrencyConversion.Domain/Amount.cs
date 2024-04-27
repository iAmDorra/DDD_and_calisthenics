namespace CurrencyConversion.Domain;

public class Amount
{
    private readonly double value;
    public Amount Multiply(Rate rate)
    {
        return rate.Multiply(value);
    }

    public Amount(double value)
    {
        this.value = value;
    }

    public double GetValue()
    {
        return value;
    }

    
}