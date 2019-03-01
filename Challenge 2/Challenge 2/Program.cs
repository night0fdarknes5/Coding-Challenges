using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string driverName = "Crash Test Dummy";

            Car car1 = new Car(driverName);

            car1.AddPassenger("Ted");

            car1.AddPassenger("Al");

            car1.RemovePassenger("Ted");

            car1.Speed = 60;

            Console.WriteLine("The cars speed is: " + car1.Speed.ToString() + "km/hr");

            Console.ReadKey();

        }
    }
}
