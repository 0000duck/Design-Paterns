using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Adapter
{
    public class Socket : ISocket
    {
        public int GetVolt()
        {
            return 120;
        }
    }
}
