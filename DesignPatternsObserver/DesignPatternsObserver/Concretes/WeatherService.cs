using System;
using System.Collections.Generic;
using DesignPatternsObserver.Interfaces;

namespace DesignPatternsObserver.Concretes
{
    public class WeatherService : IObservable
    {
        private List<IObserver> _watchers = new List<IObserver>();

        public void Notify(string temp)
        {
            foreach (var observer in _watchers)
            {
                observer.Update(temp);
                System.Threading.Thread.Sleep(2500);
            }
        }

        public void Register(IObserver observer)
        {
            _watchers.Add(observer);
            Console.WriteLine($"{observer.Name} Registered");
        }

        public void Remove(IObserver observer)
        {
            _watchers.Remove(observer);
            Console.Write($"{observer.Name} Removed");
        }
    }
}
