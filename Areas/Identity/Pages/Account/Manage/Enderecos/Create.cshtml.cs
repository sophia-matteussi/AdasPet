using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AdasPet.Data;
using AdasPet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace AdasPet.Areas.Identity.Pages.Account.Manage.Enderecos
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly AdasPet.Data.ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public CreateModel(AdasPet.Data.ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Endereco Endereco { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            //checa se os valores dados pelo usuário estão dentro/de acordo das/com regras das propriedades
            if (!ModelState.IsValid)
            {
                return Page();
            }

            string UserId = _userManager.GetUserId(User);

            var cliente = _context.Cliente.Where(user => user.ContaCadastro.Id == UserId).First();

            Endereco.Cliente = cliente;
            Endereco.Principal = false;

            _context.Endereco.Add(Endereco);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
