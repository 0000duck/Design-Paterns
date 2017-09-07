using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Creational_Patterns.Builder_Patern
{
    public class CarBuilder : IVehicleBuilder
    {
        Vehicle _vehicle = new Vehicle();

        public Vehicle GetVehicle()
        {
            return _vehicle;
        }

        public void SetBody()
        {
            _vehicle.Body = "Small car";
        }

        public void SetEngine()
        {
            _vehicle.Engine = "1300cc";
        }

        public void SetModel()
        {
            _vehicle.Model = "Honda";
        }

        public void SetTransmission()
        {
            _vehicle.Transmission = "Automatic";
        }
    }
}
