using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.Mediator_Pattern
{
    public interface IMediator
    {
        void AddUser(IUser user);
        void SendMessage(string message, IUser sender);
    }
}
