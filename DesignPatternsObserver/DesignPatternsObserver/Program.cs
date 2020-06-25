using System;
using DesignPatternsObserver.Concretes;

namespace DesignPatternsObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherSvc = new WeatherService();
            weatherSvc.Register(new AudibleAlertSystem());
            weatherSvc.Register(new TextAlertSystem());

            // TODO hit up an API to get the current weather
            double temp = 66.1;
            weatherSvc.Notify(temp.ToString());
        }
    }
}
