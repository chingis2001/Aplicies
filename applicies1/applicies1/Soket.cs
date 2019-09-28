using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace applicies1
{
    public class Soket
    {
        private List<Appliance> appliances = new List<Appliance>();
        public void AddAppliance(Appliance appliance)
        {
            appliances.Add(appliance);
        }
        public double GetSumPowerty()
        {
            double sumpowerty = 0;
            for (int i = 0; i < appliances.Count(); i++)
            {
                sumpowerty += appliances[i].getPower();
            }
            return (sumpowerty);
        }
        public List<Appliance> GetAppliances()
        {
            return appliances;
        }
        public void DelAppliance(Appliance appliance)
        {
            appliances.Remove(appliance);
        }
    }
}
