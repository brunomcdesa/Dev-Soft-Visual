using System.ComponentModel.DataAnnotations;

namespace Contas_de_Jogo.Model
{
    public class Account
    {
        /*
         * JSon enviado
         {
            "Id": 1,
            "Nickname": "Gelad0",
            "Rank": "Gold 3",
            "EntryDate": 12/06/2020
         }
         
         */
        public int Id { get; set; }

        [Required (ErrorMessage = "Nickmname is required, please insert that")]
        public string Nickname { get; set; }

        [Required (ErrorMessage = "Rank is required, please insert that")]
        public string Rank { get; set; }
        public DateTime EntryDate { get; set; }

        
        //Construtor com parametros que possuem o required
        public Account(string nickname, string rank) {
            this.Nickname = nickname;
            this.Rank = rank;
        }

    }
}
