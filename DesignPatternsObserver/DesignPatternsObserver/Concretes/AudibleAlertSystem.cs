using System;
using System.IO;
using DesignPatternsObserver.Interfaces;
using NAudio.Wave;
using System.Media;

namespace DesignPatternsObserver.Concretes
{
    public class AudibleAlertSystem : IObserver
    {
        public AudibleAlertSystem()
        {
            Name = "Audible Alert System";
        }

        public string Name { get; private set; }

        public void Update(string temp)
        {
            var filePath = GetFilePathFromTemperature(temp);

            // TODO make this work
            var audioFile = new AudioFileReader(filePath);
        }

        public string GetFilePathFromTemperature(string input)
        {
            if (double.Parse(input) >= 60)
            {
                return @"Sounds/imsend.wav";
            }

            return @"Sounds/imrcv.wav";
        }
    }
}