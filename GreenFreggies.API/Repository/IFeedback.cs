using GreenFreggies.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Repository
{
   public interface IFeedback
    {
        public string SaveFeedDetails(feedback feedback);
        feedback GetFeedDetails(int UserId);
        List<feedback> GetAllFeedDetails();
    }
}
