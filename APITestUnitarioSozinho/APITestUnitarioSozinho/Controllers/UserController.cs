using APITestUnitarioSozinho.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APITestUnitarioSozinho.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : Controller
    {
        [HttpPost]
        public IActionResult Post(Users user)
        {
            if (user.Idade == 19)
                return Ok();

            return BadRequest();
        }
    }
}
