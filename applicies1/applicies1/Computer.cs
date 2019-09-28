using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace applicies1
{
    public class Computer:DigitalAppliance
    {
        public Computer() { }
        private double _videoFrequency = 1;
        private DigitalAppliance _digitalAppliance = new DigitalAppliance();
        public void setVideoFrequency(double videoFrequency)
        {
            setGain(videoFrequency);
            _videoFrequency = videoFrequency;
        }
        public override void setGain(double gainInternal)
        {
            double baseGain = 1;
            Gain = baseGain * Math.Exp(Math.Atan(gainInternal)) / 2;
            
            setPower();
        }
        public override void setPower()
        {
            double basePower = voltage;
            power = Math.Round(basePower * Gain, 2) + power;
        }
        public double getVideoFrequency()
        {
            return (_videoFrequency);
        }
    }
}
