using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Structural_Patterns.Adapter
{
    public class Socket : ISocket
    {
        public int GetVolt()
        {
            return 120;
        }
    }
}
