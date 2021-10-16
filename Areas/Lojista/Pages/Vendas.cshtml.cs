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
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();

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

        public IActionResult OnGetNovosPedidos()
        {
            List<Pedido> novosPedidos = QueryPedidosDoUser(User).Where(p => p.StatusDoPedido.Equals("Novo")).ToList();
            if (novosPedidos.Count > 0)
            {
                return Content("Novos Pedidos");
            }
            return Content("Nenhum novo Pedido");
        }


        public List<string> GetNomeProdutos(Pedido pedido)
        {
            var produtos = _context.PedidoProduto.Where(o => o.PedidoID.Equals(pedido.ID)).Select(o => o.Produto)
            .Where(p => p.ContaCadastro.Id == UserID)
                .Select(p => p.Nome + " " + p.Marca);
            return produtos.ToList();

            //return produtos.ToList();
        }

        private IQueryable<Pedido> QueryPedidosDoUser(ClaimsPrincipal user)
        {
            string userId = _userManager.GetUserId(user);
            return _context.Pedido.Where(
                o => o.PedidoProdutos.Select(p => p.Produto).Select(
                    p => p.ContaCadastro.Id)
                .Contains(userId));
        } 

        public async Task OnPostRejeitarAsync(string pedidoId)
        {
            string userId = _userManager.GetUserId(User);
            Pedido pedido = _context.Pedido.Find(new Guid(pedidoId));
            
            //pedido.Produtos = produtosUpdated;
            pedido.StatusDoPedido = PedidoStatus.Recusado;
            pedido.DataFim = DateTime.Now;

            _context.PedidoProduto.RemoveRange(
                _context.PedidoProduto.Where(o => o.PedidoID.Equals(pedido.ID) && o.Produto.ContaCadastro.Id.Equals(userId))
            );

            await _context.SaveChangesAsync();

            Pedidos = QueryPedidosDoUser(User).ToList();
        }
    }
}
