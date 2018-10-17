using System;
using FactoryMode.GeneralMode;

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

            AbstractCarFactory factory = new CarFactory();
            ICar car = factory.CreateCar("BMW");
            car.Run();
        }
    }
}
