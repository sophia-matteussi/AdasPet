using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdasPet.Data;
using AdasPet.Models;

namespace AdasPet.Areas.Lojista.Pages.MeusProdutos
{
    public class IndexModel : PageModel
    {
        private readonly AdasPet.Data.ApplicationDbContext _context;

        public IndexModel(AdasPet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; }

        public async Task OnGetAsync()
        {
            Produto = await _context.Produto.ToListAsync();
        }
    }
}
