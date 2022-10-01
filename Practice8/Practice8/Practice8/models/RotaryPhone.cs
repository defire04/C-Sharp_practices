using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice8.models
{
    class RotaryPhone : Phone
    {
        public List<string> Symbols { get; set; }


        public RotaryPhone(long number)
        {
            this.Number = number;
            this.Symbols = "0 1 2 3 4 5 6 7 8 9".Split(" ").ToList();
        }

   

        public override void AcceptCall()
        {
            Console.WriteLine("Accept call from Rotary Phone!");
        }

        public override void Call()
        {
            Console.WriteLine("Call from Rotary Phone!");
        }


        public override void Characteristics()
        {
            Console.WriteLine("Number: " + this.Number);
            Console.Write("Symbols : ");
            views.View.PrintList(this.Symbols);
        }


    }
}
