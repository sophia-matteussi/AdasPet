using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdasPet.Areas.Loja.Pages.Carrinho;
using AdasPet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AdasPet.Areas.Loja.Pages
{
    public class TelaPagamentoModel : PageModel
    {
        [BindProperty]
        public string Tipo { get; set; }

        private readonly AdasPet.Data.ApplicationDbContext _context;

        private readonly UserManager<IdentityUser> _userManager;

        public TelaPagamentoModel(AdasPet.Data.ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        public List<SelectListItem> Enderecos { get; private set; }

        [BindProperty]
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public IActionResult OnGet(string tipo)
        {
            Tipo = tipo;

            string UserId = _userManager.GetUserId(User);

            var cliente = _context.Cliente.Where(user => user.ContaCadastro.Id == UserId);

            var enderecos = _context.Endereco.Where(end => end.Cliente.ID == cliente.First().ID);

            try
            {
                Enderecos = enderecos.Select(end => new SelectListItem
                {
                    Value = end.ID.ToString(),
                    Text = end.Rua
                }
                ).ToList();
            } catch
            {
                return Redirect("~/Identity/Account/CadastroCompleto");
            }

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
