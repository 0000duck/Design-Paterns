namespace Main.Behavioral_Patterns.Memento_Pattern
{
    /// <summary>
    /// Responsible for keeping that memento.
    /// </summary>
    public class SupplierMemory
    {
        private FoodSupplierMemento _memento;

        public FoodSupplierMemento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}
