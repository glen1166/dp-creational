using System;

namespace AbstractMode
{
    public class MaleWhiteHuman : AbstractWhiteHuman
    {
        public override void getSex()
        {
            Console.WriteLine("male");
        }
    }
}