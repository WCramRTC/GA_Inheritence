using System.Numerics;

namespace GA_Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance

            //// Car
            //Transportation car = new Transportation("Hyundai", "Sonata", 4, "4 Cylinder", "None");

            //// Plane
            //Transportation plane = new Transportation("Boeing", "747", 3, "Twin Engine", "None");

            //// Boat
            //Transportation boat = new Transportation("Sail", "Boat", 0, "None", "Sail");

            Car myNewCar = new Car("Honda","Civic", 2012);

            Transportation myNewTransportation = new Transportation("Some", "Vehicle", 2000);

            Air myNewPlane = new Air("Boeing", "747", 2020, "Twin Engine");

            Water myNewBoat = new Water("Sail", "Boat", 2019, "Sail");

            Helicopter myNewHelicopter = new Helicopter("Heli", "Copter", 2020, "800hp", 8);
            

        } // main

    } // class
     
} // namespace
