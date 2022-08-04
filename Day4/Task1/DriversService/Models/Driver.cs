using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriversService.Models
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public int PhoneNumber { get; set; }
    }
}
