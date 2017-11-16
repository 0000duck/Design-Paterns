using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Creational_Patterns.Abstract_Factory_Pattern
{
    public class HondaFactory : IVehicleFactory
    {
        public IBike GetBike(VehicleType type)
        {
            switch (type)
            {
                case VehicleType.Sports:
                    return new SportsBike();
                case VehicleType.Regular:
                    return new RegularBike();
                default:
                    throw new ApplicationException();
            }
        }

        public IScooter GetScooter(VehicleType scooterType)
        {
            switch (scooterType)
            {
                case VehicleType.Sports:
                    return new Scooty();
                case VehicleType.Regular:
                    return new RegularScooter();
                default:
                    throw new ApplicationException();
            }
        }
    }
}
