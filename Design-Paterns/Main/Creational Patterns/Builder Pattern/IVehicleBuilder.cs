using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
