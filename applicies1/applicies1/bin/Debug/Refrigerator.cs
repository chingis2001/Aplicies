using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace applicies1
{
    public class Refrigerator:HouseholdAppliance
    {
        public Refrigerator() { }
        private double _anchorResistance;
        public void SetAnchorResistance(double anchorResistance)
        {
            setGain(anchorResistance);
            _anchorResistance = anchorResistance;
        }
        public override void setGain(double internalGain)
        {
            double baseGain = 1;
            Gain = baseGain * 3 * Math.Pow(Math.Atan(internalGain), 0.5) / 2;
            setPower();
        }
        public override void setPower()
        {
            double basePower = voltage;
            power = Math.Round(basePower * Gain + power, 2);
        }
        public double getAnchorResistance()
        {
            return (_anchorResistance);
        }
    }
}
