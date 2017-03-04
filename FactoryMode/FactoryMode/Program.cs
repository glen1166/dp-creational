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
            CarFactory factory = new CarFactory();
            ICar car = factory.CreateCar("BMW");
            car.Run();

            car = factory.CreateCar("Benz");
            car.Run();
        }
    }
}
