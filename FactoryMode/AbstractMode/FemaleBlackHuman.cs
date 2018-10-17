using System;

namespace AbstractMode
{
    public class FemaleBlackHuman : AbstractBlackHuman
    {
        public override void getSex()
        {
            Console.WriteLine("female");
        }
    }
}