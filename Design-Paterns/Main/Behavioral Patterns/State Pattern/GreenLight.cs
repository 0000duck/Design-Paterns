namespace Main.Behavioral_Patterns.State_Pattern
{
    public class GreenLight : ITrafficLight
    {
        public void Change(TrafficLight light)
        {
            light.State = new YellowLight();
        }

        public Lights ReportState()
        {
            return Lights.Green;
        }
    }
}
