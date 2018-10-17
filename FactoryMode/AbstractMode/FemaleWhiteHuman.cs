using System;

namespace AbstractMode
{
    public class FemaleWhiteHuman : AbstractWhiteHuman
    {
        public override void getSex()
        {
            Console.WriteLine("female");
        }
    }
}