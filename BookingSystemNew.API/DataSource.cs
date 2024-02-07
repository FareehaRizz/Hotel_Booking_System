using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingSystemNew.Domain.ModelsOfDomLayer;
namespace BookingSystemNew.API
{
    public class DataSource
    {
        public DataSource()
        {
            Hotels = GetHotels();

        }
        public List<Hotel> Hotels { get; set; }
        public List<Hotel> GetHotels()
        {
            return new List<Hotel>
            {
                new Hotel
                {
                    HotelID = 1,
                    HotelName = "Serena Hotel",
                    HotelStars = 4,
                    HotelAddress = "Khayaban-e-Suhrwardy Rd, opposite Convention Centre, G-5/1 G-5",
                    HotelCity = "Islamabad",
                    HotelCountry = "Pakistan",
                    HotelDescription = "Luxe hotel with a spa and a rooftop lounge"

                },
                new Hotel
                {
                    HotelID = 2,
                    HotelName = "Pearl Continental",
                    HotelStars = 5,
                    HotelAddress = "Club Rd، opposite PIDC, Civil Lines",
                    HotelCity = "Karachi",
                    HotelCountry = "Pakistan",
                    HotelDescription = "A prestigious 5-star hotel located in the vibrant city of Karachi, Pakistan"



                }
            };


        }
    }
}
