using CurrencyConversion.Domain;
using NSubstitute;

namespace CurrencyConversion.Tests
{
    [TestClass]
    public class CurrencyConverterTest
    {
        [TestMethod]
        public void Should_return_the_same_amount_when_target_currency_is_same()
        {
            var rate = 1;
            var amount = 100;
            var sourceCurrency = "EUR";
            var targetCurrency = "EUR";
            IRateService rateService = Substitute.For< IRateService>();
            rateService.GetRate(sourceCurrency, targetCurrency).Returns(rate);
            CurrencyConverter currencyConverter = new CurrencyConverter(rateService);
            var result = currencyConverter.Convert(amount, sourceCurrency, targetCurrency);

            var expectedAmount = 100;
            Assert.AreEqual(expectedAmount, result);
        }
    }
}