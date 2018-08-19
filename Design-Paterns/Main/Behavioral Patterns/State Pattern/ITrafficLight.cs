namespace Main.Behavioral_Patterns.State_Pattern
{
    public interface ITrafficLight
    {
        void Change(TrafficLight light);
        Lights ReportState();
    }
}
