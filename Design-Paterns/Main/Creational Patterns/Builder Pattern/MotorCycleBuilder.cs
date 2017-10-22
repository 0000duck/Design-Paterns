using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Creational_Patterns.Builder_Pattern
{
    public class MotorCycleBuilder : IVehicleBuilder
    {
        Vehicle _vehicle = new Vehicle();

        public Vehicle GetVehicle()
        {
            return _vehicle;
        }

        public void SetBody()
        {
            _vehicle.Body = "Small bike";
        }

        public void SetEngine()
        {
            _vehicle.Engine = "200cc";
        }

        public void SetModel()
        {
            _vehicle.Model = "Suzuki";
        }

        public void SetTransmission()
        {
            _vehicle.Transmission = "Mechanic";
        }
    }
}
