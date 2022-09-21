using Contas_de_Jogo.Data;
using Contas_de_Jogo.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Linq.Expressions;

namespace Contas_de_Jogo.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class KDAController : ControllerBase
    {
        private static List<KDA> kdaList = new List<KDA>();
        private AccountContext _context;

        public KDAController(AccountContext context)
        {
            _context = context;
        }
        /*
                //Pega todos os elementos da lista
                [HttpGet]
                public IEnumerable<KDA> GetKDA() {
                    return kdaList;
                }
        */

        //Pega todos os elemendos da tabela do banco de dados
        [HttpGet]
        public IEnumerable<KDA> GetKDAs() {
            return _context.KDAs;
        }
        /*
                //Adiciona elementos na lista
                [HttpPost]
                public void PostKDA([FromBody] KDA kda) { 
                    kdaList.Add(kda);            
                }
        */


        //Adiciona elementos na tabela do banco de dados
        [HttpPost]
        public IActionResult POSTKDA([FromBody] KDA kda)
        {
            _context.KDAs.Add(kda);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GETKDAById), new { Id = kda.Id }, kda);
        }
        /*
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
        */

        //Pega um elemento especifico pelo id na tabela do banco de dados
        [HttpGet("{id}")]
        public IActionResult GETKDAById(int id) 
        {
            KDA kda = _context.KDAs.FirstOrDefault(kda => kda.Id == id);
            if(kda != null)
            {
                return Ok(kda);
            }
           
                return NotFound();
            
        
        }

       
    }
}
