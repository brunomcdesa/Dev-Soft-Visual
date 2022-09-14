using Contas_de_Jogo.Model;
using Microsoft.AspNetCore.Mvc;

namespace Contas_de_Jogo.Controllers
{

    [ApiController]
    [Route("controller")]
    public class AccountController : ControllerBase
    {
        private static List<Account> accounts = new List<Account>();

        //Adicionar uma conta a lista de contas
        [HttpPost]
        public void addAccount([FromBody] Account account) {
            accounts.Add(account);
        }

        //Pegar a lista toda
        [HttpGet]
        public IActionResult getAccount() {

            return Ok(accounts);
        }

        //Pegar um elemento da lista pelo Id
        [HttpGet("{id}")]
        public IActionResult getAccountByID(int id)
        {
            Account account = accounts.FirstOrDefault (account => account.Id == id);
            if (account != null)
            {
                return Ok(account);
            }
            else
            {
                return NotFound();
            }
        }

        //Pegar um elemento da lista pelo nickname
        [HttpGet("{nickname}")]
        public IActionResult getAccountByNickname(string nickname) {

            Account account = accounts.FirstOrDefault (account => account.Nickname == nickname);

            if (account != null)
            {
                return Ok(account);
            }
            else {
                return NotFound();
            }
        }
    }
}