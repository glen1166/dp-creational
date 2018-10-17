using System;
using FactoryMode.GeneralMode;
using AbstractMode;

namespace FactoryMode
{
    class Program
    {
        static void Main(string[] args)
        {
            // ICar car = CarFactory.CreateCar("BMW");
            // car.Run();

            // car = CarFactory.CreateCar("Benz");
            // car.Run();

            // AbstractCarFactory factory = new CarFactory();
            // ICar car = factory.CreateCar("BMW");
            // car.Run();

            IHumanFactory maleFactory = new MaleFactory();
            IHuman black = maleFactory.createBlackHuman();
            black.talk();
        }
    }
}
