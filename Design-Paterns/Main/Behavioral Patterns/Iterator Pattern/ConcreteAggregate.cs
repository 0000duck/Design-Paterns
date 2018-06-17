using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.Iterator_Pattern
{
    public class ConcreteAggregate : Aggregate
    {
        private ArrayList items = new ArrayList();

        public Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public object this[int index]
        {
            get { return items[index]; }
        }

        public int Count
        {
            get { return items.Count; }
        }

        public void Add(object o)
        {
            items.Add(o);
        }
    }
}
