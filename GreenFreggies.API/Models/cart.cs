using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Models
{
    public class cart
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }
        public string VegetableName { get; set; }
        public int VegetablePrice { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("vegetableDetails")]
        public int VegetableId { get; set; }
        public decimal Total { get; set; }
    }
}
