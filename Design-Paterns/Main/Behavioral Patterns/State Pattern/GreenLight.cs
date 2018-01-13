using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.State_Pattern
{
    public class GreenLight : ITrafficLight
    {
        public void Change(TrafficLight light)
        {
            light.State = new YellowLight();
        }

        public Lights ReportState()
        {
            return Lights.Green;
        }
    }
}
