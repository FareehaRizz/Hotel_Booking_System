using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemNew.Domain.ModelsOfDomLayer
{
    public class Rooms
    {
        public int RoomID{get; set;}
        public int RoomNumber { get; set;}
        public double RoomSqFeet { get; set; }

        public bool NeedsRepair { get; set;}

    }
}
