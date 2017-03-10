using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMode.GeneralMode
{
    public class BMWCar : ICar
    {
        public void Run()
        {
            Console.WriteLine("The BMW car is running now.");
        }
    }
}
