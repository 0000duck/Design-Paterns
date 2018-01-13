using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.State_Pattern
{
    public interface ITrafficLight
    {
        void Change(TrafficLight light);
        Lights ReportState();
    }
}
