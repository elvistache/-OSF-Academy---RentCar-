using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC
{
    public class ReservationStatus : Reservation
    {
        public ReservationStatus()
        {

        }

        public ReservationStatus(int reservStatID)
        {
            this.ReservStatID = ReservStatID;
                
        }

        public int ReservStatID { get; private set; }
         
        public string Name { get; set; }
        public string Description { get; set; }

        


        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(Name))
                isValid = false;
            return isValid;
        }



    }
}
