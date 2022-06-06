using GreenFreggies.API.Models;
using GreenFreggies.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VegetableController : Controller
    {
        private VegetableServices _vegetableServices;
        public VegetableController(VegetableServices vegetableServices)
        {
            _vegetableServices=vegetableServices;
        }
        [HttpPost("SaveVegetable")]
        public IActionResult SaveVegetable(vegetableDetails vegetableDetails)
        {
            return Ok(_vegetableServices.SaveVegetable(vegetableDetails));
        }

        [HttpDelete("DeleteVegetable")]
        public IActionResult DeleteVegetable(int VegetableID)
        {
            return Ok(_vegetableServices.DeleteVegetable(VegetableID));
        }

        [HttpPut("UpdateVegetable")]
        public IActionResult UpdateVegetable(vegetableDetails vegetableDetails)
        {
            return Ok(_vegetableServices.UpdateVegetable(vegetableDetails));
        }

        [HttpGet("GetVegetable")]
        public IActionResult GetVegetable(int VegetableID)
        {
            return Ok(_vegetableServices.GetVegetable(VegetableID));
        }

        [HttpGet("GetAllVegetables()")]
        public List<vegetableDetails> GetAllVegetables()
        {
            return _vegetableServices.GetAllVegetables();
        }
    }
}
