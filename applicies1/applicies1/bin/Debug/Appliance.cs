namespace applicies1
{
    public abstract class Appliance
    {
        public Appliance() { }
        protected string name;
        protected double power = 1;
        protected double Gain = 1;
        protected double voltage = 220;
        public abstract void setPower();
        public double getPower()
        {
            return (power);
        }
        public abstract void setGain(double GainFromProg);
        public double getGain()
        {
            return (Gain);
        }
        public string Name
        {
            get{ return name; }
            set{ name = value; }
        }
    }
}
