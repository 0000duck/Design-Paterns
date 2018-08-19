using System;

namespace Main.Creational_Patterns.Factory_Method_Pattern
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(VehicleType vehicle)
        {
            switch (vehicle)
            {
                case VehicleType.Bike:
                    return new Bike();
                case VehicleType.Scooter:
                    return new Scooter();
                default:
                    throw new ApplicationException();
            }
        }
    }
}
