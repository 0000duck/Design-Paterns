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
