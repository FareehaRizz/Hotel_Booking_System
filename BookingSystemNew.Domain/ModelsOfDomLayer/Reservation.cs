using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemNew.Domain.ModelsOfDomLayer
{
    public class Reservation
    {
        public int ReservationID { get; set; }

        //since reservation will be for the rooms so
        public Rooms Rooms { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Customer { get; set; }
    }
}
