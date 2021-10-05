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
using Microsoft.AspNetCore.Identity;

namespace AdasPet.Areas.Identity.Pages.Account.Manage.Enderecos
{
    public class EditModel : PageModel
    {
        private readonly AdasPet.Data.ApplicationDbContext _context;

        private readonly UserManager<IdentityUser> _userManager;

        public string Message { get; set; } = "";

        public EditModel(AdasPet.Data.ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
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

        public async Task<IActionResult> OnPostTornarPrincipalAsync(Guid? id)
        {

            string UserId = _userManager.GetUserId(User);

            var cliente = _context.Cliente.Where(user => user.ContaCadastro.Id == UserId);
            var enderecos = _context.Endereco.Where(end => end.Cliente.ID == cliente.First().ID).ToList();

            foreach (var item in enderecos)
            {
                if (item.ID != id)
                {
                    item.Principal = false;
                }
                else
                {
                    item.Principal = true;
                }
            }
            await _context.SaveChangesAsync();

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
