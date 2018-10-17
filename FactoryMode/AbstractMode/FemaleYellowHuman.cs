using System;

namespace AbstractMode
{
    public class FemaleYellowHuman : AbstractYellowHuman
    {
        public override void getSex()
        {
            Console.WriteLine("female");
        }
    }
}