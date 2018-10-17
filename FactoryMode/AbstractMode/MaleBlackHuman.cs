using System;

namespace AbstractMode
{
    public class MaleBlackHuman : AbstractBlackHuman
    {
        public override void getSex()
        {
            Console.WriteLine("male");
        }
    }
}