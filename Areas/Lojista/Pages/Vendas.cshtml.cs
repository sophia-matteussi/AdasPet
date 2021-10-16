using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AdasPet.Data;
using AdasPet.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdasPet.Areas.Lojista.Pages
{
    [Authorize(Roles = "fornecedor")]
    public class VendasModel : PageModel
    {
        public List<Pedido> Pedidos { get; set; }

        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public string UserID { get; set; }

        public VendasModel(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public void OnGet()
        {
            UserID = _userManager.GetUserId(User);
            Pedidos = QueryPedidosDoUser(User).ToList();
        }

        public async Task<IActionResult> OnGetNovosPedidosAsync()
        {
            List<Pedido> novosPedidos = QueryPedidosDoUser(User).Where(p => p.StatusDoPedido.Equals("Novo")).ToList();
            if (novosPedidos.Count > 0)
            {
                return Content("Novos Pedidos");
            }
            return Content("Nenhum novo Pedido");
        }


        public string GetNomeProdutos(Pedido pedido)
        {
            var produtos = _context.Entry(pedido).Collection(p => p.Produtos).Query().Where(p => p.ContaCadastro.Id == UserID)
                .Select(p => p.Nome + " " + p.Marca);
            return String.Join(",", produtos);

            //return produtos.ToList();
        }

        private IQueryable<Pedido> QueryPedidosDoUser(ClaimsPrincipal user)
        {
            string userId = _userManager.GetUserId(user);
            return _context.Pedido.Where(
                o => o.Produtos.Select(
                    p => p.ContaCadastro.Id)
                .Contains(userId));
        } 

        public async Task OnPostRejeitarAsync(Guid pedidoId)
        {
            string userId = _userManager.GetUserId(User);
            Pedido pedido = _context.Pedido.Find(pedidoId);
            List<Produto> produtosUpdated = _context.Entry(pedido)
                .Collection(p => p.Produtos)
                .Query()
                .Where(p => p.ContaCadastro.Id != userId)
                .ToList();

            pedido.Produtos = produtosUpdated;
            pedido.StatusDoPedido = "Cancelado";

            await _context.SaveChangesAsync();
        }
    }
}
