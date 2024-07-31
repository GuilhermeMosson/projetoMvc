using Microsoft.AspNetCore.Mvc;
using projetoMvc.Models;

namespace projetoMvc.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            var user = new Users
            {
                IdUser = 1,
                NomeUser = "Roberto Neto",
                EmailUser = "neto_Roberto@gmail.com.br"
        };
            return View(user);
        }
    }
}
