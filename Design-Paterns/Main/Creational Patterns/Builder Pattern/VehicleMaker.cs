namespace Main.Creational_Patterns.Builder_Pattern
{
    public class VehicleMaker
    {
        private IVehicleBuilder _builder;

        public VehicleMaker(IVehicleBuilder builder)
        {
            _builder = builder;
        }

        public void BuildVehicle()
        {
            _builder.SetModel();
            _builder.SetEngine();
            _builder.SetTransmission();
            _builder.SetBody();
        }

        public Vehicle GetVehicle()
        {
            return _builder.GetVehicle();
        }
    }
}
