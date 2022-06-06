using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Models
{
    public class vegetableDetails
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VegetableID { get; set; }
        public string VegetableName { get; set; }
        public int VegetablePrice { get; set; }
       
        
        public string VegetableImage { get; set; }


    }
}
