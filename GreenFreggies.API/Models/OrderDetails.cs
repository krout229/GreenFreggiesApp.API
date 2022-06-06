using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Models
{
    public class OrderDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public decimal OrderValue { get; set; }
        public string OrderItems { get; set; }
        [ForeignKey("cart")]
        public int CartId { get; set; }
        [ForeignKey("Transaction")]
        public int TransactionId { get; set; }
    }
}
