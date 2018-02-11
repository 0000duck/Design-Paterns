using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.Command_Pattern
{
    public class Light
    {
        public bool isLightOn = false;
        public void TurnOn()
        {
            isLightOn = true;
        }

        public void TurnOff()
        {
            isLightOn = false;
        }
    }
}
