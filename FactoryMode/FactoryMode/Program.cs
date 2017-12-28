using FactoryMode.SimpleMode;

namespace FactoryMode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICar car = CarFactory.CreateCar("BMW");
            car.Run();

            car = CarFactory.CreateCar("Benz");
            car.Run();
        }
    }
}
