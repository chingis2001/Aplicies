using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace applicies1
{
    public class Telephone : DigitalAppliance
    {
        public Telephone() { }
        private double _transducerResistance;
        public void setTransducerResistance(double transducerResistance)
        {
            setGain(transducerResistance);
            _transducerResistance = transducerResistance;
        }
        public override void setGain(double gainInternal)
        {
            double baseGain = 1;
            Gain = baseGain * Math.Pow(Math.Pow(Math.Atan(gainInternal), 0.5) / 10, 2);
            setPower();
        }
        public override void setPower()
        {
            double basePower = voltage;
            power = Math.Round(basePower * Gain + power, 2);
        }
        public double getTransducerResistance()
        {
            return (_transducerResistance);
        }
    }
}
