using System;

namespace AbstractMode
{
    public abstract class AbstractWhiteHuman : IHuman
    {

        public virtual void talk()
        {
            Console.WriteLine("white talking...");
        }

        public virtual void getColor()
        {
            Console.WriteLine("white");
        }

        public abstract void getSex();
    }
}