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

namespace AdasPet.Areas.Entregadores.Pages
{
    [Authorize(Roles = "entregador")]
    public class EntregasModel : PageModel
    {
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();

        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public string UserID { get; set; }

        public EntregasModel(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public void OnGet()
        {
            var userName = User.Identity.Name;
            Pedidos = _context.Pedido.Where(p => p.StatusDoPedido.Equals(PedidoStatus.Aceito) || p.Entregador.ContaCadastro.UserName == userName).Include(p => p.Endereco).ToList();
        }

        public IEnumerable<Endereco> GetPedidoFornecedoresEnderecos(Pedido pedido)
        {
            var fornecedoresId = _context.PedidoProduto.Where(o => o.PedidoID.Equals(pedido.ID)).Select(o => o.Produto.ContaCadastro.Id).Distinct();
            var enderecos = _context.Endereco.Where(e => fornecedoresId.Contains(e.Fornecedor.ContaCadastro.Id)).ToList();
            return enderecos;
        }

        public string GetEnderecoPretty(Pedido pedido)
        {
            _context.Entry(pedido)
                .Reference(p => p.Endereco)
                .Load();
            return $"{pedido.Endereco.Rua},{pedido.Endereco.NumeroCasa} - {pedido.Endereco.Complemento}";
        }
        
        public async Task<IActionResult> OnPostAceitarAsync(string pedidoId)
        {
            UserID = _userManager.GetUserId(User);
            Pedido pedido = _context.Pedido.Find(new Guid(pedidoId));

            if (pedido.StatusDoPedido.Equals(PedidoStatus.Aceito))
            {
                pedido.StatusDoPedido = PedidoStatus.Entregando;
                pedido.Entregador = _context.Entregador.Where(e => e.ContaCadastro.Id.Equals(UserID)).Single();

                await _context.SaveChangesAsync();
            }

            return Redirect("./Entregas");
        }

        public async Task<IActionResult> OnPostFinalizarAsync(string pedidoId)
        {
            UserID = _userManager.GetUserId(User);
            Pedido pedido = _context.Pedido.Find(new Guid(pedidoId));

            pedido.StatusDoPedido = PedidoStatus.Completo;
            pedido.DataFim = DateTime.Now;

            await _context.SaveChangesAsync();

            return Redirect("./Entregas");
        }
    }
}
