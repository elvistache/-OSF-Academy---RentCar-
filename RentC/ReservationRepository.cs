using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC
{
    public class ReservationRepository
    {
        public ReservationStatus Retrieve(int reservStatID)
        {
            ReservationStatus reservStat = new ReservationStatus(ReservStatID);

            if (reservStatID == 10)
                reservStat.ReservDate = new DateTime(2019, 2, 10, 12, 0, 0);

            return reservStat;
        }

        public bool Save()
        {
            return true;
        }
    }
}
