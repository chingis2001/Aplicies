using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace applicies1
{
    public class Microwave:HouseholdAppliance
    {
        public Microwave() { }
        private double _magnetronEfficiency;
        public void setMagnetronEfficiency(double magnetronEfficiency)
        {
            setGain(magnetronEfficiency / 100);
            _magnetronEfficiency = magnetronEfficiency;
        }
        public override void setGain(double internalGain)
        {
            double baseGain = 1;
            Gain = baseGain * 5 * Math.Exp(internalGain);
            setPower();
        }
        public override void setPower()
        {
            double basePower = voltage;
            power = Math.Round(basePower * Gain + power, 2);
        }
        public double getMagnetronEfficiency()
        {
            return (_magnetronEfficiency);
        }
    }
}
