using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdasPet.Data;
using AdasPet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdasPet.Areas.Identity.Pages.Account.Manage
{
    public class EnderecosModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public List<Endereco> Enderecos { get; set; }

        public EnderecosModel(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public IActionResult OnGet()
        {
            string UserId = _userManager.GetUserId(User);
            Guid clienteID = _context.Cliente.Where(user => user.ContaCadastro.Id == UserId).First().ID;
            var enderecos = _context.Endereco.Where(end => end.Cliente.ID == clienteID).ToList();

            Enderecos = enderecos;

            return Page();
        }
    }
}
