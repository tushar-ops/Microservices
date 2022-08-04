using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassengersService.Models
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public int PhoneNumber { get; set; }
    }
}
