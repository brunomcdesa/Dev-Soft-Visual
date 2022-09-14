using System.ComponentModel.DataAnnotations;

namespace Contas_de_Jogo.Model
{
    public class KDA
    {
        /*
         * JSon enviado
         {
            "Id": 1,
            "Nickname": "Gelad0",
            "Kill": 15,
            "Death": 25,
            "Assists": 3
         }
         
         */
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage = "Nickname is required, please insert that")]
        public string Nickname { get; set; }
        [Required (ErrorMessage = "Amount of kill is required, please insert that")]
        public int Kill { get; set; }
        [Required (ErrorMessage = "Amount of death is required, please insert that")]
        public int Death { get; set; }
        [Required (ErrorMessage = "Amount of assists is required, pleas inssert that")]
        public int Assists { get; set; }

        public KDA() { }
        public KDA(string nickname, int kill, int death, int assists) {
            this.Nickname = nickname;
            this.Kill = kill;
            this.Death = death;
            this.Assists = assists;
        }
    }
}
