using System;
using DesignPatternsObserver.Interfaces;

namespace DesignPatternsObserver.Concretes
{
    public class TextAlertSystem : IObserver
    {
        public TextAlertSystem()
        {
            Name = "Text Alert System";
        }

        public string Name { get; private set; }

        public void Update(string temp)
        {
            if (double.Parse(temp) >= 60)
            {
                Console.WriteLine($"It's a warm one! Temperature is {temp} degrees.");
            }
            else
            {
                Console.WriteLine($"Grab a coat. Temperature is {temp} degrees.");
            }
        }
    }
}
