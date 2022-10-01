using System;
using System.Collections.Generic;
using System.Text;

namespace Practice8.models
{
    class MobilePhoneWithBlackScreen : PushButtonTelephone
    {

        public string ScreenResolution { get; set; }
        public double PhysicalScreenSize { get; set; }
        public string ColorOfDevice { get; set; }

        public MobilePhoneWithBlackScreen(long number, string screenResolution, double physicalScreenSize, string colorOfDevice)
            : base(number)
        {
            Symbols.Add("+");
            Symbols.Add("-");
            Symbols.Add("(");
            Symbols.Add(")");

            this.ScreenResolution = screenResolution;
            this.PhysicalScreenSize = physicalScreenSize;
            this.ColorOfDevice = colorOfDevice;
        }

        public override void AcceptCall()
        {
            Console.WriteLine("Accept call from Phone With Black Screen!");
        }

        public override void Call()
        {
            Console.WriteLine("Call from Phone With Black Screen!");
        }

        public override void Characteristics()
        {
            base.Characteristics();
            Console.WriteLine("Screen Resolution: " + this.ScreenResolution 
                + "\nPhysical Screen Size: " + this.ScreenResolution 
                + "\nColor of device: " + this.ColorOfDevice);
        }
    }
}   
