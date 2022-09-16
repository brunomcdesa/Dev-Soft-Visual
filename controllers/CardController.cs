using Aula7.Data;
using Aula7.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : Controller
    {
        private CardContext _context;

        public CardController(CardContext context) {
            _context = context;     
        }

        [HttpGet]
        //Enumerable por conta de ser uma busca geral
        public IEnumerable<Card> GetCards()
        {
            return _context.Cards; 
        }
     
    }
}
