namespace CurrencyConversion.Domain;

public class Rate
{
    private readonly double rate;

    public Rate(double rate)
    {
        this.rate = rate;
    }

    public Amount Multiply(double amount)
    {
        return new Amount(amount * rate);
    }
}