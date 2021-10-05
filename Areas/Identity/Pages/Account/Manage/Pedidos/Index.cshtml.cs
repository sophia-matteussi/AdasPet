using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdasPet.Data;
using AdasPet.Models;
using Microsoft.AspNetCore.Identity;

namespace AdasPet.Areas.Identity.Pages.Account.Manage.Pedidos
{
    public class IndexModel : PageModel
    {
        private readonly AdasPet.Data.ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public IndexModel(AdasPet.Data.ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }


        public IList<Pedido> Pedido { get; set; } = new List<Pedido>();

        public async Task<IActionResult> OnGetAsync()
        {
            string UserId = _userManager.GetUserId(User);

            var cliente = _context.Cliente.Where(user => user.ContaCadastro.Id == UserId);

            if (!cliente.Any())
            {
                return Page();
            }
            var pedidos = _context.Pedido.Where(end => end.Cliente.ID == cliente.First().ID).ToList();

            Pedido = pedidos;

            return Page();
        }
    }
}
