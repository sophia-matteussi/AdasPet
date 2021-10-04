using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdasPet.Data;
using AdasPet.Models;

namespace AdasPet.Areas.Identity.Pages.Account.Manage.Enderecos
{
    public class EditModel : PageModel
    {
        private readonly AdasPet.Data.ApplicationDbContext _context;

        public EditModel(AdasPet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Endereco).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnderecoExists(Endereco.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EnderecoExists(Guid id)
        {
            return _context.Endereco.Any(e => e.ID == id);
        }
    }
}
