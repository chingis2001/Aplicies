using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using applicies1;


namespace Appliance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello\n");
            Soket soket = SoketFactory.CreateSoket();
            SoketPrinter.ShowSoket(soket);
            Console.ReadLine();
        }
    }
    public class SoketFactory
    {
        public static Soket CreateSoket()
        {
            Telephone telephone = new Telephone();
            telephone.Name = "Sony ericson";
            telephone.SetDigit(16);
            telephone.setTransducerResistance(50);
            Computer computer = new Computer();
            computer.Name = "HP1577";
            computer.SetDigit(32);
            computer.setVideoFrequency(1.7);
            Microwave microwave = new Microwave();
            microwave.Name = "Samsung c 1677";
            microwave.setTemperatureCoefficient(1.8);
            microwave.setMagnetronEfficiency(47);
            Refrigerator refrigerator = new Refrigerator();
            refrigerator.Name = "Birysa17";
            refrigerator.setTemperatureCoefficient(1.8);
            refrigerator.SetAnchorResistance(90);
            Soket soket = new Soket();
            soket.AddAppliance(telephone);
            soket.AddAppliance(computer);
            soket.AddAppliance(refrigerator);
            soket.AddAppliance(microwave);
            return (soket);
        }
    }
    public class SoketPrinter
    {
        static public void ShowSoket(Soket soket)
        {
            Console.WriteLine("Applicies that soked:\n");
            for (int i = 0; i < soket.GetAppliances().Count(); i++)
            {
                Console.WriteLine("Name of appliance: \n" + soket.GetAppliances()[i].Name);
                Console.WriteLine("Powerty of appliance: " + soket.GetAppliances()[i].getPower()+" Вт\n");
                if (soket.GetAppliances()[i] is Computer)
                {
                    Computer c = new Computer();
                    c = (Computer)soket.GetAppliances()[i];
                    Console.WriteLine("Fideo frequency: " + c.getVideoFrequency()+" MHz\n");
                    Console.WriteLine("Digit: " + c.GetDigit()+" Bit\n");
                }
                if (soket.GetAppliances()[i] is Telephone)
                {
                    Telephone t = new Telephone();
                    t = (Telephone)soket.GetAppliances()[i];
                    Console.WriteLine("Transdurance Resistance: " + t.getTransducerResistance()+" KOhm\n");
                    Console.WriteLine("Digit: " + t.GetDigit()+" Bit\n");
                }
                if (soket.GetAppliances()[i] is Refrigerator)
                {
                    Refrigerator r = new Refrigerator();
                    r = (Refrigerator)soket.GetAppliances()[i];
                    Console.WriteLine("Temperature coefficient of Zener diode: " + r.getTemperatureСoefficient()+"\n");
                    Console.WriteLine("Anchor Resistance: " + r.getAnchorResistance()+" KOhm\n");
                }
                if (soket.GetAppliances()[i] is Microwave)
                {
                    Microwave m = new Microwave();
                    m = (Microwave)soket.GetAppliances()[i];
                    Console.WriteLine("Temperature coefficient of Zener diode: " + m.getTemperatureСoefficient()+"\n");
                    Console.WriteLine("Efficiency of Magnetron: " + m.getMagnetronEfficiency()+" %\n");
                }
            }
            Console.WriteLine("Powerty = " + soket.GetSumPowerty()+" Вт");
        }
    }
}
