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
    public class UserDetailsController : Controller
    {
        private UserDetailsServices _userDetailsServices;
        public UserDetailsController(UserDetailsServices userDetailsServices)
        {
            _userDetailsServices = userDetailsServices;
        }
        [HttpPost("SaveUserDetails")]
        public IActionResult SaveUserDetails(userDetails userDetails)
        {
            return Ok(_userDetailsServices.SaveUserDetails(userDetails));
        }

        [HttpPost("DeleteUserDetails")]
        public IActionResult DeleteUserDetails(int UserId)
        {
            return Ok(_userDetailsServices.DeleteUserDetails(UserId));
        }

        [HttpPost("UpdateUserDetails")]
        public IActionResult UpdateUserDetails(userDetails userDetails)
        {
            return Ok(_userDetailsServices.UpdateUserDetails(userDetails));
        }

        [HttpGet("GetUserDetails")]
        public IActionResult GetUserDetails(int UserId)
        {
            return Ok(_userDetailsServices.GetUserDetails(UserId));
        }

        [HttpGet("GetAllUserDetails()")]
        public List<userDetails> GetAllUserDetails()
        {
            return _userDetailsServices.GetAllUserDetails();
        }
    }
}
