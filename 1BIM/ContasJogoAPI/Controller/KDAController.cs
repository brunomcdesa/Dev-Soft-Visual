using Contas_de_Jogo.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Contas_de_Jogo.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class KDAController : ControllerBase
    {
      private static List<KDA> kdaList = new List<KDA>();

        //Pega todos os elementos da lista
        [HttpGet]
        public IActionResult GetKDA() {
            return Ok(kdaList);
        }

        //Adiciona elementos na lista
        [HttpPost]
        public void PostKDA([FromBody] KDA kda) { 
            kdaList.Add(kda);            
        }

        //Pegga um elemento especifico pelo ID
        [HttpGet("{id}")]
        public IActionResult GetKDAById(int kdaId)
        {
            KDA kda = kdaList.FirstOrDefault(kda => kda.Id == kdaId);
            if (kda != null)
            {
                return Ok(kda);
            }
            else
            {
                return NotFound();
            }
        }

        //Pegar um elemento pelo nickname
        [HttpGet("{nickname}")]
        public IActionResult GetKDAByNick(string nickname) {
            
            KDA kda = kdaList.FirstOrDefault(kda => kda.Nickname == nickname);
            if (kda != null)
            {
                return Ok(kda);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
