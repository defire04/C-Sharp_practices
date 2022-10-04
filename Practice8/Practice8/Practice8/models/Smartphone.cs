using System;
using System.Collections.Generic;


namespace Practice8.models
{
    class Smartphone : MobilePhoneWithColorScreen
    {
        public bool TouchControl { get; set; }
        public int NumberOfTouches { get; set; }
        public List<Camera> NumberOfCameras { get; set; }

        public Smartphone(long number, string screenResolution, double physicalScreenSize, string colorOfDevice, int numberOfColors, bool havingTwoSimCards, 
            bool touchControl, int numberOfTouches, List<Camera> numberOfCameras) 
            : base(number, screenResolution, physicalScreenSize, colorOfDevice, numberOfColors, havingTwoSimCards)
        {
            this.TouchControl = touchControl;
            this.NumberOfTouches = numberOfTouches;
            this.NumberOfCameras = numberOfCameras;
        }

        public Smartphone(long number, string screenResolution, double physicalScreenSize, string colorOfDevice, int numberOfColors, bool havingTwoSimCards, long secondNumber,
            bool touchControl, int numberOfTouches, List<Camera> numberOfCameras) 
            : base(number, screenResolution, physicalScreenSize, colorOfDevice, numberOfColors, havingTwoSimCards, secondNumber)
        {
            this.TouchControl = touchControl;
            this.NumberOfTouches = numberOfTouches;
            this.NumberOfCameras = numberOfCameras;
        }

        //private Smartphone(bool touchControl, int numberOfTouches, List<Camera> numberOfCameras)
        //{
        //    this.TouchControl = touchControl;
        //    this.NumberOfTouches = numberOfTouches;
        //    this.NumberOfCameras = numberOfCameras;
        //}


        public override void AcceptCall()
        {
            NumberSelection("What number would you like to receive a call from?");
            Console.WriteLine("Accept call from Smartphone!");
        }

        public override void Call()
        {
            NumberSelection("What number do you want to call from?");
            Console.WriteLine("Call from Smartphone!");
        }

        public override void Characteristics()
        {
            base.Characteristics();
            Console.WriteLine("Touch Control: " + this.TouchControl + 
                "\nNumber of Toucher: " + this.NumberOfTouches + 
                "\nNumber of Cameras: " + this.NumberOfCameras.Count);
        }

        public void MakePhoto()
        {
            int cameraNumber;
            if (this.NumberOfCameras.Count > 1)
            {
                cameraNumber = ChooseFromWhichCamera();
            }
            else
            {
                cameraNumber = 0;
            }

            Console.WriteLine("Photo taken with this " + this.NumberOfCameras[cameraNumber]);

        }

        public void RecordVideo()
        {
            int cameraNumber;
            if (this.NumberOfCameras.Count > 1)
            {
                cameraNumber = ChooseFromWhichCamera();
            }
            else
            {
                cameraNumber = 0;
            }

            Console.WriteLine("Video taken from this " + this.NumberOfCameras[cameraNumber]);
        }

        protected int  ChooseFromWhichCamera()
        {
            Console.WriteLine("Choose from which camera you want to take a photo?(Countdown from 1)");
            views.View.PrintListInAСolumn(this.NumberOfCameras);

            return int.Parse(Console.ReadLine()) - 1;
        }



    }
}
