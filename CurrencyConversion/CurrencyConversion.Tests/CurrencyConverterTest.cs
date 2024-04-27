using CurrencyConversion.Domain;
using NSubstitute;

namespace CurrencyConversion.Tests
{
    [TestClass]
    public class CurrencyConverterTest
    {
        [TestMethod]
        public void Should_return_the_same_amount_when_source_and_target_currency_are_same()
        {
            var rate = 1;
            var amount = 100;
            var sourceCurrency = "EUR";
            var targetCurrency = "EUR";
            IRateService rateService = Substitute.For< IRateService>();
            rateService.GetRate(sourceCurrency, targetCurrency).Returns(new Rate(rate));
            CurrencyConverter currencyConverter = new CurrencyConverter(rateService);
            var result = currencyConverter.Convert(amount, sourceCurrency, targetCurrency);
            
            Assert.AreEqual(amount, result);
        }

        [TestMethod]
        public void Should_return_the_converted_amount_of_a_source_currency()
        {
            var rate = 1.1329;
            var amount = 100;
            var sourceCurrency = "EUR";
            var targetCurrency = "USD";
            IRateService rateService = Substitute.For<IRateService>();
            rateService.GetRate(sourceCurrency, targetCurrency).Returns(new Rate(rate));
            CurrencyConverter currencyConverter = new CurrencyConverter(rateService);
            var result = currencyConverter.Convert(amount, sourceCurrency, targetCurrency);

            var expectedAmount = amount * rate;
            Assert.AreEqual(expectedAmount, result);
        }
    }
}