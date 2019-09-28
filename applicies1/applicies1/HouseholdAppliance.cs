using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace applicies1
{
    public class HouseholdAppliance : Appliance
    {
        public HouseholdAppliance(){}
        protected double _temperatureСoefficient;
        public void setTemperatureCoefficient(double temperatureCoefficient)
        {
            setGainh(temperatureCoefficient);
            _temperatureСoefficient = temperatureCoefficient;
        }
        protected void setGainh(double gainInternal)
        {
            double baseGain = 1;
            Gain = baseGain * Math.Pow(2.7, -Math.Exp(gainInternal));
            setPowerh();
        }
        protected void setPowerh()
        {
            double basePower = voltage;
            power = Math.Round(basePower * Gain, 2);
        }
        public override void setGain(double internalGain){}
        public override void setPower(){}
        public double getTemperatureСoefficient()
        {
            return (_temperatureСoefficient);
        }
    }
}
