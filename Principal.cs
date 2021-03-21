using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadFirstDesignPatterns.Observer.WeatherData;

namespace WeatherStation
{
    class Principal
    {
        public static void Main()
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditionsDisplay   = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay        statisticsDisplay          = new StatisticsDisplay(weatherData);
            ForcastDisplay           forcastDisplay             = new ForcastDisplay(weatherData);
            HeatIndexDisplay         heatIndexDisplay           = new HeatIndexDisplay(weatherData);

            Console.WriteLine("The Weather Station App...");

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            Console.ReadLine();
        }
    }
}
