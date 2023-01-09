using System;
using System.Collections.Generic;
using System.Text;

namespace Practice11.models
{
    class Visitor
    {
        public bool RollerCoaster { get; set; } = false;
        public bool ShootingRange { get; set; } = false;
        public bool RoomOfFear { get; set; } = false;
        public bool RoomOfCrookedMirrors { get; set; } = false;
        public bool EatPopcorn { get; set; } = false;
        public bool FerrisWheel { get; set; } = false;

        public override string ToString()
        {
            return $"Roller Coaster -- {RollerCoaster}\n" +
                   $"Shooting Range -- {ShootingRange}\n" +
                   $"Room Of Fear -- {RoomOfFear}\n" +
                   $"Room Of Crooked Mirrors -- {RoomOfCrookedMirrors}\n" +
                   $"Eat Popcorn -- {EatPopcorn}\n" +
                   $"Ferris Wheel -- {FerrisWheel}\n";
        }

    }
}
