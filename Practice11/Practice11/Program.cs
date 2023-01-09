using Practice11.controllers;
using Practice11.models;
using System;

namespace Practice11
{
    class Program
    {
        delegate void MyDelegate(Visitor visitor);
        static void Main(string[] args)
        {
            Visitor v = new Visitor();
            Console.WriteLine(v);
       
            MyDelegate myDelegates = new(AmusementPark.RideARollerCoaster);
            myDelegates += AmusementPark.ShotingInTheShootingRange;
            myDelegates += AmusementPark.VisitRoomOfFear;
            myDelegates += AmusementPark.VisitRoomOfCrookedMirrors;
            myDelegates += AmusementPark.BuyPopcorn;
            myDelegates += AmusementPark.VisitFerrisWheel;

            myDelegates(v);
            Console.WriteLine(v);

        }
    }
}
