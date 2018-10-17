using System;

namespace AbstractMode
{
    public abstract class AbstractYellowHuman : IHuman
    {

        public virtual void talk()
        {
            Console.WriteLine("yellow talking...");
        }

        public virtual void getColor()
        {
            Console.WriteLine("yellow");
        }

        public abstract void getSex();
    }
}