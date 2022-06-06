using GreenFreggies.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Repository
{
   public interface IUserDetails
    {
        public string SaveUserDetails(userDetails userDetails);
        public string UpdateUserDetails(userDetails userDetails);
        public string DeleteUserDetails(int UserId);
        userDetails GetUserDetails(int UserId);
        List<userDetails> GetAllUserDetails();
    }
}
