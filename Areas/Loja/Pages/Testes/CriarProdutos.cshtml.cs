using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdasPet.Data;
using AdasPet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdasPet.Areas.Loja.Pages.Testes
{
    public class CriarProdutosModel : PageModel
    {
        public ApplicationDbContext _context { get; set; }
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        //Lista de fornecedores cadastrados
        private List<string> Fornecedores { get; } = new List<string>() 
        { 
            "apolo" , "amigopet" , "kittypets", "capitaopet", "thom"
        };

        private List<string> Roles { get; } = new List<string>
        {
            "fornecedor","cliente","entregador"
        };

        public CriarProdutosModel(ApplicationDbContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public void OnGet()
        {
        }

        public async Task OnPostCriarRolesAsync()
        {
            foreach (var item in Roles)
            {
                await _roleManager.CreateAsync(new IdentityRole(item));
            }
        }

        //Cria fornecedores
        public async Task OnPostCriarFornecedoresAsync()
        {
            foreach (var item in Fornecedores)
            {
                string nome = item + "@adaspet.com.br";
                await _userManager.CreateAsync(new IdentityUser { UserName = nome, Email = nome }, "1Ad@s2");
                var user = await _userManager.FindByNameAsync(nome);
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                await _userManager.ConfirmEmailAsync(user, code);
            }
        }

        //Cria produtos
        public void OnPost()
        {
            _context.Produto.Add(new Produto()
            {
                Nome = "Ração 5Kg",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 100,
                QtdEmEstoque = 30,
                PrecisaDeCarro = false,
                Descricao = "Ração muito gostosa",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Ração 10Kg",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 200,
                QtdEmEstoque = 30,
                PrecisaDeCarro = false,
                Descricao = "Ração muito gostosa",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });

            _context.SaveChanges();


        }

    }
}
