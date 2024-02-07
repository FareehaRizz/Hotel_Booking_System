using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingSystemNew.Domain.ModelsOfDomLayer;
//using BookingSystemNew.API;
using Microsoft.AspNetCore.Http.HttpResults;

/*Below in the hotelControllers section my API uses many http verbs like get,put,post, delete 
 It alos takes id from the user whenever the http get request is called and whenever the hotel is updated by using http put*/

namespace BookingSystemNew.API.Controllers
//now we have to add the CRUD behaviour in our controllers for the hotel booking system
//CRUD: Create, Read, Update, Delete
{
    [ApiController]
    [Route("[controller]")]
    public class HotelController : Controller

    {
        private readonly DataSource _dataSource;
        public HotelController(DataSource dataSource) {
            _dataSource = dataSource;
        }

        [HttpGet]
        public IActionResult GetAllHotels()
        {
            var hotels = GetHotels();
            return Ok(hotels);
        }
        [HttpGet]
        //below from here i am adding the REST principles in my API
        //in order to get the correct response i have to add a route which will take to the id part in hotel class
        [Route("{id}")]
        //above id is written in curly braces because it is a placeholder since i cant hardcode the id coming from the user
        public IActionResult GetHotelById(int id) {
            var hotels = _dataSource.Hotels;
            var hotel = hotels.FirstOrDefault(h => h.HotelID == id);
            //here we use firstorDefault to specify the search format from the user to which our api will respond
            // the stuff in paranthesis represents the body of response presented to user
            if (hotel == null) {
                return NotFound();
            }
            return Ok(hotel);
        }
        [HttpPost]
        public IActionResult CreateHotel([FromBody] Hotel hotel) {
            var hotels = _dataSource.Hotels;
            hotels.Add(hotel);
            return CreatedAtAction(nameof(GetHotelById), new { hotel.HotelID }, hotel);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateHotel([FromBody] Hotel updated, int id) {
            var hotels = _dataSource.Hotels;
            var old = hotels.FirstOrDefault(h => h.HotelID == id);
            if (old == null) {
                return NotFound("No resource available for the corresponding hotel id"); }
            hotels.Remove(old);
            hotels.Add(updated);
            return NoContent();

        }
        private List<Hotel> GetHotels()
        {
            return new List<Hotel> {
            new Hotel{
            HotelID= 1,
            HotelName="Serena Hotel",
            HotelStars= 4,
            HotelAddress="Khayaban-e-Suhrwardy Rd, opposite Convention Centre, G-5/1 G-5",
            HotelCity="Islamabad",
            HotelCountry="Pakistan",
            HotelDescription="Luxe hotel with a spa and a rooftop lounge"

            },
            new Hotel {
                HotelID=2,
                HotelName="Pearl Continental",
                HotelStars=5,
                HotelAddress="Club Rd، opposite PIDC, Civil Lines",
                HotelCity="Karachi",
                HotelCountry="Pakistan",
                HotelDescription="A prestigious 5-star hotel located in the vibrant city of Karachi, Pakistan"



            }
            };
        }
            [HttpDelete]
            [Route("{id}")]
            
            public IActionResult Delete(int id) {
                //the hotels variable contains the data of all hotels in a readonly file type
                var hotels = _dataSource.Hotels;
                var toDelete = hotels.FirstOrDefault(h => h.HotelID == id);
                if (toDelete == null) {
                    return NotFound("No resource found for deletion for the provided id");
                }
                hotels.Remove(toDelete);
                return NoContent();
            }
        
    } }


