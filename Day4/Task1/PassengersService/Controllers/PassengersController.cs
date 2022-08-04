using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PassengersService.Models;


namespace PassengersService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {
        static List<Passenger> passengerList = new List<Passenger>()
        {
            new Passenger(){PassengerId=1,Name="Pass1",Gender="Female",Location="Pune",PhoneNumber=111111},
            new Passenger(){PassengerId=2,Name="Pass2",Gender="Male",Location="Mumbai",PhoneNumber=222222},
            new Passenger(){PassengerId=3,Name="Pass3",Gender="Female",Location="Delhi",PhoneNumber=333333}
        };
        
        [HttpGet]
        public List<Passenger> Get()
        {
            return passengerList;
        }

        [HttpGet("{id}")]
        public Passenger Get(int id)
        {
            Passenger obj = passengerList.Find(item => item.PassengerId == id);
            return obj;
        }

        [HttpPost]
        public List<Passenger> Post([FromBody] Passenger obj)
        {
            passengerList.Add(obj);
            return passengerList;
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody] Passenger newObj)
        {
            Passenger oldObj = passengerList.Find(item => item.PassengerId == id);
            if (oldObj != null)
            {
                passengerList.Insert(id-1, newObj);
                passengerList.Remove(oldObj);
                return Ok();
            }
            return NotFound("Failed : No such Passenger Exists");
            
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Passenger obj = passengerList.Find(item => item.PassengerId == id);
            if(obj != null)
            {
                passengerList.Remove(obj);
                return Ok();
            }
            return NotFound("Failed : No such Passenger Exists");
        }
    }
}
