using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMode.GeneralMode
{
    public class BenzCar: ICar
    {
        public void Run()
        {
            Console.WriteLine("The Benz car is running now.");
        }
    }
}
