namespace CurrencyConversion.Domain;

public class Rate
{
    private readonly double value;

    public Rate(double rate)
    {
        this.value = rate;
    }

    public double Multiply(double amount)
    {
        return amount * value;
    }
}