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

namespace AdasPet.Areas.Lojista.Pages.MeusProdutos
{
    public class IndexModel : PageModel
    {
        private readonly AdasPet.Data.ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public IList<Produto> Produto { get;set; }

        public IndexModel(AdasPet.Data.ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }


        public async Task OnGetAsync()
        {
            string userId = _userManager.GetUserId(User);
            Produto = await _context.Produto.Where(p => p.ContaCadastro.Id.Equals(userId)).ToListAsync();
        }
    }
}
