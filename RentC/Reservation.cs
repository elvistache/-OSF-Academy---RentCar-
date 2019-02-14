using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC
{
    public class Reservation
    {
        public Reservation()
        {

        }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public DateTimeOffset? ReservDate { get; set; }
        
        

    }
}
