using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdasPet.Data;
using AdasPet.Models;

namespace AdasPet.Areas.Identity.Pages.Account.Manage.Enderecos
{
    public class DetailsModel : PageModel
    {
        private readonly AdasPet.Data.ApplicationDbContext _context;

        public DetailsModel(AdasPet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Endereco Endereco { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Endereco = await _context.Endereco.FirstOrDefaultAsync(m => m.ID == id);

            if (Endereco == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
