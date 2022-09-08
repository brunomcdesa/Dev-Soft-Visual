using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula6.Controllers
{
    [ApiController]
    [Route("controller")]
    public class CardController : ControllerBase
    {
        List<Card> cards = new List<Card>();

        [HttpPost]
        public void AddCard([FromBody] Card card)
        {
            cards.Add(card);
        }


        [HttpGet]
        public IActionResult getCards()
        {
            return Ok(cards);
        }





    }
}
