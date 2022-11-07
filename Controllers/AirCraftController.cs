using AircraftAPI.Models;
using AircraftAPI.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace AircraftAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirCraftController : ControllerBase
    {
        private readonly AirCraftServices _aircraft;

        public AirCraftController(AirCraftServices airCraftServices)
        {
            _aircraft = airCraftServices;
        }
        
        [HttpGet("GetOne/{RAB} ", Name = "GetOneAirCraft")]
        public ActionResult<AirCraft> GetOneRAB(string rab)
        {
            var aircraft = _aircraft.GetOneRAB(rab);
            if (aircraft == null)
                return NotFound("Something went wrong in the request, not found!");

            return Ok(aircraft);

        }


    }
}
