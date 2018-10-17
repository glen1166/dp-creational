using System;

namespace AbstractMode
{
    public class MaleYellowHuman : AbstractYellowHuman
    {
        public override void getSex()
        {
            Console.WriteLine("male");
        }
    }
}