using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemNew.Domain.ModelsOfDomLayer
{
    public class Hotel
        
    {
        //building a constructor
       /* public Hotel(string name, int stars, string address) {
            if (string.IsNullOrWhiteSpace(name)) {
                throw new ArgumentException("This Hotel Name is not allowed to nullor whitespace!!!");
            }
        }*/
        //i am  making different functions to get and set different type of info in our hotel class
        public int HotelID { get; set; }
        public string HotelName { get; set; }
        public int HotelStars { get; set; }
        public string HotelAddress{get; set;}

        public string HotelCity { get; set;}

        public string HotelCountry { get; set;}

        //making a list of all the rooms in the hotel
        public List<Rooms> rooms { get; set; }

        //making another function for the hotel description
        public string HotelDescription { get; set; }

    }
}
