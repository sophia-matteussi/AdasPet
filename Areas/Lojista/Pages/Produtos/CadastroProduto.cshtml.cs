using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdasPet.Data;
using AdasPet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdasPet.Areas.Lojista.Pages.Produtos
{
    public class CadastroProdutoModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public CadastroProdutoModel(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        [BindProperty]
        public Produto Produto { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {

            //pega a objeto/linha toda no DB, pois o entity precisa de tudo para poder linkar com um produto
            var user = await _userManager.GetUserAsync(User);

            Produto.ContaCadastro = user;

            //checa se os valores dados pelo usuário estão dentro/de acordo das/com regras das propriedades
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Produto.Add(Produto);
            await _context.SaveChangesAsync();
            return Page();
        }

    }
}
