using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.Command_Pattern
{
    public class Switch
    {
        public void StoreAndExecute(ICommand command)
        {
            command.Execute();
        }
    }
}
