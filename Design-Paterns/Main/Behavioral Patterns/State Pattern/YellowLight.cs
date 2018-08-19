namespace Main.Behavioral_Patterns.State_Pattern
{
    public class YellowLight : ITrafficLight
    {
        public void Change(TrafficLight light)
        {
            light.State = new RedLight();
        }

        public Lights ReportState()
        {
            return Lights.Yellow;
        }
    }
}
