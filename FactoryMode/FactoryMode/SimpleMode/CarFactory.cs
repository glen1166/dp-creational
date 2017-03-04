using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMode.SimpleMode
{
    public class CarFactory : AbstractCarFactory
    {
        public override ICar CreateCar(string type)
        {
            ICar car = null;
            switch (type)
            {
                case "Benz":
                    car = new BenzCar();
                    break;
                case "BMW":
                    car = new BMWCar();
                    break;
                default:
                    break;
            }

            return car;
        }
    }
}
