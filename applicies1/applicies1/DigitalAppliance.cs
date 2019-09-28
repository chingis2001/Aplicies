using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace applicies1
{
    public class DigitalAppliance : Appliance
    {
        public DigitalAppliance(){
}
        private int _digit=8;
        public void SetDigit(int digit)
        {
            switch (digit)
            {
                case 8:
                    setGaind(1.8);
                    _digit = digit;
                    break;
                case 16:
                    setGaind(2.2);
                    _digit = digit;
                    break;
                case 32:
                    setGaind(2.6);
                    _digit = digit;
                    break;
                case 64:
                    setGaind(2.8);
                    _digit = digit;
                    break;
                default:
                    setGaind(1);
                    break;
            }
        }
        protected void setGaind(double gainInternal)
        {
            double baseGain = 1;
            Gain = baseGain * Math.Pow(Math.Pow(Math.Log10(gainInternal), 0.5) / 8, 3);
            setPowerd();
        }
        protected void setPowerd()
        {
            double basePower = voltage;
            power = Math.Round(basePower * Gain, 2);
        }
        public override void setGain(double gainInternal){}
        public override void setPower(){}
        public int GetDigit()
        {
            return (_digit);
        }
    }
}
