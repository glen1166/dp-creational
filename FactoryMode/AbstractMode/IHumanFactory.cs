using System;

namespace AbstractMode{
    public interface IHumanFactory{
        IHuman createYellowHuman();

        IHuman createBlackHuman();

        IHuman createWhiteHuman();
    } 
}