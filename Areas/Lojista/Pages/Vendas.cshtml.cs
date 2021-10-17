using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            Pedidos = QueryPedidosDoUser(User).OrderByDescending(p => p.DataInicio).ToList();
        }


        public PedidoStatus GetStatusProdutosFornecedor(Pedido pedido, string userId)
        {
            var produtosFornecedor = GetUsersPedidoProdutoinPedido(pedido, userId).ToList();
            foreach (PedidoStatus item in Enum.GetValues(typeof(PedidoStatus)))
            {
                if (produtosFornecedor.All(p => p.Status.Equals(item)))
                {
                    return item;
                }
            }
            throw new Exception($"Nem todos os produtos do fornecedor {userId} tem o mesmo status");
        }

        public IActionResult OnGetNovosPedidos()
        {
            List<Pedido> novosPedidos = QueryPedidosDoUser(User).Where(p => p.StatusDoPedido.Equals(PedidoStatus.Novo)).ToList();
            if (novosPedidos.Count > 0)
            {
                return Content("Novos Pedidos");
            }
            //return Content("Nenhum novo Pedido");
            return new OkResult();
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

        private IQueryable<PedidoProduto> GetUsersPedidoProdutoinPedido(Pedido pedido, string userId)
        {
            var pedidoProdutos = _context.PedidoProduto.Where(o => 
                o.PedidoID.Equals(pedido.ID) && o.Produto.ContaCadastro.Id.Equals(userId)
            );
            return pedidoProdutos;
        }
        
        public async Task<IActionResult> OnPostAceitarAsync(string pedidoId)
        {
            UserID = _userManager.GetUserId(User);
            Pedido pedido = _context.Pedido.Find(new Guid(pedidoId));
            var meusProdutos = _context.PedidoProduto.Where(o => o.PedidoID.Equals(pedido.ID) && o.Produto.ContaCadastro.Id.Equals(UserID)).ToList();

            foreach (var produto in meusProdutos)
            {
                produto.Status = PedidoStatus.Aceito;
                _context.Produto.Find(produto.ProdutoID).QtdEmEstoque -= 1;
            } 

            if (GetUsersPedidoProdutoinPedido(pedido, UserID).ToList().All(p => p.Status == PedidoStatus.Aceito))
            {
                pedido.StatusDoPedido = PedidoStatus.Aceito;
            }

            await _context.SaveChangesAsync();

            return Redirect("./Vendas");
        }

        public async Task<IActionResult> OnPostRejeitarAsync(string pedidoId)
        {
            UserID = _userManager.GetUserId(User);
            Pedido pedido = _context.Pedido.Find(new Guid(pedidoId));

            var meusProdutos = _context.PedidoProduto.Where(o => o.PedidoID.Equals(pedido.ID) && o.Produto.ContaCadastro.Id.Equals(UserID)).ToList();

            foreach (var produto in meusProdutos)
            {
                produto.Status = PedidoStatus.Recusado;
            } 

            if (GetUsersPedidoProdutoinPedido(pedido, UserID).All(p => p.Status.Equals(PedidoStatus.Recusado)))
            {
                pedido.StatusDoPedido = PedidoStatus.Recusado;
                pedido.DataFim = DateTime.Now;
            }

            await _context.SaveChangesAsync();
            return Redirect("./Vendas");
        }
    }
}
