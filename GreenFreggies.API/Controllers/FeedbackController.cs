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
    public class FeedbackController : Controller
    {
        private FeedbackService _FeedDetailsServices;
        public FeedbackController(FeedbackService feedbackService)
        {
            _FeedDetailsServices = feedbackService;
        }
        [HttpPost("SaveFeedDetails")]
        public IActionResult SaveFeedDetails(feedback feedback)
        {
            return Ok(_FeedDetailsServices.SaveFeedDetails(feedback));
        }
        [HttpGet("GetAllFeedDetails()")]
        public List<feedback> GetAllFeedDetails()
        {
            return _FeedDetailsServices.GetAllFeedDetails();
        }
    }
}