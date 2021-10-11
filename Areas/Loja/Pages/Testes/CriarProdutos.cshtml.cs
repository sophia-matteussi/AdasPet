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


        private List<string> Fornecedores { get; } = new List<string>() { 
            "apolo" , "amigopet" , "kittypets", "capitaopet", "thom"
        };

        public CriarProdutosModel(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public void OnGet()
        {
        }

        public async void OnPostCriarFornecedores()
        {
            foreach (var item in Fornecedores)
            {
                string nome = item + "@adaspet.com.br";
                await _userManager.CreateAsync(new IdentityUser { UserName = nome, Email = nome }, "1Ad@s2");
            }
        }

        public void OnPost()
        {

            //*********************************MARCA VERDE************************************

            _context.Produto.Add(new Produto()
            {
                Nome = "Ração pequeno porte 2Kg ",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 22.9,
                QtdEmEstoque = 123,
                PrecisaDeCarro = false,
                Descricao = "Ração perfeita para seu cachorro. Ela tem uma ótima qualidade",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });



            _context.Produto.Add(new Produto()
            {
                Nome = "Ração pequeno porte 2Kg ",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 30,
                QtdEmEstoque = 110,
                PrecisaDeCarro = false,
                Descricao = "Ração perfeita para seu cachorro. Ela tem uma ótima qualidade",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });



            _context.Produto.Add(new Produto()
            {
                Nome = "Ração pequeno porte 2Kg ",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 35.5,
                QtdEmEstoque = 120,
                PrecisaDeCarro = false,
                Descricao = "Ração perfeita para seu cachorro. Ela tem uma ótima qualidade",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ração médio porte 5kg ",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 45,
                QtdEmEstoque = 300,
                PrecisaDeCarro = false,
                Descricao = "Ração super premiun para seu cachorro",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ração médio porte 5kg ",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 47,
                QtdEmEstoque = 302,
                PrecisaDeCarro = false,
                Descricao = "Ração super premiun para seu cachorro",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ração médio porte 5kg ",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 55,
                QtdEmEstoque = 330,
                PrecisaDeCarro = false,
                Descricao = "Ração super premiun para seu cachorro",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ração pequeno porte 2kg",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 20,
                QtdEmEstoque = 410,
                PrecisaDeCarro = false,
                Descricao = "Ração super premiun para seu cachorro",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ração pequeno porte 2kg",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 25,
                QtdEmEstoque = 401,
                PrecisaDeCarro = false,
                Descricao = "Ração super premiun para seu cachorro",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ração pequeno porte 2kg",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 19.5,
                QtdEmEstoque = 400,
                PrecisaDeCarro = false,
                Descricao = "Ração super premiun para seu cachorro",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });



            _context.Produto.Add(new Produto()
            {
                Nome = "Sache frango",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 3.1,
                QtdEmEstoque = 320,
                PrecisaDeCarro = false,
                Descricao = "Alimentação completa e saborosa",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Sache frango",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 3.5,
                QtdEmEstoque = 302,
                PrecisaDeCarro = false,
                Descricao = "Alimentação completa e saborosa",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Sache frango",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 3.6,
                QtdEmEstoque = 300,
                PrecisaDeCarro = false,
                Descricao = "Alimentação completa e saborosa",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });



            _context.Produto.Add(new Produto()
            {
                Nome = "Mistura de sementes Papagaios 600g",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Passaro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 40.9,
                QtdEmEstoque = 120,
                PrecisaDeCarro = false,
                Descricao = "Alimentação completa e saborosa",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Mistura de sementes Papagaios 600g",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Passaro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 42,
                QtdEmEstoque = 100,
                PrecisaDeCarro = false,
                Descricao = "Alimentação completa e saborosa",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Mistura de sementes Papagaios 600g",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Passaro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 43.5,
                QtdEmEstoque = 102,
                PrecisaDeCarro = false,
                Descricao = "Alimentação completa e saborosa",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });



            _context.Produto.Add(new Produto()
            {
                Nome = "Ração extrusada 500g",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Roedores,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 23.9,
                QtdEmEstoque = 301,
                PrecisaDeCarro = false,
                Descricao = "Alimentaçãõ completa para seu roedor",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ração extrusada 500g",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Roedores,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 25,
                QtdEmEstoque = 300,
                PrecisaDeCarro = false,
                Descricao = "Alimentaçãõ completa para seu roedor",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ração extrusada 500g",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Roedores,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 24.9,
                QtdEmEstoque = 311,
                PrecisaDeCarro = false,
                Descricao = "Alimentaçãõ completa para seu roedor",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adas.com.br").First()
            });



            _context.Produto.Add(new Produto()
            {
                Nome = "Ração extrusada 250g",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Repteis,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 32.9,
                QtdEmEstoque = 310,
                PrecisaDeCarro = false,
                Descricao = "Alimentaçãõ completa para seu réptil ",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adas.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ração extrusada 250g",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Repteis,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 30,
                QtdEmEstoque = 301,
                PrecisaDeCarro = false,
                Descricao = "Alimentaçãõ completa para seu réptil",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adas.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ração extrusada 250g",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Repteis,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 30.5,
                QtdEmEstoque = 300,
                PrecisaDeCarro = false,
                Descricao = "Alimentaçãõ completa para seu réptil",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adas.com.br").First()
            });



            _context.Produto.Add(new Produto()
            {
                Nome = "Alfalfa 100g",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Coelho,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 4.9,
                QtdEmEstoque = 254,
                PrecisaDeCarro = false,
                Descricao = "Alimento complementar e necessario para seu coelho",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adas.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Alfalfa 100g",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Coelho,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 4.1,
                QtdEmEstoque = 231,
                PrecisaDeCarro = false,
                Descricao = "Alimento complementar e necessario para seu coelho",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adas.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Alfalfa 100g",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Coelho,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 5,
                QtdEmEstoque = 201,
                PrecisaDeCarro = false,
                Descricao = "Alimento complementar e necessario para seu coelho",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adas.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Alfalfa 100g",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Coelho,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 5,
                QtdEmEstoque = 201,
                PrecisaDeCarro = false,
                Descricao = "Alimento complementar e necessario para seu coelho",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Alfalfa 100g",
                Marca = "Verde",
                TipoDeAnimal = ProdutoAnimais.Coelho,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 5,
                QtdEmEstoque = 201,
                PrecisaDeCarro = false,
                Descricao = "Alimento complementar e necessario para seu coelho",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });

            //*******************************************MARCA AMARELO*****************************************

            _context.Produto.Add(new Produto()
            {
                Nome = "Ração Filhote 2kg",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 15,
                QtdEmEstoque = 150,
                PrecisaDeCarro = false,
                Descricao = "Ração perfeita para seu filhote. Ração natural sem corantes",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Ração Filhote 2kg",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 13.5,
                QtdEmEstoque = 160,
                PrecisaDeCarro = false,
                Descricao = "Ração perfeita para seu filhote. Ração natural sem corantes",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Ração Filhote 2kg",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 14,
                QtdEmEstoque = 175,
                PrecisaDeCarro = false,
                Descricao = "Ração perfeita para seu filhote. Ração natural sem corantes",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Ração médio porte 2kg",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 23.5,
                QtdEmEstoque = 250,
                PrecisaDeCarro = false,
                Descricao = "Ração perfeita para seu cachorro. Ela tem uma ótima qualidade e premiun",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitao@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Ração médio porte 2kg",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 25,
                QtdEmEstoque = 259,
                PrecisaDeCarro = false,
                Descricao = "Ração perfeita para seu cachorro. Ela tem uma ótima qualidade e premiun",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Ração pequeno porte 5kg",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 29.9,
                QtdEmEstoque = 300,
                PrecisaDeCarro = false,
                Descricao = "Ração gold premiun, sem adição de corante e aromatizantes",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Ração pequeno porte 5kg",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 28.9,
                QtdEmEstoque = 265,
                PrecisaDeCarro = false,
                Descricao = "Ração gold premiun, sem adição de corante e aromatizantes",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Ração pequeno porte 5kg",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 27.9,
                QtdEmEstoque = 278,
                PrecisaDeCarro = false,
                Descricao = "Ração gold premiun, sem adição de corante e aromatizantes",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Ração médio porte 5kg",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 25.5,
                QtdEmEstoque = 242,
                PrecisaDeCarro = false,
                Descricao = "Ração premiun sabor salmão",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitao@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Ração médio porte 5kg",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 24.5,
                QtdEmEstoque = 246,
                PrecisaDeCarro = false,
                Descricao = "Ração premiun sabor salmão",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Sache carne ao molho",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 1.9,
                QtdEmEstoque = 366,
                PrecisaDeCarro = false,
                Descricao = "Alimentação completa e saborosa",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Sache carne ao molho",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 1.7,
                QtdEmEstoque = 354,
                PrecisaDeCarro = false,
                Descricao = "Alimentação completa e saborosa",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Sache carne ao molho",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 2.5,
                QtdEmEstoque = 327,
                PrecisaDeCarro = false,
                Descricao = "Alimentação completa e saborosa",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Mistura de sementes Calopsitas 500g",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Passaro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 30,
                QtdEmEstoque = 230,
                PrecisaDeCarro = false,
                Descricao = "Mistura de sementes completa para sua calopsita",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitao@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Mistura de sementes Calopsitas 500g",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Passaro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 28.9,
                QtdEmEstoque = 215,
                PrecisaDeCarro = false,
                Descricao = "Mistura de sementes completa para sua calopsita",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Ração natural 500g",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Roedores,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 20.5,
                QtdEmEstoque = 230 ,
                PrecisaDeCarro = false,
                Descricao = "Ração natural equilibrada para qualquer roedor",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Ração natural 500g",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Roedores,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 19.5,
                QtdEmEstoque = 225,
                PrecisaDeCarro = false,
                Descricao = "Ração natural equilibrada para qualquer roedor",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Ração natural 500g",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Roedores,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 21.9,
                QtdEmEstoque = 215,
                PrecisaDeCarro = false,
                Descricao = "Ração natural equilibrada para qualquer roedor",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Feno 100g",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Coelho,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 5.99,
                QtdEmEstoque = 230,
                PrecisaDeCarro = false,
                Descricao = "Alimento complementar e necessario para seu coelho",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Feno 100g",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Coelho,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 5.45,
                QtdEmEstoque = 212,
                PrecisaDeCarro = false,
                Descricao = "Alimento complementar e necessario para seu coelho",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Feno 100g",
                Marca = "Amarelo",
                TipoDeAnimal = ProdutoAnimais.Coelho,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 6.59,
                QtdEmEstoque = 189,
                PrecisaDeCarro = false,
                Descricao = "Alimento complementar e necessario para seu coelho",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });

            //"apolo" , "amigopet" , "kittypets", "capitaopet", "thom"


            _context.SaveChanges();


        }

    }
}
