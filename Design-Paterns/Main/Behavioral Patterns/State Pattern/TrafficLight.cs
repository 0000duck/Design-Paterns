namespace Main.Behavioral_Patterns.State_Pattern
{
    public class TrafficLight
    {
        public ITrafficLight State { get; set; }

        public void Change()
        {
            State.Change(this);
        }

        public Lights ReportState()
        {
            return State.ReportState();
        }
    }
}
