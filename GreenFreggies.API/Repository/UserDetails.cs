using GreenFreggies.API.Data;
using GreenFreggies.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Repository
{
    public class UserDetails : IUserDetails
    {
        private VegetablesDbContext _vegetablesDb;
        public UserDetails(VegetablesDbContext vegetablesDb)
        {
            _vegetablesDb = vegetablesDb;
        }

        public string DeleteUserDetails(int UserId)
    {
            string msg = "";
            userDetails deleteUser = _vegetablesDb.userDetails.Find(UserId);//storing the details of the vegetable in the obj 
            if (deleteUser != null)
            {
                _vegetablesDb.userDetails.Remove(deleteUser);
                _vegetablesDb.SaveChanges();
                msg = "Deleted";
            }
            return msg;
        }

       

        public List<userDetails> GetAllUserDetails()
        {
            List<userDetails> user = _vegetablesDb.userDetails.ToList();
            return user;
        }


        public userDetails GetUserDetails(int UserId)
        {
            userDetails user = _vegetablesDb.userDetails.Find(UserId);
            return user;
        }

        
        public string SaveUserDetails(userDetails userDetails)
        {
            _vegetablesDb.userDetails.Add(userDetails);
            _vegetablesDb.SaveChanges();
            return "Saved";
        }

       
        public string UpdateUserDetails(userDetails userDetails)
        {
            _vegetablesDb.Entry(userDetails).State = EntityState.Modified;
            _vegetablesDb.SaveChanges();
            return "Updated";
        }
    }
}
