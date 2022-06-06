using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Models
{
    public class Transaction
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }
        public decimal TransactionAmount { get; set;}
        public DateTime TransactionDate { get; set; }
        public string TransactionStatus { get; set; }
        [ForeignKey("userDetails")]
        public int UserId { get; set; }
        [ForeignKey("cart")]
        public int CartId { get; set; }

    }
}
