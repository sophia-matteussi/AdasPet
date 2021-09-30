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
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public string Erro { get; set; }

        private readonly AdasPet.Data.ApplicationDbContext _context;

        public DeleteModel(AdasPet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Endereco Endereco { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id, string erro)
        {
            Erro = erro;
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

        public IActionResult OnPost(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Endereco = _context.Endereco.Find(id);

            //if (Endereco != null)
            //{
            //    _context.Endereco.Remove(Endereco);
            //    _context.SaveChanges();
            //}


            if (!Endereco.Principal)
            {
                _context.Endereco.Remove(Endereco);
                _context.SaveChanges();
                return RedirectToPage("./Index");
            }
            else
            {
                //ModelState.AddModelError("Principal", "O endereço principal não pode ser deletado!\nVocê deve definir outro endereço como principal antes de deletar este.");
                return Redirect("./Delete?id=" + id + "&Erro=O%20endere%C3%A7o%20principal%20n%C3%A3o%20pode%20ser%20deletado%21%0AVoc%C3%AA%20deve%20definir%20outro%20endere%C3%A7o%20como%20principal%20antes%20de%20deletar%20este.");

            }
        }
    }
}
