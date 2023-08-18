using System;
namespace DesignPatternsAndPrinciples.DesignPatterns.BehaviouralPatterns
{
	public class IteratorPattern
	{
		public void Run()
		{
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item1";
            a[1] = "Item2";
            a[2] = "Item3";
            a[3] = "Item4";
            a[4] = "Item5";

            Iterator i = a.CreateIterator();
            Console.WriteLine("Iterating over aggregate/ collection of Object");
            object item = i.First();
            while(item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
        }
	}

	public abstract class Iterator
	{
		public abstract object First();
		public abstract object Next();
		public abstract bool IsDone();
		public abstract object CurrentItem();
	}

    public abstract class Aggregate
	{
		public abstract Iterator CreateIterator();
	}

    public class ConcreteAggregate : Aggregate
    {
        List<object> items = new List<object>();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }

    public class ConcreteIterator : Iterator
    {
        ConcreteAggregate _aggregate;
        int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public override object CurrentItem()
        {
            return _aggregate[current];
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override bool IsDone()
        {
            return current >= _aggregate.Count;
        }

        public override object Next()
        {
            object ret = null;
            if(current < _aggregate.Count - 1)
            {
                ret = _aggregate[++current];
            }
            return ret;
        }
    }
}

