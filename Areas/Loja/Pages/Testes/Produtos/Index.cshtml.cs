using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdasPet.Data;
using AdasPet.Models;
using AdasPet.Areas.Loja.Pages.Carrinho;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace AdasPet.Areas.Loja.Pages.Testes.Produtos
{
    public class IndexModel : PageModel
    {
        private readonly AdasPet.Data.ApplicationDbContext _context;

        public IndexModel(AdasPet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get; set; } = new List<Produto>();
        public void OnGet()
        {
            Produto =  _context.Produto.ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Pega o corpo do requerimento mandado pela pagina
            var BodyForm = await HttpContext.Request.ReadFormAsync();
            // Extrai o id do produto desse corpo e adiciona ao carrinho
            CarrinhoOp.AdicionarItem(HttpContext.Session, new Guid(BodyForm["item.ID"]));
            // Retorna OK
            return Content("OK");
        }
    }
}
