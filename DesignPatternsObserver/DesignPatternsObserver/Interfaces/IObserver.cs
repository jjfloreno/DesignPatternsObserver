using System;
namespace DesignPatternsObserver.Interfaces
{
    public interface IObserver
    {
        public string Name { get; }
        void Update(string input);
    }
}
