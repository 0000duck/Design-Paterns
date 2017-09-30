using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class FacadePaternTest
    {
        [TestMethod]
        public void TestShouldReturnTemperature()
        {
            var temperatureFacade = new TemperatureFacade();
            LocalTemperature localTemp = temperatureFacade.GetTemperature();
                        
            Assert.AreEqual(localTemp.Farenheit, 86);
            Assert.AreEqual(localTemp.Celcius, 30);
        }
    }

    public class TemperatureFacade
    {
        readonly WeatherService weatherService;        
        readonly EnglishMetricConverter converter;

        public TemperatureFacade()
            : this(new WeatherService(), new EnglishMetricConverter())
        { }

        public TemperatureFacade(WeatherService weatherService, EnglishMetricConverter englishMetricConverter)
        {
            this.weatherService = weatherService;            
            this.converter = englishMetricConverter;
        }

        public LocalTemperature GetTemperature()
        {
            var farenheit = weatherService.GetTempFarenheit();
            var celcius = converter.FarenheitToCelcious(farenheit);

            var localTemperature = new LocalTemperature()
            {
                Farenheit = farenheit,
                Celcius = celcius,                
            };

            return localTemperature;
        }
    }

    public class LocalTemperature
    {
        public double Celcius { get; set; }
        public double Farenheit { get; set; }
    }

    public class WeatherService
    {
        public double GetTempFarenheit()
        {
            return 86;
        }
    }

    public class EnglishMetricConverter
    {
        public double FarenheitToCelcious(double degrees)
        {
            return ((degrees - 32) / 9.0) * 5.0;
        }
    }
}
