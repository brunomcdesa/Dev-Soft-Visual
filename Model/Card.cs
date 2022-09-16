using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aula7.Model
{
   
    public class Card{
    
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="Number Card need be 16 chars! ")]
        [StringLength(16)]
        public string NumCard { get; set; }
        [Required(ErrorMessage ="Expire Date is required")]
        public DateTime ExpireDate { get; set; }
        [Required]
        public string CVV { get; set; }




    }
}
