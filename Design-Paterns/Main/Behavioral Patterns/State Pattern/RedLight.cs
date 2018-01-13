using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.State_Pattern
{
    public class RedLight : ITrafficLight
    {
        public void Change(TrafficLight light)
        {
            light.State = new GreenLight();
        }

        public Lights ReportState()
        {
            return Lights.Red;
        }
    }
}
