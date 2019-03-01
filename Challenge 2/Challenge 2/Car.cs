using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Car
    {
        List<string> passengers = new List<string>();
        int speed;

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 0)
                {
                    speed = value;
                }
            }
        }

        public Car(string driver)
        {
            passengers.Add(driver);
            Console.WriteLine("{0} is the driver of a new car", driver);
            speed = 0;
        }

        public void AddPassenger(string passenger)
        {
            passengers.Add(passenger);
            Console.WriteLine("{0} gets into the car", passenger);
        }

        public void RemovePassenger(string passenger)
        {
            passengers.Remove(passenger);
            Console.WriteLine("{0} gets out of the car", passenger);
        }
    }
}
