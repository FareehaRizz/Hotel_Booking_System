using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingSystemNew.Domain.ModelsOfDomLayer;  // Import the Hotel class namespace

namespace BookingSystemNew.Domain.ValidationRules
{
    public class HotelValidation
    {
        // This property is made to denote all the business rules of our application
        public bool IsHotelValid ( Hotel hotel)
        {
            return true;
        }
    

          

       /* public HotelValidation(Hotel ht)
        {
            // Your validation logic goes here
            // For example, you can set IsHotelValid based on some conditions
            IsHotelValid = ValidateHotel(ht);
        }

        private bool ValidateHotel(Hotel ht)
        {
            // Your validation logic for the hotel goes here
            // Return true or false based on the validation result
            return true;
        }*/
    }
}

