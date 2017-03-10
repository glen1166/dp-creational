//using FactoryMode.GeneralMode;
using FactoryMode.SimpleMode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMode
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = CarFactory.CreateCar("BMW");
            car.Run();

            car = CarFactory.CreateCar("Benz");
            car.Run();
        }
    }
}
