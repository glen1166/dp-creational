using System;

namespace AbstractMode
{
    public class FemaleFactory : IHumanFactory
    {
        public IHuman createYellowHuman()
        {
            return new FemaleYellowHuman();
        }

        public IHuman createBlackHuman()
        {
            return new FemaleBlackHuman();
        }

        public IHuman createWhiteHuman()
        {
            return new FemaleWhiteHuman();
        }
    }
}