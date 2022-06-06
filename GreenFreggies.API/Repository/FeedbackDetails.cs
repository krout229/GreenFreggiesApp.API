using GreenFreggies.API.Data;
using GreenFreggies.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Repository
{
    public class FeedbackDetails : IFeedback
    {
        private VegetablesDbContext _vegetablesDb;
        public FeedbackDetails(VegetablesDbContext vegetablesDbContext)
        {
            _vegetablesDb = vegetablesDbContext;

        }
        public List<feedback> GetAllFeedDetails()
        {
            List<feedback> feed = _vegetablesDb.feedback.ToList();
            return feed;
        }

        public feedback GetFeedDetails(int UserId)
        {
            feedback feed = _vegetablesDb.feedback.Find(UserId);
            return feed;
        }

        public string SaveFeedDetails(feedback feedback)
        {
            _vegetablesDb.feedback.Add(feedback);
            _vegetablesDb.SaveChanges();
            return "Saved";
        }
    }
}
