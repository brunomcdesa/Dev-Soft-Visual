using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aula6

{
    public class Card
    {

        /*
         * {
         * "Id" : 1,
         * "CardNumber" : "66848684",
         * "ExpireDate" : 27/07,
         * "CVV" : "531",
         * "Flag" : "master"
         * }
         * 
         */


        //Required é colocado acima do atributo desejado. O que estiver abaixo da anotação vai ser required

        public int Id { get; set; }
        [Required (ErrorMessage = "Card Number is required!")]
        public string CardNumber { get; set; }
        [Required(ErrorMessage = "Expire Date is required!")]
        public DateTime ExpireDate { get; set; }
        [Required(ErrorMessage = "CVV is required!")]
        public string CVV { get; set; }
        public string Flag { get; set; }
        


        public Card() { }

    }
}
