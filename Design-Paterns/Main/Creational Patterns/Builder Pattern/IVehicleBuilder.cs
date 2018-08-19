namespace Main.Creational_Patterns.Builder_Pattern
{
    public interface IVehicleBuilder
    {
        void SetModel();
        void SetEngine();
        void SetTransmission();
        void SetBody();
        Vehicle GetVehicle();
    }
}
