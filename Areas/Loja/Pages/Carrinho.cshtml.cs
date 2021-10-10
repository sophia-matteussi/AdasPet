using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdasPet.Areas.Loja.Pages.Carrinho;
using AdasPet.Data;
using AdasPet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace AdasPet.Areas.Loja.Pages
{
    public class CarrinhoModel : PageModel
    {
        public ApplicationDbContext _context { get; set; }

        public CarrinhoModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<Produto> Produtos { get; set; } = new List<Produto>();


        public void OnGet()
        {
            var CarrinhoListID = CarrinhoOp.GetCarrinho(HttpContext.Session);
            for (int i = 0; i < CarrinhoListID.Count; i++)
            {
                var ProdutoId = CarrinhoListID[i];
                Produtos.Add(_context.Produto.Find(ProdutoId));
            }
        } 

        public async Task<IActionResult> OnPostAsync()
        {
            // Pega o corpo do requerimento mandado pela pagina
            var BodyForm = await HttpContext.Request.ReadFormAsync();
            CarrinhoOp.RemoverItem(HttpContext.Session, new Guid(BodyForm["item.ID"]));
            var CarrinhoListID = CarrinhoOp.GetCarrinho(HttpContext.Session);
            for (int i = 0; i < CarrinhoListID.Count; i++)
            {
                var ProdutoId = CarrinhoListID[i];
                Produtos.Add(_context.Produto.Find(ProdutoId));
            }
            return Page();
        }

    }
}
