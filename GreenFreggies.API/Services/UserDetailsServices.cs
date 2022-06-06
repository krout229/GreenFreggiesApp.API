using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenFreggies.API.Models;
using GreenFreggies.API.Repository;

namespace GreenFreggies.API.Services
{
    public class UserDetailsServices
    {
        private IUserDetails _userDetailsRepository;
        public UserDetailsServices(IUserDetails userDetailsRepository)
        {
            _userDetailsRepository = userDetailsRepository;
        }
        public string SaveUserDetails(userDetails userDetails)
        {
            return _userDetailsRepository.SaveUserDetails(userDetails);
        }
        public string DeleteUserDetails(int UserId)
        {
            return _userDetailsRepository.DeleteUserDetails(UserId);
        }
        public string UpdateUserDetails(userDetails userDetails)
        {
            return _userDetailsRepository.UpdateUserDetails(userDetails);
        }
        public userDetails GetUserDetails(int UserId)
        {
            return _userDetailsRepository.GetUserDetails(UserId);
        }
        public List<userDetails> GetAllUserDetails()
        {
            return _userDetailsRepository.GetAllUserDetails();
        }
    }
}
