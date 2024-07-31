using Microsoft.AspNetCore.Mvc;
using projetoMvc.Models;

namespace projetoMvc.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            var produto = new Produto
            {
                Id = 1,
                Nome = "Xbox 360",
                Valor = 1699.99m,
                Proprietario = "Jorge dos Santos",
                Desc = "Melhor console de TODOS, sem dúvida",
                DataLancamento = new DateTime (2010, 03, 25, 16, 45, 21)
            };
            return View(produto);
        }
    }
}
