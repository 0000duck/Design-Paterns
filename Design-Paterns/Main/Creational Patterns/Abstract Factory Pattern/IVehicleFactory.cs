namespace Main.Creational_Patterns.Abstract_Factory_Pattern
{

    public interface IVehicleFactory
    {
        IBike GetBike(VehicleType bikeType);
        IScooter GetScooter(VehicleType scooterType);
    }
}
