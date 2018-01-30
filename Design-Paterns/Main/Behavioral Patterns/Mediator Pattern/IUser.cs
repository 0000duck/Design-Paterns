using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.Mediator_Pattern
{
    public interface IUser
    {
        string Message { get; set; }
        string Name { get; set; }

        void SendMessage(string message);
        void ReceiveMessage(string message);
    }
}
