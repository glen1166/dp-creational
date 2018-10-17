using System;

namespace AbstractMode
{
    public abstract class AbstractBlackHuman : IHuman
    {

        public virtual void talk()
        {
            Console.WriteLine("black talking...");
        }

        public virtual void getColor()
        {
            Console.WriteLine("black");
        }

        public abstract void getSex();
    }
}