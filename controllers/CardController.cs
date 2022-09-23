using CartoesAPI.Data;
using CartoesAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartoesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : Controller
    {
        private CardContext _context;

        public CardController(CardContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Card> GetCards()
        {
            return _context.Cards;
        }

        [HttpPost]
        public IActionResult addCard([FromBody] Card card)
        {
            _context.Cards.Add(card);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCardsById), new { Id = card.Id}, card);
        }

        [HttpGet("{id}")]
        public IActionResult GetCardsById(int id)
        {
            Card cartao = _context.Cards.FirstOrDefault(cartao => cartao.Id == id);
            if(cartao != null)
            {
                return Ok(cartao);
            }
            return NotFound();

        }
    }
}
