using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC
{
    public class CarRepository
    {
        public Car Retrieve(int carID)
        {
            Car car = new Car(carID);
            //return new Car();

            if (carID == 2)
            {
                car.Manufacture = "Skoda";
                car.Model = "Fabia";
                car.PricePerDay = 15.2M;
            }
            return car;
        }

        public bool Save(Car car)
        {
            return true;
        }
    }
}
