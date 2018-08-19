namespace Main.Behavioral_Patterns.Iterator_Pattern
{
    public interface Iterator
    {
        object Current { get; }
        bool Next();
    }
}
