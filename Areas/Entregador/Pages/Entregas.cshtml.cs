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
    [Authorize(Roles = "entregador")]
    public class EntregasModel : PageModel
    {
        public List<Pedido> Pedidos { get; set; }

        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public EntregasModel(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public void OnGet()
        {
        }

        
    }
}
