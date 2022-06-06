using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Models
{
    public class userDetails
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
