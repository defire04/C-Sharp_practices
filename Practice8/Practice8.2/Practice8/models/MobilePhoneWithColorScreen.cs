using Practice8.interfaces;
using System;


namespace Practice8.models
{
    class MobilePhoneWithColorScreen : MobilePhoneWithBlackScreen, IMms
    {
        public int NumberOfColors { get; set; }
        public bool HavingTwoSimCards { get; set; }
        public long SecondNumber { get; set; }


        public MobilePhoneWithColorScreen(long number, string screenResolution, double physicalScreenSize, string colorOfDevice,
            int numberOfColors, bool havingTwoSimCards)
          : base(number, screenResolution, physicalScreenSize, colorOfDevice)
        {
            this.NumberOfColors = numberOfColors;
            this.HavingTwoSimCards = havingTwoSimCards;
           
        }

        public MobilePhoneWithColorScreen(long number, string screenResolution, double physicalScreenSize, string colorOfDevice,
           int numberOfColors, bool havingTwoSimCards, long secondNumber)
            : this(number, screenResolution, physicalScreenSize, colorOfDevice, numberOfColors, havingTwoSimCards)
        {
            this.SecondNumber = secondNumber;
        }

        public override void AcceptCall()
        {
            NumberSelection("What number would you like to receive a call from?");
            Console.WriteLine("Accept call from Phone With Color Screen!");
        }

        public override void Call()
        {
            NumberSelection("What number do you want to call from?");
            Console.WriteLine("Call from Phone With Color Screen!");
        }

        public override void Characteristics()
        {
            base.Characteristics();
            Console.WriteLine("Number Of Colors: " + this.NumberOfColors
                + "\nHaving Two SimCards: " + this.HavingTwoSimCards);
            if (HavingTwoSimCards)
            {
                Console.WriteLine("Second Number: " + this.SecondNumber);
            }
        }

        public new string SendMessage()
        {
            Console.Write("Enter the text of the message you want to send: ");
            string message = Console.ReadLine();

            NumberSelection("From which number do you want to send a message?");
            Console.WriteLine("Send message with text: " + message);

            return message;
        }

        public new void AcceptMessage(string message, Person sender)
        {
            NumberSelection("From which number do you want to receive a message?");
            Console.WriteLine("Message received from {0}: " + message, sender.Name);
        }

        protected void NumberSelection(string choiceForWhat)
        {
            string userResponse;
            if (this.HavingTwoSimCards)
            {
                do
                {
                    Console.WriteLine(choiceForWhat + "\n1) " + this.Number + "\n2) " + this.SecondNumber);
                    userResponse = Console.ReadLine();

                    if (userResponse.Equals("1"))
                    {
                        Console.WriteLine("From the first phone number.");
                        break;
                    }
                    else if (userResponse.Equals("2"))
                    {
                        Console.WriteLine("From the second phone number.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                } while (true);
             
            }
        }

        public string SendMms()
        {
            Console.WriteLine("Choose an image to send");
            string pictureTitle = Console.ReadLine();

            NumberSelection("From which number do you want to send a MMS?");
            Console.WriteLine("Image titled '{0}' sent", pictureTitle);
         
            return pictureTitle;
        }

        public void AcceptMms(string mms, Person sender)
        {
            NumberSelection("From which number do you want to receive a MMS?");
            Console.WriteLine("MMS received from {0}: " + mms, sender.Name);
        }
    }
}
