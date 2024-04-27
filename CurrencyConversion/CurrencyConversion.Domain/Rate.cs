namespace CurrencyConversion.Domain;

public class Rate
{
    private readonly double rate;

    public Rate(double rate)
    {
        this.rate = rate;
    }

    public double GetValue()
    {
        return rate;
    }
}