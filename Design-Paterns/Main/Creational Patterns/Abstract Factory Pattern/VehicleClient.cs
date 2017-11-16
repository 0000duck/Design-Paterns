using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Creational_Patterns.Abstract_Factory_Pattern
{
    public class VehicleClient
    {
        IBike bike;
        IScooter scooter;

        public VehicleClient(IVehicleFactory factory, VehicleType type)
        {
            bike = factory.GetBike(type);
            scooter = factory.GetScooter(type);
        }

        public string GetBikeName()
        {
            return bike.Name();
        }

        public string GetScooterName()
        {
            return scooter.Name();
        }
    }
}
