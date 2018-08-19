namespace Main.Behavioral_Patterns.Command_Pattern
{
    public class Light
    {
        public bool isLightOn = false;
        public void TurnOn()
        {
            isLightOn = true;
        }

        public void TurnOff()
        {
            isLightOn = false;
        }
    }
}
