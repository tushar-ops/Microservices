using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DriversService.Models;


namespace DriversService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        static List<Driver> driverList = new List<Driver>()
        {
            new Driver(){DriverId=1,Name="Ashsih",Gender="Female",Location="Pune",PhoneNumber=111111},
            new Driver(){DriverId=2,Name="Tushar",Gender="Female",Location="Mumbai",PhoneNumber=222222},
            new Driver(){DriverId=3,Name="Sumit",Gender="Male",Location="Bangalore",PhoneNumber=333333}
        };
        
        [HttpGet]
        public List<Driver> Get()
        {
            return driverList;
        }

        [HttpGet("{id}")]
        public Driver Get(int id)
        {
            Driver obj = driverList.Find(item => item.DriverId == id);
            return obj;
        }

        [HttpPost]
        public List<Driver> Post([FromBody] Driver obj)
        {
            driverList.Add(obj);
            return driverList;
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Driver newObj)
        {
            Driver oldObj = driverList.Find(item => item.DriverId == id);
            if (oldObj != null)
            {
                driverList.Insert(id-1, newObj);
                driverList.Remove(oldObj);
                return Ok();
            }
            return NotFound("Failed : No such Driver Exists");

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Driver obj = driverList.Find(item => item.DriverId == id);
            if (obj != null)
            {
                driverList.Remove(obj);
                return Ok();
            }
            return NotFound("Failed : No such Driver Exists");
        }
    }
}
