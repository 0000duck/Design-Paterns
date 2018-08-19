namespace Main.Structural_Patterns.Adapter
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
