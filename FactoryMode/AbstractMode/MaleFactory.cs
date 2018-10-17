using System;

namespace AbstractMode
{
    public class MaleFactory : IHumanFactory
    {
        public IHuman createYellowHuman()
        {
            return new MaleYellowHuman();
        }

        public IHuman createBlackHuman()
        {
            return new MaleBlackHuman();
        }

        public IHuman createWhiteHuman()
        {
            return new MaleWhiteHuman();
        }
    }
}