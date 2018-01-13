using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.State_Pattern
{
    public class YellowLight : ITrafficLight
    {
        public void Change(TrafficLight light)
        {
            light.State = new RedLight();
        }

        public Lights ReportState()
        {
            return Lights.Yellow;
        }
    }
}
