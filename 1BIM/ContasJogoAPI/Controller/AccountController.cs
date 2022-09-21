using Contas_de_Jogo.Data;
using Contas_de_Jogo.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace Contas_de_Jogo.Controllers
{

    [ApiController]
    [Route("{controller}")]
    public class AccountController : ControllerBase
    {
        private static List<Account> accounts = new List<Account>();
        private AccountContext _context;

        public AccountController(AccountContext context) {
            _context = context;
        }

/*
        //Adicionar uma conta a lista de contas SEM IR PARA O BANCO DE DADOS
        [HttpPost]
        public void PostAccount([FromBody] Account account) {
            accounts.Add(account);
        }
*/

        //Adicionar uma conta na lista DO BANCO DE DADOS
        [HttpPost]
        public IActionResult AddAccount([FromBody] Account conta) {

            _context.Accounts.Add(conta);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAccountByID), new { Id = conta.Id }, conta );

        }


/*
        //Pegar a lista toda SEM SER DO BANCO DE DADOS
        [HttpGet]
        public IActionResult GetAccount() {

            return Ok(accounts);
        }
*/
        //Pegar a lista toda DO BANCO DE DADOS
        [HttpGet]
          public IEnumerable<Account> GetAccounts()
          {
            return _context.Accounts;
         }

/*
        //Pegar um elemento da lista pelo Id SEM SER PELO BANDO DE DADOS
        [HttpGet("{id}")]
        public IActionResult GetAccountByID(int id)
        {
            Account account = accounts.FirstOrDefault(account => account.Id == id);
            if (account != null)
            {
                return Ok(account);
            }
            else
            {
                return NotFound();
            }
        }
*/

        //Pegar um elemento da lista pelo Id NO BANCO DE DADOS
        [HttpGet("{id}")]
         public IActionResult GetAccountByID(int id)
          {
          Account conta = _context.Accounts.FirstOrDefault(conta => conta.Id == id);
          if (conta != null)
          {
              return Ok(conta);
          }
          return NotFound();
        }



    } 
}

