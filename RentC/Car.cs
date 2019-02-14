using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC
{
    public class Car : Reservation
    {
        public Car()
        {

        }

        public Car(int carID)
        {
            this.CarID = CarID;
        }

        public int CarID { get; private set; }
        public string Plate { get; private set; }
        public string Manufacture { get; set; }
        public string Model { get; set; }
        public decimal PricePerDay { get; set; }

        public Car Retrieve (int carID)
        {
            return new Car();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Plate)
                || string.IsNullOrWhiteSpace(Manufacture)
                || string.IsNullOrWhiteSpace(Model)
                || PricePerDay == null)
                isValid = false;

            return isValid;
        }


    }
}
