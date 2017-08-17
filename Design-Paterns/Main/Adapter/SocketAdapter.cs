using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Adapter
{
    public class SocketAdapter : ISocketAdapter
    {
        private ISocket _socket;

        public SocketAdapter(ISocket socket)
        {
            _socket = socket;
        }

        public int Get12Volt()
        {
            return _socket.GetVolt() / 10;
        }
    }
}
