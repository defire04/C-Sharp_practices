using Practice11.models;

namespace Practice11.controllers
{
    class AmusementPark
    {
        public static void RideARollerCoaster(Visitor visitor) => visitor.RollerCoaster = true;
        public static void ShotingInTheShootingRange(Visitor visitor) => visitor.ShootingRange = true;
        public static void VisitRoomOfFear(Visitor visitor) => visitor.RoomOfFear = true;
        public static void VisitRoomOfCrookedMirrors(Visitor visitor) => visitor.RoomOfCrookedMirrors = true;
        public static void BuyPopcorn(Visitor visitor) => visitor.EatPopcorn = true;
        public static void VisitFerrisWheel(Visitor visitor) => visitor.FerrisWheel = true;

    }
}
