﻿using System;
namespace DesignPatternsObserver.Interfaces
{
    public interface IObservable
    {
        void Register(IObserver observer);
        void Remove(IObserver observer);
        void Notify(string inpupt);
    }
}