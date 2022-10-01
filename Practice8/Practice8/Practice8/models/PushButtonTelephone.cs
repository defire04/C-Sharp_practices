using System;
using System.Collections.Generic;
using System.Text;

namespace Practice8.models
{
    class PushButtonTelephone : RotaryPhone
    {

        public PushButtonTelephone(long number)
             : base(number)
        {
            Symbols.Add("*");
            Symbols.Add("#");
        }

        public void ShowWhoCall(Person person)
        {
            Console.WriteLine("You are being called from this number: " + person.Phone.Number);
        }

        public override void AcceptCall()
        {
            Console.WriteLine("Accept call from Push-button Phone!");
        }

        public override void Call()
        {
            Console.WriteLine("Call from Push-button Phone!");
        }

    }

}
