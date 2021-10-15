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
            
                //*********************************** MARCA AMARELO - FRAN ***********************************

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o Filhote 2kg",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 15,
                    QtdEmEstoque = 150,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o perfeita para seu filhote. Ra��o natural sem corantes.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o Filhote 2kg",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 13.5,
                    QtdEmEstoque = 160,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o perfeita para seu filhote. Ra��o natural sem corantes.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o Filhote 2kg",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 14,
                    QtdEmEstoque = 175,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o perfeita para seu filhote. Ra��o natural sem corantes.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o m�dio porte 2kg",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 23.5,
                    QtdEmEstoque = 250,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o perfeita para seu cachorro. Ela tem uma �tima qualidade e premiun.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitao@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o m�dio porte 2kg",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 25,
                    QtdEmEstoque = 259,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o perfeita para seu cachorro. Ela tem uma �tima qualidade e premiun.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o pequeno porte 5kg",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 29.9,
                    QtdEmEstoque = 300,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o gold premiun, sem adi��o de corante e aromatizantes.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o pequeno porte 5kg",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 28.9,
                    QtdEmEstoque = 265,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o gold premiun, sem adi��o de corante e aromatizantes.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o pequeno porte 5kg",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 27.9,
                    QtdEmEstoque = 278,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o gold premiun, sem adi��o de corante e aromatizantes.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o m�dio porte 5kg",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 25.5,
                    QtdEmEstoque = 242,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o premiun sabor salm�o.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitao@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o m�dio porte 5kg",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 24.5,
                    QtdEmEstoque = 246,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o premiun sabor salm�o.",
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
                    Descricao = "Alimenta��o completa e saborosa",
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
                    Descricao = "Alimenta��o completa e saborosa.",
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
                    Descricao = "Alimenta��o completa e saborosa.",
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
                    Descricao = "Mistura de sementes completa para sua calopsita.",
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
                    Descricao = "Mistura de sementes completa para sua calopsita.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o natural 500g",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 20.5,
                    QtdEmEstoque = 230,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o natural equilibrada para qualquer Roedor.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o natural 500g",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 19.5,
                    QtdEmEstoque = 225,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o natural equilibrada para qualquer Roedor.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o natural 500g",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 21.9,
                    QtdEmEstoque = 215,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o natural equilibrada para qualquer Roedor.",
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
                    Descricao = "Alimento complementar e necess�rio para seu coelho.",
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
                    Descricao = "Alimento complementar e necess�rio para seu coelho.",
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
                    Descricao = "Alimento complementar e necess�rio para seu coelho.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o granulada 150g",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 20.0,
                    QtdEmEstoque = 412,
                    PrecisaDeCarro = false,
                    Descricao = "Alimenta��o para peixes de fundo.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o granulada 150g",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 19.49,
                    QtdEmEstoque = 400,
                    PrecisaDeCarro = false,
                    Descricao = "Alimenta��o para peixes de fundo",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisto",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 4.0,
                    QtdEmEstoque = 369,
                    PrecisaDeCarro = false,
                    Descricao = "Refei��o completa e balanceada com ra��o.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisto",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 4.9,
                    QtdEmEstoque = 335,
                    PrecisaDeCarro = false,
                    Descricao = "Refei��o completa e balanceada com ra��o.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 69.9,
                    QtdEmEstoque = 185,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio para pulga e carrapato de alta qualidade e efici�ncia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 66.9,
                    QtdEmEstoque = 175,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio para pulga e carrapato de alta qualidade e efici�ncia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 68.49,
                    QtdEmEstoque = 168,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio para pulga e carrapato de alta qualidade e efici�ncia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 73.5,
                    QtdEmEstoque = 205,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio para pulga e carrapato de alta qualidade e efici�ncia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 75.9,
                    QtdEmEstoque = 216,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio para pulga e carrapato de alta qualidade e efici�ncia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 27.5,
                    QtdEmEstoque = 185,
                    PrecisaDeCarro = false,
                    Descricao = "Verm�fugo ideal no tratamento contra vermes chatos e redondos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 29.5,
                    QtdEmEstoque = 198,
                    PrecisaDeCarro = false,
                    Descricao = "Verm�fugo ideal no tratamento contra vermes chatos e redondos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 26.9,
                    QtdEmEstoque = 208,
                    PrecisaDeCarro = false,
                    Descricao = "Verm�fugo ideal no tratamento contra vermes chatos e redondos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 23.49,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Verm�fugo ideal para tratamento de vermes do seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 25.9,
                    QtdEmEstoque = 210,
                    PrecisaDeCarro = false,
                    Descricao = "Verm�fugo ideal para tratamento de vermes do seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 15,
                    QtdEmEstoque = 180,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para intoxica��es de c�es, gatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 17.9,
                    QtdEmEstoque = 160,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para intoxica��es de c�es, gatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 19.9,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para intoxica��es de c�es, gatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 16.9,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para intoxica��es de c�es, gatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 18.9,
                    QtdEmEstoque = 135,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para intoxica��es de c�es, gatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 85,
                    QtdEmEstoque = 159,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para auxiliar no equil�brio da microbiota intestinal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 86.49,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para auxiliar no equil�brio da microbiota intestinal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 83.49,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para auxiliar no equil�brio da microbiota intestinal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 86.9,
                    QtdEmEstoque = 120,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para auxiliar no equil�brio da microbiota intestinal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 83.5,
                    QtdEmEstoque = 110,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para auxiliar no equil�brio da microbiota intestinal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 30.5,
                    QtdEmEstoque = 203,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para tratamento de cicatrizes les�es e feridas, Previnir as doen�as e infec��es cut�neas transmiss�veis ao homem.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 32.5,
                    QtdEmEstoque = 206,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para tratamento de cicatrizes les�es e feridas, Previnir as doen�as e infec��es cut�neas transmiss�veis ao homem",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 33.9,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para tratamento de cicatrizes les�es e feridas, Previnir as doen�as e infec��es cut�neas transmiss�veis ao homem.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 32.9,
                    QtdEmEstoque = 198,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para tratamento de cicatrizes les�es e feridas, Previnir as doen�as e infec��es cut�neas transmiss�veis ao homem.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 36.9,
                    QtdEmEstoque = 195,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para tratamento de cicatrizes les�es e feridas, Previnir as doen�as e infec��es cut�neas transmiss�veis ao homem.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 31.9,
                    QtdEmEstoque = 150,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para tratamento da sarna dos p�s dos p�ssaros.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 33.5,
                    QtdEmEstoque = 165,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para tratamento da sarna dos p�s dos p�ssaros.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38.9,
                    QtdEmEstoque = 105,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para tratamento de feridas nas patas dos coelhos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 40.9,
                    QtdEmEstoque = 105,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para tratamento de feridas nas patas dos coelhos",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37.9,
                    QtdEmEstoque = 105,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para tratamento de feridas nas patas dos coelhos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 45.9,
                    QtdEmEstoque = 110,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para tratamento de feridas nas patas dos seus Roedores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 43.5,
                    QtdEmEstoque = 100,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para tratamento de feridas nas patas dos seus Roedores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 33.5,
                    QtdEmEstoque = 89,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para tratamento de feridas nas patas dos seus Roedores r�pteis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 32.5,
                    QtdEmEstoque = 99,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para tratamento de feridas nas patas dos seus Roedores r�pteis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 32.9,
                    QtdEmEstoque = 102,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para tratamento de feridas nas patas dos seus Roedores r�pteis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 26,
                    QtdEmEstoque = 204,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para deixar seu c�o mais forte e disposto.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 28.9,
                    QtdEmEstoque = 208,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para deixar seu c�o mais forte e disposto.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 27.9,
                    QtdEmEstoque = 206,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para fortalecer a imunidade do seu gato.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 25.9,
                    QtdEmEstoque = 202,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para fortalecer a imunidade do seu gato.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 24.49,
                    QtdEmEstoque = 199,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para fortalecer a imunidade do seu gato.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 23.49,
                    QtdEmEstoque = 185,
                    PrecisaDeCarro = false,
                    Descricao = "Vitaminas e Suplementos para p�ssaros com os mais variados nutrientes.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 22.99,
                    QtdEmEstoque = 195,
                    PrecisaDeCarro = false,
                    Descricao = "Vitaminas e Suplementos para p�ssaros com os mais variados nutrientes.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 45.9,
                    QtdEmEstoque = 205,
                    PrecisaDeCarro = false,
                    Descricao = "Fertilizante � base de Pot�ssio, indicado para aqu�rios.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 43.49,
                    QtdEmEstoque = 208,
                    PrecisaDeCarro = false,
                    Descricao = "Fertilizante � base de Pot�ssio, indicado para aqu�rios.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 46.9,
                    QtdEmEstoque = 203,
                    PrecisaDeCarro = false,
                    Descricao = "Fertilizante � base de Pot�ssio, indicado para aqu�rios.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 17.9,
                    QtdEmEstoque = 149,
                    PrecisaDeCarro = false,
                    Descricao = "Fabricado com ingredientes naturais para suprir as necessidades de minerais de seu coelho.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 19.9,
                    QtdEmEstoque = 146,
                    PrecisaDeCarro = false,
                    Descricao = "Fabricado com ingredientes naturais para suprir as necessidades de minerais de seu coelho.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 16.49,
                    QtdEmEstoque = 122,
                    PrecisaDeCarro = false,
                    Descricao = "Proporciona mais aporte nutricional e vitam�nico aos seus Roedores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 17.9,
                    QtdEmEstoque = 130,
                    PrecisaDeCarro = false,
                    Descricao = "Proporciona mais aporte nutricional e vitam�nico aos seus Roedores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 15.5,
                    QtdEmEstoque = 116,
                    PrecisaDeCarro = false,
                    Descricao = "Proporciona mais aporte nutricional e vitam�nico aos seus Roedores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 13.99,
                    QtdEmEstoque = 115,
                    PrecisaDeCarro = false,
                    Descricao = "Complexo vitam�nico completo para seus r�pteis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 14.99,
                    QtdEmEstoque = 110,
                    PrecisaDeCarro = false,
                    Descricao = "Complexo vitam�nico completo para seus r�pteis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 14.99,
                    QtdEmEstoque = 110,
                    PrecisaDeCarro = false,
                    Descricao = "Complexo vitam�nico completo para seus r�pteis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tapetes Hiegi�nicos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 40,
                    QtdEmEstoque = 152,
                    PrecisaDeCarro = false,
                    Descricao = "Prote��o contra vazamentos, super macio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tapetes Hiegi�nicos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 42.9,
                    QtdEmEstoque = 164,
                    PrecisaDeCarro = false,
                    Descricao = "Prote��o contra vazamentos, super macio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });


                _context.Produto.Add(new Produto()
                {
                    Nome = "Tapetes Hiegi�nicos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 41.59,
                    QtdEmEstoque = 189,
                    PrecisaDeCarro = false,
                    Descricao = "Prote��o contra vazamentos, super macio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Banheiros para Cachorros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 70,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para manter a higiene do seu pet e da sua casa.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Banheiros para Cachorros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 73.9,
                    QtdEmEstoque = 115,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para manter a higiene do seu pet e da sua casa.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coletor de Fezes",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 20,
                    QtdEmEstoque = 116,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para coletar as fezes de seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coletor de Fezes",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 17.9,
                    QtdEmEstoque = 135,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para coletar as fezes de seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coletor de Fezes",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 21.5,
                    QtdEmEstoque = 122,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para coletar as fezes de seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 37.5,
                    QtdEmEstoque = 86,
                    PrecisaDeCarro = false,
                    Descricao = "Shampoo com pH neutro. Zero corante e que n�o arde os olhos, com Aloe Vera para pele sens�veis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });


                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 35.9,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Shampoo com pH neutro. Zero corante e que n�o arde os olhos, com Aloe Vera para pele sens�veis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 40.9,
                    QtdEmEstoque = 102,
                    PrecisaDeCarro = false,
                    Descricao = "Shampoo ideal para p�los claros, Previnir manchas e evita que os fios fiquem amarelados.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 42.9,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Shampoo ideal para p�los claros, Previnir manchas e evita que os fios fiquem amarelados.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 39.9,
                    QtdEmEstoque = 117,
                    PrecisaDeCarro = false,
                    Descricao = "Shampoo ideal para p�los claros, Previnir manchas e evita que os fios fiquem amarelados.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de Unhas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 35.99,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Alicate de unha tipo guilhotina para cuidados especiais de higiene do seu amigo.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de Unhas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 38.5,
                    QtdEmEstoque = 135,
                    PrecisaDeCarro = false,
                    Descricao = "Alicate de unha tipo guilhotina para cuidados especiais de higiene do seu amigo.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de Unhas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 35.5,
                    QtdEmEstoque = 168,
                    PrecisaDeCarro = false,
                    Descricao = "Alicate de unha para cuidados especiais de higiene do seu gato.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de Unhas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36.9,
                    QtdEmEstoque = 139,
                    PrecisaDeCarro = false,
                    Descricao = "Alicate de unha para cuidados especiais de higiene do seu gato.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de Unhas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 34.5,
                    QtdEmEstoque = 122,
                    PrecisaDeCarro = false,
                    Descricao = "Alicate de unha para cuidados especiais de higiene do seu gato.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sabonetes",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 21,
                    QtdEmEstoque = 140,
                    PrecisaDeCarro = false,
                    Descricao = "Sabonete l�quido ideal para limpeza da pelagem.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sabonetes",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 22.9,
                    QtdEmEstoque = 165,
                    PrecisaDeCarro = false,
                    Descricao = "Sabonete l�quido ideal para limpeza da pelagem.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sabonetes",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 28.9,
                    QtdEmEstoque = 174,
                    PrecisaDeCarro = false,
                    Descricao = "Sabonete l�quido ideal para limpeza da pelagem de gatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sabonetes",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 29.5,
                    QtdEmEstoque = 168,
                    PrecisaDeCarro = false,
                    Descricao = "Sabonete l�quido ideal para limpeza da pelagem de gatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sabonetes",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 26.49,
                    QtdEmEstoque = 166,
                    PrecisaDeCarro = false,
                    Descricao = "Sabonete l�quido ideal para limpeza da pelagem de gatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova Rasqueadeira",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 29.99,
                    QtdEmEstoque = 135,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para desembara�ar os pelos, desfazer emaranhados e n�s, remover fios soltos, pele morta e outras sujeiras.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova Rasqueadeira",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 26.5,
                    QtdEmEstoque = 148,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para desembara�ar os pelos, desfazer emaranhados e n�s, remover fios soltos, pele morta e outras sujeiras.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova Rasqueadeira",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 29.99,
                    QtdEmEstoque = 154,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para desembara�ar os pelos, desfazer emaranhados e n�s, remover fios soltos, pele morta e outras sujeiras.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova Rasqueadeira",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 27.99,
                    QtdEmEstoque = 152,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para desembara�ar os pelos, desfazer emaranhados e n�s, remover fios soltos, pele morta e outras sujeiras.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova Rasqueadeira",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 26.9,
                    QtdEmEstoque = 164,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para desembara�ar os pelos, desfazer emaranhados e n�s, remover fios soltos, pele morta e outras sujeiras.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de Areia",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 29.9,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Bandeja indicada para gatos, f�cil de limpar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de Areia",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 32,
                    QtdEmEstoque = 124,
                    PrecisaDeCarro = false,
                    Descricao = "Bandeja indicada para gatos, f�cil de limpar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Areia Higi�nica",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 12.99,
                    QtdEmEstoque = 116,
                    PrecisaDeCarro = false,
                    Descricao = "Areia higi�nica com um super poder de absor��o, bastante eficaz no combate ao mau cheiro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Areia Higi�nica",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 13.5,
                    QtdEmEstoque = 120,
                    PrecisaDeCarro = false,
                    Descricao = "Areia higi�nica com um super poder de absor��o, bastante eficaz no combate ao mau cheiro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Areia Higi�nica",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 12.49,
                    QtdEmEstoque = 148,
                    PrecisaDeCarro = false,
                    Descricao = "Areia higi�nica com um super poder de absor��o, bastante eficaz no combate ao mau cheiro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "P� Coletora",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 5,
                    QtdEmEstoque = 165,
                    PrecisaDeCarro = false,
                    Descricao = "P� sanit�ria para facilitar a limpeza da caixa de areia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "P� Coletora",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 6.5,
                    QtdEmEstoque = 141,
                    PrecisaDeCarro = false,
                    Descricao = "P� sanit�ria para facilitar a limpeza da caixa de areia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "P� de Banho",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 20,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "P� de Banho a seco para manter seus Roedores limpos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "P� de Banho",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 18.9,
                    QtdEmEstoque = 80,
                    PrecisaDeCarro = false,
                    Descricao = "P� de Banho a seco para manter seus Roedores limpos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "P� de Banho",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 19.9,
                    QtdEmEstoque = 75,
                    PrecisaDeCarro = false,
                    Descricao = "P� de Banho a seco para manter seus Roedores limpos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bolinhas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 13,
                    QtdEmEstoque = 152,
                    PrecisaDeCarro = false,
                    Descricao = "Produto � de alt�ssima qualidade, formato anat�mico, brinquedo que entret�m o pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bolinhas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 11.9,
                    QtdEmEstoque = 167,
                    PrecisaDeCarro = false,
                    Descricao = "Produto � de alt�ssima qualidade, formato anat�mico, brinquedo que entret�m o pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ossinhos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 13.9,
                    QtdEmEstoque = 214,
                    PrecisaDeCarro = false,
                    Descricao = "Excelente op��o de petisco porque, al�m de desestressar, tamb�m faz muito bem para a sa�de bucal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ossinhos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 14.9,
                    QtdEmEstoque = 218,
                    PrecisaDeCarro = false,
                    Descricao = "Excelente op��o de petisco porque, al�m de desestressar, tamb�m faz muito bem para a sa�de bucal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ossinhos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 12.5,
                    QtdEmEstoque = 220,
                    PrecisaDeCarro = false,
                    Descricao = "Excelente op��o de petisco porque, al�m de desestressar, tamb�m faz muito bem para a sa�de bucal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ratinho",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 7.5,
                    QtdEmEstoque = 169,
                    PrecisaDeCarro = false,
                    Descricao = "Este brinquedo � idel para gatos, possibilitando a brincadeira em grupo ou sozinho.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ratinho",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 6.9,
                    QtdEmEstoque = 173,
                    PrecisaDeCarro = false,
                    Descricao = "Este brinquedo � idel para gatos, possibilitando a brincadeira em grupo ou sozinho.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ratinho",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 8.69,
                    QtdEmEstoque = 179,
                    PrecisaDeCarro = false,
                    Descricao = "Este brinquedo � idel para gatos, possibilitando a brincadeira em grupo ou sozinho.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Varinhass",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 18.45,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "Varinhass s�o excelentes para distra��o, gastar energia, e fazer com que seu pet se exercite.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Varinhass",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.95,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Varinhass s�o excelentes para distra��o, gastar energia, e fazer com que seu pet se exercite.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Arranhadoreses",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 69,
                    QtdEmEstoque = 100,
                    PrecisaDeCarro = false,
                    Descricao = "Previnir o estrago de m�veis e utens�lios de sua casa.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Arranhadoreses",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 72.5,
                    QtdEmEstoque = 124,
                    PrecisaDeCarro = false,
                    Descricao = "Previnir o estrago de m�veis e utens�lios de sua casa.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Arranhadoreses",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 72.9,
                    QtdEmEstoque = 114,
                    PrecisaDeCarro = false,
                    Descricao = "Previnir o estrago de m�veis e utens�lios de sua casa.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "pets de Pel�cia",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 44,
                    QtdEmEstoque = 50,
                    PrecisaDeCarro = false,
                    Descricao = "Divertido e criativo que ajuda a combater o estresse do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "pets de Pel�cia",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 42.5,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Divertido e criativo que ajuda a combater o estresse do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "pets de Pel�cia",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 42.5,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Divertido e criativo que ajuda a combater o estresse do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "pets de Pel�cia",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 42.5,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Divertido e criativo que ajuda a combater o estresse do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Mordedores",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 22,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Estimula a mastiga��o. Sua textura promove o desenvolvimento e fortalecimento da gengiva, ajuda a eliminar o t�rtaro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Mordedores",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 23.9,
                    QtdEmEstoque = 100,
                    PrecisaDeCarro = false,
                    Descricao = "Estimula a mastiga��o. Sua textura promove o desenvolvimento e fortalecimento da gengiva, ajuda a eliminar o t�rtaro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Mordedores",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 21.5,
                    QtdEmEstoque = 103,
                    PrecisaDeCarro = false,
                    Descricao = "Estimula a mastiga��o. Sua textura promove o desenvolvimento e fortalecimento da gengiva, ajuda a eliminar o t�rtaro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Balan�oss",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 23,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Brinquedo para aves dom�sticas de porte pequeno e m�dio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Balan�oss",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 24.9,
                    QtdEmEstoque = 70,
                    PrecisaDeCarro = false,
                    Descricao = "Brinquedo para aves dom�sticas de porte pequeno e m�dio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Trap�zioss",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 27.9,
                    QtdEmEstoque = 85,
                    PrecisaDeCarro = false,
                    Descricao = "Indicado para p�ssaros. Estimula e exercita as aves.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Trap�zioss",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 29.9,
                    QtdEmEstoque = 95,
                    PrecisaDeCarro = false,
                    Descricao = "Indicado para p�ssaros. Estimula e exercita as aves.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Trap�zioss",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 27.59,
                    QtdEmEstoque = 100,
                    PrecisaDeCarro = false,
                    Descricao = "Indicado para p�ssaros. Estimula e exercita as aves.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escadas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 27,
                    QtdEmEstoque = 52,
                    PrecisaDeCarro = false,
                    Descricao = "� ideal para movimenta��es das articula��es das patas de sua ave, proporciona exerc�cios leves.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escadas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25.5,
                    QtdEmEstoque = 60,
                    PrecisaDeCarro = false,
                    Descricao = "� ideal para movimenta��es das articula��es das patas de sua ave, proporciona exerc�cios leves.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Argolas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 15.5,
                    QtdEmEstoque = 56,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda no desgaste natural o bico. Indicado para Calopsita, Agapornis, Periquito, L�ris, Brotogeris, Bourke, Cardeal, Tuin, P�ssaro-Preto e outras aves de porte semelhante.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Argolas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.9,
                    QtdEmEstoque = 61,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda no desgaste natural o bico. Indicado para Calopsita, Agapornis, Periquito, L�ris, Brotogeris, Bourke, Cardeal, Tuin, P�ssaro-Preto e outras aves de porte semelhante.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Argolas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 14.9,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda no desgaste natural o bico. Indicado para Calopsita, Agapornis, Periquito, L�ris, Brotogeris, Bourke, Cardeal, Tuin, P�ssaro-Preto e outras aves de porte semelhante.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cabanas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 29.9,
                    QtdEmEstoque = 35,
                    PrecisaDeCarro = false,
                    Descricao = "Cabana macia e aconchegante, desenvolvida para prote��o da sua ave.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cabanas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 31.99,
                    QtdEmEstoque = 26,
                    PrecisaDeCarro = false,
                    Descricao = "Cabana macia e aconchegante, desenvolvida para prote��o da sua ave.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cabanas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 28.5,
                    QtdEmEstoque = 20,
                    PrecisaDeCarro = false,
                    Descricao = "Cabana macia e aconchegante, desenvolvida para prote��o da sua ave.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Espiral",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 18.5,
                    QtdEmEstoque = 51,
                    PrecisaDeCarro = false,
                    Descricao = "Brinquedo especial para p�ssaros, fornecendo divers�o, distra��o, relaxamento, intera��o e prevenindo o stress da sua ave.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Espiral",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 17.9,
                    QtdEmEstoque = 49,
                    PrecisaDeCarro = false,
                    Descricao = "Brinquedo especial para p�ssaros, fornecendo divers�o, distra��o, relaxamento, intera��o e prevenindo o stress da sua ave.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roda de Exerc�cios",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 30.5,
                    QtdEmEstoque = 36,
                    PrecisaDeCarro = false,
                    Descricao = "A roda de exerc�cios mant�m seu Roedor sempre disposto, feliz e com �tima sa�de.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roda de Exerc�cios",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 29,
                    QtdEmEstoque = 30,
                    PrecisaDeCarro = false,
                    Descricao = "A roda de exerc�cios mant�m seu Roedor sempre disposto, feliz e com �tima sa�de.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roda de Exerc�cios",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 31.9,
                    QtdEmEstoque = 41,
                    PrecisaDeCarro = false,
                    Descricao = "A roda de exerc�cios mant�m seu Roedor sempre disposto, feliz e com �tima sa�de.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra Mineral para Roedores",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 8,
                    QtdEmEstoque = 86,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda no fortalecimento dos ossos, manuten��o dos dentes limpos e embelezamento dos pelos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra Mineral para Roedores",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 10.5,
                    QtdEmEstoque = 90,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda no fortalecimento dos ossos, manuten��o dos dentes limpos e embelezamento dos pelos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra Mineral para Coelhos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 14.9,
                    QtdEmEstoque = 92,
                    PrecisaDeCarro = false,
                    Descricao = "Fabricada especialmente para atender a necessidade dos coelhos de roer para desgastar os dentes.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra Mineral para Coelhos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 13.5,
                    QtdEmEstoque = 95,
                    PrecisaDeCarro = false,
                    Descricao = "Fabricada especialmente para atender a necessidade dos coelhos de roer para desgastar os dentes.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra Mineral para Coelhos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 14.59,
                    QtdEmEstoque = 90,
                    PrecisaDeCarro = false,
                    Descricao = "Fabricada especialmente para atender a necessidade dos coelhos de roer para desgastar os dentes.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "T�nel para Roedores",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 22,
                    QtdEmEstoque = 55,
                    PrecisaDeCarro = false,
                    Descricao = "Toca para abrigo e prote��o de coelhos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "T�nel para Roedores",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 20.9,
                    QtdEmEstoque = 50,
                    PrecisaDeCarro = false,
                    Descricao = "Toca para abrigo e prote��o de coelhos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "T�nel para Roedores",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 24.9,
                    QtdEmEstoque = 62,
                    PrecisaDeCarro = false,
                    Descricao = "Toca para abrigo e prote��o de Roedores e pequenos animais em geral. � feita de madeira pinus, com ganchos de ferro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "T�nel para Roedores",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 23.5,
                    QtdEmEstoque = 69,
                    PrecisaDeCarro = false,
                    Descricao = "Toca para abrigo e prote��o de Roedores e pequenos animais em geral. � feita de madeira pinus, com ganchos de ferro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "T�nel para Roedores",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25.9,
                    QtdEmEstoque = 67,
                    PrecisaDeCarro = false,
                    Descricao = "Toca para abrigo e prote��o de Roedores e pequenos animais em geral. � feita de madeira pinus, com ganchos de ferro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tubos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 13.5,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Tubos para seus Roedores se divertirem no labirinto na Gaiola.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tubos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 12,
                    QtdEmEstoque = 70,
                    PrecisaDeCarro = false,
                    Descricao = "Tubos para seus Roedores se divertirem no labirinto na Gaiola.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra Mineral para Coelhos",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 10.5,
                    QtdEmEstoque = 90,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda no fortalecimento dos ossos, manuten��o dos dentes limpos e embelezamento dos pelos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho P",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 15,
                    QtdEmEstoque = 150,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira de passeio para cachorros.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho P",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 16.9,
                    QtdEmEstoque = 165,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira de passeio para cachorros.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho P",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 14.29,
                    QtdEmEstoque = 159,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira de passeio para cachorros.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 23.5,
                    QtdEmEstoque = 250,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira de passeio para cachorros de m�dio porte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 25.9,
                    QtdEmEstoque = 244,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira de passeio para cachorros de m�dio porte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 29.9,
                    QtdEmEstoque = 300,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira de passeio para gatos de m�dio porte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 27.8,
                    QtdEmEstoque = 305,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira de passeio para gatos de m�dio porte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 21.5,
                    QtdEmEstoque = 289,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira de passeio para gatos de m�dio porte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho G",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 56.9,
                    QtdEmEstoque = 236,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira de passeio para gatos de porte grande.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho G",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 57.9,
                    QtdEmEstoque = 225,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira de passeio para gatos de porte grande.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Focinheira Tamanho M",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 45.9,
                    QtdEmEstoque = 400,
                    PrecisaDeCarro = false,
                    Descricao = "Indicada para que o passeio com seu pet fica mais tranquilo e seguro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Focinheira Tamanho M",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 44.49,
                    QtdEmEstoque = 395,
                    PrecisaDeCarro = false,
                    Descricao = "Indicada para que o passeio com seu pet fica mais tranquilo e seguro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Focinheira Tamanho M",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 42.5,
                    QtdEmEstoque = 350,
                    PrecisaDeCarro = false,
                    Descricao = "Indicada para que o passeio com seu pet fica mais tranquilo e seguro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de Transporte Pequena",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30,
                    QtdEmEstoque = 230,
                    PrecisaDeCarro = false,
                    Descricao = "Uma forma pr�tica de transportar seu cachorro de um lugar para o outro de forma segura.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de Transporte Pequena",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 32.5,
                    QtdEmEstoque = 236,
                    PrecisaDeCarro = false,
                    Descricao = "Uma forma pr�tica de transportar seu cachorro de um lugar para o outro de forma segura.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de Transporte Pequena",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 19.9,
                    QtdEmEstoque = 230,
                    PrecisaDeCarro = false,
                    Descricao = "Uma forma pr�tica de transportar seu gato de um lugar para o outro de forma segura.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de Transporte Pequena",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 21.9,
                    QtdEmEstoque = 234,
                    PrecisaDeCarro = false,
                    Descricao = "Uma forma pr�tica de transportar seu gato de um lugar para o outro de forma segura.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de Transporte Pequena",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 18.5,
                    QtdEmEstoque = 222,
                    PrecisaDeCarro = false,
                    Descricao = "Uma forma pr�tica de transportar seu gato de um lugar para o outro de forma segura.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de Transporte Grande",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 45.9,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Uma forma pr�tica de transportar seu gato de um lugar para o outro de forma segura.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de Transporte Grande",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 43.5,
                    QtdEmEstoque = 126,
                    PrecisaDeCarro = false,
                    Descricao = "Uma forma pr�tica de transportar seu gato de um lugar para o outro de forma segura.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caminha Pequena",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 29.9,
                    QtdEmEstoque = 352,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu cachorro dormir/descansar confort�velmente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caminha Pequena",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 31.9,
                    QtdEmEstoque = 350,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu cachorro dormir/descansar confort�velmente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caminha Pequena",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 32.5,
                    QtdEmEstoque = 348,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu cachorro dormir/descansar confort�velmente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caminha Grande",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 53,
                    QtdEmEstoque = 236,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu cachorro dormir/descansar confort�velmente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caminha Grande",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 55.9,
                    QtdEmEstoque = 240,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu cachorro dormir/descansar confort�velmente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caminha Pequena",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 33,
                    QtdEmEstoque = 213,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu gato dormir/descansar confort�velmente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caminha Pequena",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 35.9,
                    QtdEmEstoque = 205,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu gato dormir/descansar confort�velmente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caminha Pequena",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 32.49,
                    QtdEmEstoque = 201,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu gato dormir/descansar confort�velmente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caminha Grande",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 50.9,
                    QtdEmEstoque = 100,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu gato dormir/descansar confort�velmente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caminha Grande",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 51.99,
                    QtdEmEstoque = 110,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu gato dormir/descansar confort�velmente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Filtro Interno",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 50,
                    QtdEmEstoque = 152,
                    PrecisaDeCarro = false,
                    Descricao = "Melhorar a qualidade da agua do seu aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Filtro Interno",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 52.9,
                    QtdEmEstoque = 147,
                    PrecisaDeCarro = false,
                    Descricao = "Melhorar a qualidade da �gua do seu aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Filtro Interno",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 49.49,
                    QtdEmEstoque = 134,
                    PrecisaDeCarro = false,
                    Descricao = "Melhorar a qualidade da �gua do seu aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Substrato",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 5,
                    QtdEmEstoque = 233,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar o fundo do seu aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Substrato",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 6.5,
                    QtdEmEstoque = 239,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar o fundo do seu aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 500ml",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 15.9,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Aqu�rio feito em vidro e silicone. Pode ser usado para peixes de �gua salgada e doce.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 500ml",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 17.5,
                    QtdEmEstoque = 116,
                    PrecisaDeCarro = false,
                    Descricao = "Aqu�rio feito em vidro e silicone. Pode ser usado para peixes de �gua salgada e doce.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 500ml",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 18.9,
                    QtdEmEstoque = 121,
                    PrecisaDeCarro = false,
                    Descricao = "Aqu�rio feito em vidro e silicone. Pode ser usado para peixes de �gua salgada e doce.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 1L",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 23.9,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "Aqu�rio feito em vidro e silicone. Pode ser usado para peixes de �gua salgada e doce.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 1L",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 25.9,
                    QtdEmEstoque = 155,
                    PrecisaDeCarro = false,
                    Descricao = "Aqu�rio feito em vidro e silicone. Pode ser usado para peixes de �gua salgada e doce.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 6L",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 35.9,
                    QtdEmEstoque = 185,
                    PrecisaDeCarro = false,
                    Descricao = "Aqu�rio feito em vidro e silicone. Pode ser usado para peixes de �gua salgada e doce.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 6L",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36.9,
                    QtdEmEstoque = 195,
                    PrecisaDeCarro = false,
                    Descricao = "Aqu�rio feito em vidro e silicone. Pode ser usado para peixes de �gua salgada e doce.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 6L",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 33.9,
                    QtdEmEstoque = 189,
                    PrecisaDeCarro = false,
                    Descricao = "Aqu�rio feito em vidro e silicone. Pode ser usado para peixes de �gua salgada e doce.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "L�mpada para Aqu�rio",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 59.99,
                    QtdEmEstoque = 56,
                    PrecisaDeCarro = false,
                    Descricao = "Para plantas aqu�ticas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "L�mpada para Aqu�rio",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 57.9,
                    QtdEmEstoque = 60,
                    PrecisaDeCarro = false,
                    Descricao = "Para plantas aqu�ticas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Termostato para Aqu�rio",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 57.9,
                    QtdEmEstoque = 45,
                    PrecisaDeCarro = false,
                    Descricao = "Aquecer seu aqu�rio e manter uma temperatura est�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Termostato para Aqu�rio",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 58.5,
                    QtdEmEstoque = 55,
                    PrecisaDeCarro = false,
                    Descricao = "Aquecer seu aqu�rio e manter uma temperatura est�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Termostato para Aqu�rio",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 59.5,
                    QtdEmEstoque = 62,
                    PrecisaDeCarro = false,
                    Descricao = "Aquecer seu aqu�rio e manter uma temperatura est�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });


                _context.Produto.Add(new Produto()
                {
                    Nome = "Planta Artificial",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 14.5,
                    QtdEmEstoque = 52,
                    PrecisaDeCarro = false,
                    Descricao = "N�o necessita de cuidados e cria um ambiente natural.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Planta Artificial",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 16.9,
                    QtdEmEstoque = 42,
                    PrecisaDeCarro = false,
                    Descricao = "N�o necessita de cuidados e cria um ambiente natural.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiola M�dia",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 126.9,
                    QtdEmEstoque = 30,
                    PrecisaDeCarro = false,
                    Descricao = "Gaiola de madeira de Pinus estilo meia - lua com fibra branca.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiola M�dia",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 128.49,
                    QtdEmEstoque = 50,
                    PrecisaDeCarro = false,
                    Descricao = "Gaiola de madeira de Pinus estilo meia - lua com fibra branca.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });


                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiola M�dia",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 125.5,
                    QtdEmEstoque = 25,
                    PrecisaDeCarro = false,
                    Descricao = "Gaiola de madeira de Pinus estilo meia - lua com fibra branca.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Comedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 4.5,
                    QtdEmEstoque = 85,
                    PrecisaDeCarro = false,
                    Descricao = "Indicado para p�ssaros. Comedouro oval com gancho",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Comedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 6.9,
                    QtdEmEstoque = 95,
                    PrecisaDeCarro = false,
                    Descricao = "Indicado para p�ssaros. Comedouro oval com gancho",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });


                _context.Produto.Add(new Produto()
                {
                    Nome = "Bebedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 4.9,
                    QtdEmEstoque = 84,
                    PrecisaDeCarro = false,
                    Descricao = "Para manter o seu p�ssaro hidratado.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });


                _context.Produto.Add(new Produto()
                {
                    Nome = "Bebedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 6.5,
                    QtdEmEstoque = 87,
                    PrecisaDeCarro = false,
                    Descricao = "Para manter o seu p�ssaro hidratado.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });


                _context.Produto.Add(new Produto()
                {
                    Nome = "Bebedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 7.9,
                    QtdEmEstoque = 90,
                    PrecisaDeCarro = false,
                    Descricao = "Para manter o seu p�ssaro hidratado.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });



                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de Ra��o",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 16,
                    QtdEmEstoque = 86,
                    PrecisaDeCarro = false,
                    Descricao = "Produzido em a�o inoxid�vel, comedouro resistente a mordidas e a desgastes naturais.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de Ra��o",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 17.9,
                    QtdEmEstoque = 92,
                    PrecisaDeCarro = false,
                    Descricao = "Produzido em a�o inoxid�vel, comedouro resistente a mordidas e a desgastes naturais.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de �gua",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Bebedouro resistente. Evita que seu pet molhe os pelos e as orelhas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de �gua",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 34.9,
                    QtdEmEstoque = 94,
                    PrecisaDeCarro = false,
                    Descricao = "Bebedouro resistente. Evita que seu pet molhe os pelos e as orelhas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de �gua",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 33,
                    QtdEmEstoque = 100,
                    PrecisaDeCarro = false,
                    Descricao = "Bebedouro resistente. Evita que seu pet molhe os pelos e as orelhas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de Ra��o",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 15.99,
                    QtdEmEstoque = 328,
                    PrecisaDeCarro = false,
                    Descricao = "Contornos internos curvos e sem arestas para que os gatos possam lamber tudo facilmente;.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de Ra��o",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 14.49,
                    QtdEmEstoque = 323,
                    PrecisaDeCarro = false,
                    Descricao = "Contornos internos curvos e sem arestas para que os gatos possam lamber tudo facilmente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de �gua",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 16,
                    QtdEmEstoque = 74,
                    PrecisaDeCarro = false,
                    Descricao = "Bebedouro resistente. Evita que seu pet molhe os pelos e as orelhas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de �gua",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 15.5,
                    QtdEmEstoque = 87,
                    PrecisaDeCarro = false,
                    Descricao = "Bebedouro resistente. Evita que seu pet molhe os pelos e as orelhas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de �gua",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 14.9,
                    QtdEmEstoque = 82,
                    PrecisaDeCarro = false,
                    Descricao = "Bebedouro resistente. Evita que seu pet molhe os pelos e as orelhas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Comedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 14,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Indicado para Roedores, pr�tico e f�cil de limpar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Comedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 16.9,
                    QtdEmEstoque = 71,
                    PrecisaDeCarro = false,
                    Descricao = "Indicado para Roedores, pr�tico e f�cil de limpar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bebedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 13.5,
                    QtdEmEstoque = 85,
                    PrecisaDeCarro = false,
                    Descricao = "Mant�m a �gua limpa e fresca.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });


                _context.Produto.Add(new Produto()
                {
                    Nome = "Bebedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 12.9,
                    QtdEmEstoque = 98,
                    PrecisaDeCarro = false,
                    Descricao = "Mant�m a �gua limpa e fresca.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bebedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 14.5,
                    QtdEmEstoque = 97,
                    PrecisaDeCarro = false,
                    Descricao = "Mant�m a �gua limpa e fresca.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Comedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 13.99,
                    QtdEmEstoque = 15,
                    PrecisaDeCarro = false,
                    Descricao = "Indicado para coelhos, pr�tico e f�cil de limpar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Comedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 12.49,
                    QtdEmEstoque = 35,
                    PrecisaDeCarro = false,
                    Descricao = "Indicado para coelhos, pr�tico e f�cil de limpar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bebedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 14.59,
                    QtdEmEstoque = 85,
                    PrecisaDeCarro = false,
                    Descricao = "Bebedouro resistente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bebedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 16.8,
                    QtdEmEstoque = 74,
                    PrecisaDeCarro = false,
                    Descricao = "Bebedouro resistente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bebedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 15.9,
                    QtdEmEstoque = 71,
                    PrecisaDeCarro = false,
                    Descricao = "Bebedouro resistente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Comedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 35.9,
                    QtdEmEstoque = 75,
                    PrecisaDeCarro = false,
                    Descricao = "Indicado para r�pteis. Fabricados em material de alta resist�ncia e qualidade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Comedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 38.49,
                    QtdEmEstoque = 79,
                    PrecisaDeCarro = false,
                    Descricao = "Indicado para r�pteis. Fabricados em material de alta resist�ncia e qualidade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bebedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 39.99,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Bebedouro indicado para r�pteis de f�cil higieniza��o.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bebedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 42.9,
                    QtdEmEstoque = 47,
                    PrecisaDeCarro = false,
                    Descricao = "Bebedouro indicado para r�pteis de f�cil higieniza��o.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bebedouros",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 41.5,
                    QtdEmEstoque = 42,
                    PrecisaDeCarro = false,
                    Descricao = "Bebedouro indicado para r�pteis de f�cil higieniza��o.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiolas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 95,
                    QtdEmEstoque = 45,
                    PrecisaDeCarro = false,
                    Descricao = "Gaiola desmont�vel com aramado em epoxi branco.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiolas",
                    Marca = "Amarelo",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 96.9,
                    QtdEmEstoque = 55,
                    PrecisaDeCarro = false,
                    Descricao = "Gaiola desmont�vel com aramado em epoxi branco.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });
            
                //*********************************** MARCA VERMELHA - SARA ***********************************
                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o grande porte 2Kg",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 25,
                    QtdEmEstoque = 412,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o de �tima qualidade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o grande porte 2Kg",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 30,
                    QtdEmEstoque = 30,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o para fortalecer os ossos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o 15Kg",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 65.50,
                    QtdEmEstoque = 100,
                    PrecisaDeCarro = true,
                    Descricao = "Ra��o super premiun.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o 15Kg",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 70,
                    QtdEmEstoque = 110,
                    PrecisaDeCarro = true,
                    Descricao = "Ra��o super premiun para seu cachorro. Ajuda nos ossos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o m�dio porte 2Kg",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 23.50,
                    QtdEmEstoque = 100,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o super premiun para gatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o m�dio porte 2Kg",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 24,
                    QtdEmEstoque = 150,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o natural para gatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Mistura de sementes Roedores",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 16.30,
                    QtdEmEstoque = 251,
                    PrecisaDeCarro = false,
                    Descricao = "Mistura de sementes para seu Roedor ficar feliz.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 1Kg",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 30,
                    QtdEmEstoque = 326,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o extrusada para lagartos diversos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 500g",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 26.99,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o completa e equilibrada para seu coelho.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o granulada 250g",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 25.39,
                    QtdEmEstoque = 230,
                    PrecisaDeCarro = false,
                    Descricao = "Alimento para peixes carn�voros.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 5,
                    QtdEmEstoque = 412,
                    PrecisaDeCarro = false,
                    Descricao = "Petisco delicioso para seu c�o.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 6,
                    QtdEmEstoque = 400,
                    PrecisaDeCarro = false,
                    Descricao = "Petisco delicioso para seu gato.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 86,
                    QtdEmEstoque = 185,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio para pulga e carrapato de alta qualidade e efici�ncia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 80,
                    QtdEmEstoque = 187,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio para pulga e carrapato de alta qualidade e efici�ncia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 45,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "Verm�fugo ideal no tratamento contra vermes chatos e redondos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 30,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Verm�fugo ideal no tratamento contra vermes chatos e redondos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 20,
                    QtdEmEstoque = 185,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para intoxica��es de c�es, gatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 22,
                    QtdEmEstoque = 180,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para intoxica��es de c�es, gatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 79.8,
                    QtdEmEstoque = 201,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para auxiliar no equil�brio da microbiota intestinal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 80,
                    QtdEmEstoque = 220,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para auxiliar no equil�brio da microbiota intestinal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 31.5,
                    QtdEmEstoque = 196,
                    PrecisaDeCarro = false,
                    Descricao = "Usado para eliminar a sarna do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 32,
                    QtdEmEstoque = 190,
                    PrecisaDeCarro = false,
                    Descricao = "Usado para combater queimaduras.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 30,
                    QtdEmEstoque = 100,
                    PrecisaDeCarro = false,
                    Descricao = "Usado para acabar com as assaduras do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 24,
                    QtdEmEstoque = 50,
                    PrecisaDeCarro = false,
                    Descricao = "Usado para tirar a sarna.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 12,
                    QtdEmEstoque = 150,
                    PrecisaDeCarro = false,
                    Descricao = "Ameniza as dores e as inflama��es.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 10,
                    QtdEmEstoque = 60,
                    PrecisaDeCarro = false,
                    Descricao = "Cicatriza as feridas",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 50,
                    QtdEmEstoque = 121,
                    PrecisaDeCarro = false,
                    Descricao = "Combate infec��es bacterianas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 26,
                    QtdEmEstoque = 199,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda na diminui��o de pelos em excesso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 24,
                    QtdEmEstoque = 119,
                    PrecisaDeCarro = false,
                    Descricao = "Aumenta a imunidade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 40,
                    QtdEmEstoque = 110,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda no desenvolvimento muscular.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 65,
                    QtdEmEstoque = 90,
                    PrecisaDeCarro = false,
                    Descricao = "Auxilia na preven��o de problemas �sseos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 44,
                    QtdEmEstoque = 130,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a prevenir problemas dent�rios.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 66,
                    QtdEmEstoque = 111,
                    PrecisaDeCarro = false,
                    Descricao = "Aumenta a energia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 88,
                    QtdEmEstoque = 131,
                    PrecisaDeCarro = false,
                    Descricao = " Ajuda a prevenir problemas digestivos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tapete higi�nico",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 34,
                    QtdEmEstoque = 165,
                    PrecisaDeCarro = false,
                    Descricao = "Absor��o ultra r�pida.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Banheiros para cachorros",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 85,
                    QtdEmEstoque = 25,
                    PrecisaDeCarro = false,
                    Descricao = "Mantem o local higienizado.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coletor de fezes",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 18.99,
                    QtdEmEstoque = 45,
                    PrecisaDeCarro = false,
                    Descricao = "Facilita o recolhimento dos dejetos do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 29.6,
                    QtdEmEstoque = 95,
                    PrecisaDeCarro = false,
                    Descricao = "Cheiro de melancia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 30,
                    QtdEmEstoque = 90,
                    PrecisaDeCarro = false,
                    Descricao = "Deixa os pelos macios.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de unha",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 31,
                    QtdEmEstoque = 88,
                    PrecisaDeCarro = false,
                    Descricao = "Cortador super afiado.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 20,
                    QtdEmEstoque = 100,
                    PrecisaDeCarro = false,
                    Descricao = "Cortador para unhas duras.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sabonete",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 19.9,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Sabonete com cheiro de rosas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sabonete",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 25,
                    QtdEmEstoque = 120,
                    PrecisaDeCarro = false,
                    Descricao = "Sabonete l�quido ideal para limpeza da pelagem.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova Rasqueadeira",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36.5,
                    QtdEmEstoque = 165,
                    PrecisaDeCarro = false,
                    Descricao = "Remove os pelos mortos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova Rasqueadeira",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 37,
                    QtdEmEstoque = 160,
                    PrecisaDeCarro = false,
                    Descricao = "Facilita na escova��o do pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de Areia",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 111,
                    PrecisaDeCarro = false,
                    Descricao = "Tamanho m�dio com grande profundidade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Areia higi�nica",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 26,
                    QtdEmEstoque = 120,
                    PrecisaDeCarro = false,
                    Descricao = "Melhora o controle de odores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pazinha Coletora",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 4.1,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Aumenta a praticidade na coleta de fezes.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "P� de Banho",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 22,
                    QtdEmEstoque = 68,
                    PrecisaDeCarro = false,
                    Descricao = "P� de Banho a seco para manter seus Roedores limpos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bolinhas",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 12,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Feita de Borracha",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ossinhoss",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 14.5,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda na limpeza bucal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ratinho",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 6,
                    QtdEmEstoque = 159,
                    PrecisaDeCarro = false,
                    Descricao = "Ratinho de pelucia para divers�o do seu gato.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Varinhass",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 15.6,
                    QtdEmEstoque = 185,
                    PrecisaDeCarro = false,
                    Descricao = "Varinhas com cord�es.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Arranhadoreses",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 99,
                    QtdEmEstoque = 14,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a lixar as unhas do pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "pets de Pel�cia",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 48,
                    QtdEmEstoque = 52,
                    PrecisaDeCarro = false,
                    Descricao = "Divertido e criativo que ajuda a combater o estresse do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "pets de Pel�cia",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 50,
                    QtdEmEstoque = 60,
                    PrecisaDeCarro = false,
                    Descricao = "Divertido e criativo que ajuda a combater o estresse do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Mordedores",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 19.5,
                    QtdEmEstoque = 76,
                    PrecisaDeCarro = false,
                    Descricao = "Feito de silicone.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Balan�oss",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 19.5,
                    QtdEmEstoque = 12,
                    PrecisaDeCarro = false,
                    Descricao = "Balan�os m�dio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Trap�zioss",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 21,
                    QtdEmEstoque = 26,
                    PrecisaDeCarro = false,
                    Descricao = "Trap�zios grande.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escadas",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 30,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Escada de madeiras para p�ssaros de porte m�dio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Argolas",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 20,
                    QtdEmEstoque = 62,
                    PrecisaDeCarro = false,
                    Descricao = "Argolas M�dias de Balan�os.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cabanas",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 24,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Cabana Pequena para p�ssaros de pequeno porte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Espiral",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 23,
                    QtdEmEstoque = 30,
                    PrecisaDeCarro = false,
                    Descricao = "Feito para entreter a ave e aliviar o estresse.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roda de Exerc�cio",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 34,
                    QtdEmEstoque = 14,
                    PrecisaDeCarro = false,
                    Descricao = "Roda naturalmente silenciosa e leve.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roedor",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 22,
                    QtdEmEstoque = 45,
                    PrecisaDeCarro = false,
                    Descricao = "Tranquiliza o pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roedor",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25,
                    QtdEmEstoque = 50,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda na limpeza dental.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra Mineral",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 8.5,
                    QtdEmEstoque = 75,
                    PrecisaDeCarro = false,
                    Descricao = "Desenvolvida especialmente para atender a necessidade de roer de coelhos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra mineral",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 9,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Feita especialmente para atender a necessidade dos Roedores de roer para desgastar os dentes.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra mineral",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 10,
                    QtdEmEstoque = 50,
                    PrecisaDeCarro = false,
                    Descricao = "Melhora as fun��es do aparelho digestivo.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "T�nel",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25,
                    QtdEmEstoque = 66,
                    PrecisaDeCarro = false,
                    Descricao = "T�neis feitos para a distra��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "T�nel",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 21,
                    QtdEmEstoque = 70,
                    PrecisaDeCarro = false,
                    Descricao = "T�nel m�dio feito de poli�ster dur�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tubos",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 19,
                    QtdEmEstoque = 68,
                    PrecisaDeCarro = false,
                    Descricao = "�timos para seu pet fazer exerc�cios.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho P",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 45,
                    QtdEmEstoque = 300,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 25,
                    QtdEmEstoque = 412,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira super resistente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho G",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 65.50,
                    QtdEmEstoque = 100,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira confort�vel para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho P",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 19.90,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com seu gato.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho G",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 40.99,
                    QtdEmEstoque = 100,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira com peitoral.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Focinheira Tamanho P",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 26.30,
                    QtdEmEstoque = 350,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu c�o usar pela prote��o das pessoas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de transporte M�dia",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36.90,
                    QtdEmEstoque = 230,
                    PrecisaDeCarro = false,
                    Descricao = "Uma forma pr�tica de transportar seu cachorro de um lugar para o outro de forma segura.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de transporte Pequena",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 25.90,
                    QtdEmEstoque = 210,
                    PrecisaDeCarro = false,
                    Descricao = "Uma forma pr�tica de transportar seu gato de um lugar para o outro de forma segura.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caminha M�dia",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 39.99,
                    QtdEmEstoque = 132,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu cachorro dormir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caminha Pequena",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 29,
                    QtdEmEstoque = 321,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu gato descansar confortvelmente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Filtro Interno",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 45,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Melhora a qualidade da �gua do seu aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Substrato",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 5.50,
                    QtdEmEstoque = 102,
                    PrecisaDeCarro = false,
                    Descricao = "Decora o fundo do seu aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio de 1L",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 25.90,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Aqu�rio de vidro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "L�mpada para Aqu�rio",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 86.90,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Para plantas aqu�ticas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Termostato para Aqu�rio",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 67.99,
                    QtdEmEstoque = 55,
                    PrecisaDeCarro = false,
                    Descricao = "Aquece seu aqu�rio e mant�m uma temperatura est�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Rocha Decorativa",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 43.99,
                    QtdEmEstoque = 44,
                    PrecisaDeCarro = false,
                    Descricao = "Decora o ambiente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Rocha Decorativa",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 45,
                    QtdEmEstoque = 55,
                    PrecisaDeCarro = false,
                    Descricao = "Rocha de tamanho m�dio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tronco Decorativo",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 27.99,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Decora o ambiente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tronco Decorativo",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 44,
                    QtdEmEstoque = 40,
                    PrecisaDeCarro = false,
                    Descricao = "Para decora��o",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Planta Artificial",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 15.90,
                    QtdEmEstoque = 85,
                    PrecisaDeCarro = false,
                    Descricao = "Cria um ambiente natural",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Planta Artificial",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 15,
                    QtdEmEstoque = 72,
                    PrecisaDeCarro = false,
                    Descricao = "Planta de tamanho pequeno.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sinf�o Manual",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 20.50,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda na limpeza do substrato do aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "M�dias Biol�gicas",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 25.60,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Cria as bact�rias necess�rias para melhorar seu aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Carv�o Ativo",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 25.30,
                    QtdEmEstoque = 38,
                    PrecisaDeCarro = false,
                    Descricao = "Tira o mau cheiro do aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Esponja Biol�gica",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 13.90,
                    QtdEmEstoque = 85,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda na filtragem de res�duos maiores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Refil para Filtro Externo",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 19.90,
                    QtdEmEstoque = 90,
                    PrecisaDeCarro = false,
                    Descricao = "Cont�m a manta acr�lica e o carv�o ativado.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiola Pequena",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 99.90,
                    QtdEmEstoque = 45,
                    PrecisaDeCarro = false,
                    Descricao = "Gaiola usada para transporte de aves.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Poleiro Pequeno",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 20,
                    QtdEmEstoque = 74,
                    PrecisaDeCarro = false,
                    Descricao = "Vara disposta horizontalmente em que as aves pousam e dormem.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Comedouros",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 5.90,
                    QtdEmEstoque = 69,
                    PrecisaDeCarro = false,
                    Descricao = "Pote de alimenta��o para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bebedouros",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 6,
                    QtdEmEstoque = 95,
                    PrecisaDeCarro = false,
                    Descricao = "Bebedor de pl�stico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de Ra��o",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30,
                    QtdEmEstoque = 74,
                    PrecisaDeCarro = false,
                    Descricao = "Pote de ra��o grande.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de �gua",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 20,
                    QtdEmEstoque = 74,
                    PrecisaDeCarro = false,
                    Descricao = "Pote de �gua grande para cachorros.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de Ra��o",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 25,
                    QtdEmEstoque = 45,
                    PrecisaDeCarro = false,
                    Descricao = "Pote de ra��o pequeno para gatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de �gua",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 26,
                    QtdEmEstoque = 46,
                    PrecisaDeCarro = false,
                    Descricao = "Pote de �gua pequeno para gatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Comedouros",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 15.90,
                    QtdEmEstoque = 45,
                    PrecisaDeCarro = false,
                    Descricao = "Pote de pl�stico para alimento.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bebedor",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 14.99,
                    QtdEmEstoque = 35,
                    PrecisaDeCarro = false,
                    Descricao = "Pote de pl�stico para �gua.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Comedouros",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 14.99,
                    QtdEmEstoque = 44,
                    PrecisaDeCarro = false,
                    Descricao = "Pote m�dio para alimento.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bebedouros",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 15,
                    QtdEmEstoque = 48,
                    PrecisaDeCarro = false,
                    Descricao = "Pote m�dio para �gua.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Comedouros",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 13.99,
                    QtdEmEstoque = 55,
                    PrecisaDeCarro = false,
                    Descricao = "Pote pequeno para alimento.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bebedouros",
                    Marca = "Vermelha",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 15.30,
                    QtdEmEstoque = 45,
                    PrecisaDeCarro = false,
                    Descricao = "Pote pequeno para �gua.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });
            
                //*********************************** MARCA VERDE - KAIO ***********************************

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o pequeno porte 2Kg ",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 22.9,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o perfeita para seu cachorro. Ela tem uma �tima qualidade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o pequeno porte 2Kg ",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 30,
                    QtdEmEstoque = 110,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o perfeita para seu cachorro. Ela tem uma �tima qualidade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o pequeno porte 2Kg ",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 35.5,
                    QtdEmEstoque = 120,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o perfeita para seu cachorro. Ela tem uma �tima qualidade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o m�dio porte 5kg ",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 45,
                    QtdEmEstoque = 300,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o super premiun para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o m�dio porte 5kg ",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 47,
                    QtdEmEstoque = 302,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o super premiun para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o m�dio porte 5kg ",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 55,
                    QtdEmEstoque = 330,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o super premiun para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o pequeno porte 2kg",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 20,
                    QtdEmEstoque = 410,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o super premiun para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o pequeno porte 2kg",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 25,
                    QtdEmEstoque = 401,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o super premiun para seu cachorro",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o pequeno porte 2kg",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 19.5,
                    QtdEmEstoque = 400,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o super premiun para seu cachorro",
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
                    Descricao = "Alimenta��o completa e saborosa.",
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
                    Descricao = "Alimenta��o completa e saborosa.",
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
                    Descricao = "Alimenta��o completa e saborosa.",
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
                    Descricao = "Alimenta��o completa e saborosa.",
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
                    Descricao = "Alimenta��o completa e saborosa.",
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
                    Descricao = "Alimenta��o completa e saborosa.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 500g",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 23.9,
                    QtdEmEstoque = 301,
                    PrecisaDeCarro = false,
                    Descricao = "Alimenta��o completa para seu Roedor.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 500g",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 25,
                    QtdEmEstoque = 300,
                    PrecisaDeCarro = false,
                    Descricao = "Alimenta��o completa para seu Roedor.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 500g",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 24.9,
                    QtdEmEstoque = 311,
                    PrecisaDeCarro = false,
                    Descricao = "Alimenta��o completa para seu Roedor.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adas.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 250g",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 32.9,
                    QtdEmEstoque = 310,
                    PrecisaDeCarro = false,
                    Descricao = "Alimenta��o completa para seu r�ptil.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adas.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 250g",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 30,
                    QtdEmEstoque = 301,
                    PrecisaDeCarro = false,
                    Descricao = "Alimenta��o completa para seu r�ptil.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adas.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 250g",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 30.5,
                    QtdEmEstoque = 300,
                    PrecisaDeCarro = false,
                    Descricao = "Alimenta��o completa para seu r�ptil.",
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
                    Descricao = "Alimento complementar e necess�rio para seu coelho.",
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
                    Descricao = "Alimento complementar e necess�rio para seu coelho.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adas.com.br").First()
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
                    Descricao = "Alimento complementar e necess�rio para seu coelho.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adas.com.br").First()
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
                    Descricao = "Alimento complementar e necess�rio para seu coelho.",
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
                    Descricao = "Alimento complementar e necess�rio para seu coelho.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o granulada 50g",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 10.9,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Alimento para peixes onivoros/herb�voros.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o granulada 50g",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 11.5,
                    QtdEmEstoque = 130,
                    PrecisaDeCarro = false,
                    Descricao = "Alimento para peixes onivoros/herb�voros.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o granulada 50g",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 10,
                    QtdEmEstoque = 131,
                    PrecisaDeCarro = false,
                    Descricao = "Alimento para peixes onivoros/herb�voros.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o granulada 50g",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 10.99,
                    QtdEmEstoque = 130,
                    PrecisaDeCarro = false,
                    Descricao = "Alimento para peixes onivoros/herb�voros.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o granulada 50g",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 12,
                    QtdEmEstoque = 120,
                    PrecisaDeCarro = false,
                    Descricao = "Alimento para peixes onivoros/herb�voros.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 2.99,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Para todo cachorro que mere�e uma recompensa.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 2.5,
                    QtdEmEstoque = 150,
                    PrecisaDeCarro = false,
                    Descricao = "Para todo cachorro que mere�e uma recompensa.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 2,
                    QtdEmEstoque = 126,
                    PrecisaDeCarro = false,
                    Descricao = "Para todo cachorro que mere�e uma recompensa.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 2.9,
                    QtdEmEstoque = 196,
                    PrecisaDeCarro = false,
                    Descricao = "Para todo cachorro que mere�e uma recompensa.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 3.5,
                    QtdEmEstoque = 199,
                    PrecisaDeCarro = false,
                    Descricao = "Para todo cachorro que mere�e uma recompensa.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 2.99,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Para todo gato que mere�e uma recompensa.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 2.9,
                    QtdEmEstoque = 160,
                    PrecisaDeCarro = false,
                    Descricao = "Para todo gato que mere�e uma recompensa.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 2.5,
                    QtdEmEstoque = 164,
                    PrecisaDeCarro = false,
                    Descricao = "Para todo gato que mere�e uma recompensa.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 2,
                    QtdEmEstoque = 151,
                    PrecisaDeCarro = false,
                    Descricao = "Para todo gato que mere�e uma recompensa.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 2,
                    QtdEmEstoque = 151,
                    PrecisaDeCarro = false,
                    Descricao = "Para todo gato que mere�e uma recompensa.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });
  
                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 75.5,
                    QtdEmEstoque = 196,
                    PrecisaDeCarro = false,
                    Descricao = "Al�vio total da coceira em 24 horas.Age diretamente no foco da coceira, minimizando os efeitos colaterais.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 75,
                    QtdEmEstoque = 160,
                    PrecisaDeCarro = false,
                    Descricao = "Al�vio total da coceira em 24 horas.Age diretamente no foco da coceira, minimizando os efeitos colaterais.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 75.9,
                    QtdEmEstoque = 198,
                    PrecisaDeCarro = false,
                    Descricao = "Al�vio total da coceira em 24 horas.Age diretamente no foco da coceira, minimizando os efeitos colaterais.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 74.9,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "Al�vio total da coceira em 24 horas. Age diretamente no foco da coceira, minimizando os efeitos colaterais.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 74.99,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "Al�vio total da coceira em 24 horas. Age diretamente no foco da coceira, minimizando os efeitos colaterais.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });
            
                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 75.5,
                    QtdEmEstoque = 196,
                    PrecisaDeCarro = false,
                    Descricao = "Trata infesta��es de pulgas e carrapatos. Elimina os parasitas rapidamente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 75.9,
                    QtdEmEstoque = 198,
                    PrecisaDeCarro = false,
                    Descricao = "Trata infesta��es de pulgas e carrapatos. Elimina os parasitas rapidamente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 75,
                    QtdEmEstoque = 185,
                    PrecisaDeCarro = false,
                    Descricao = "Trata infesta��es de pulgas e carrapatos. Elimina os parasitas rapidamente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 74.99,
                    QtdEmEstoque = 191,
                    PrecisaDeCarro = false,
                    Descricao = "Trata infesta��es de pulgas e carrapatos. Elimina os parasitas rapidamente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 75.99,
                    QtdEmEstoque = 198,
                    PrecisaDeCarro = false,
                    Descricao = "Trata infesta��es de pulgas e carrapatos. Elimina os parasitas rapidamente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });
             
                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 30.5,
                    QtdEmEstoque = 196,
                    PrecisaDeCarro = false,
                    Descricao = "Verm�fugo palat�vel de f�cil administra��o.  Eficaz no tratamento contra vermes redondos e chatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 35,
                    QtdEmEstoque = 198,
                    PrecisaDeCarro = false,
                    Descricao = "Verm�fugo palat�vel de f�cil administra��o.  Eficaz no tratamento contra vermes redondos e chatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 75,
                    QtdEmEstoque = 199,
                    PrecisaDeCarro = false,
                    Descricao = "Verm�fugo palat�vel de f�cil administra��o.  Eficaz no tratamento contra vermes redondos e chatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 36.5,
                    QtdEmEstoque = 190,
                    PrecisaDeCarro = false,
                    Descricao = "Verm�fugo palat�vel de f�cil administra��o.  Eficaz no tratamento contra vermes redondos e chatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 36.9,
                    QtdEmEstoque = 191,
                    PrecisaDeCarro = false,
                    Descricao = "Verm�fugo palat�vel de f�cil administra��o.  Eficaz no tratamento contra vermes redondos e chatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });
              
                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 30.5,
                    QtdEmEstoque = 196,
                    PrecisaDeCarro = false,
                    Descricao = "Verm�fugo palat�vel de f�cil administra��o.  Eficaz no tratamento contra vermes redondos e chatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 36,
                    QtdEmEstoque = 192,
                    PrecisaDeCarro = false,
                    Descricao = "Verm�fugo palat�vel de f�cil administra��o.  Eficaz no tratamento contra vermes redondos e chatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37.9,
                    QtdEmEstoque = 185,
                    PrecisaDeCarro = false,
                    Descricao = "Verm�fugo palat�vel de f�cil administra��o.  Eficaz no tratamento contra vermes redondos e chatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 30,
                    QtdEmEstoque = 191,
                    PrecisaDeCarro = false,
                    Descricao = "Verm�fugo palat�vel de f�cil administra��o.  Eficaz no tratamento contra vermes redondos e chatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 30.55,
                    QtdEmEstoque = 195,
                    PrecisaDeCarro = false,
                    Descricao = "Verm�fugo palat�vel de f�cil administra��o.  Eficaz no tratamento contra vermes redondos e chatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });
                
                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 27.5,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Auxilia no tratamento das afec��es hep�ticas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38,
                    QtdEmEstoque = 146,
                    PrecisaDeCarro = false,
                    Descricao = "Auxilia no tratamento das afec��es hep�ticas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 30,
                    QtdEmEstoque = 130,
                    PrecisaDeCarro = false,
                    Descricao = "Auxilia no tratamento das afec��es hep�ticas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 27,
                    QtdEmEstoque = 126,
                    PrecisaDeCarro = false,
                    Descricao = "Auxilia no tratamento das afec��es hep�ticas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 27.9,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Auxilia no tratamento das afec��es hep�ticas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });
              
                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 27.5,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Associa��o de agentes lipotr�picos e antit�xicos em ve�culo energ�tico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 28,
                    QtdEmEstoque = 135,
                    PrecisaDeCarro = false,
                    Descricao = "Associa��o de agentes lipotr�picos e antit�xicos em ve�culo energ�tico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 30,
                    QtdEmEstoque = 130,
                    PrecisaDeCarro = false,
                    Descricao = "Associa��o de agentes lipotr�picos e antit�xicos em ve�culo energ�tico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 27.5,
                    QtdEmEstoque = 130,
                    PrecisaDeCarro = false,
                    Descricao = "Associa��o de agentes lipotr�picos e antit�xicos em ve�culo energ�tico",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });
                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 27.9,
                    QtdEmEstoque = 131,
                    PrecisaDeCarro = false,
                    Descricao = "Associa��o de agentes lipotr�picos e antit�xicos em ve�culo energ�tico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });
               
                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 90.5,
                    QtdEmEstoque = 163,
                    PrecisaDeCarro = false,
                    Descricao = "Composto por Lactobaccilus vivos. Auxilia na manuten��o da flora intestinal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 95,
                    QtdEmEstoque = 167,
                    PrecisaDeCarro = false,
                    Descricao = "Composto por Lactobaccilus vivos. Auxilia na manuten��o da flora intestinal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 90.9,
                    QtdEmEstoque = 160,
                    PrecisaDeCarro = false,
                    Descricao = "Composto por Lactobaccilus vivos. Auxilia na manuten��o da flora intestinal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 92,
                    QtdEmEstoque = 153,
                    PrecisaDeCarro = false,
                    Descricao = "Composto por Lactobaccilus vivos. Auxilia na manuten��o da flora intestinal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 92.5,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Composto por Lactobaccilus vivos. Auxilia na manuten��o da flora intestinal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });
                
                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 90.5,
                    QtdEmEstoque = 163,
                    PrecisaDeCarro = false,
                    Descricao = "Composto por Lactobaccilus vivos. Auxilia na manuten��o da flora intestinal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 90.5,
                    QtdEmEstoque = 160,
                    PrecisaDeCarro = false,
                    Descricao = "Composto por Lactobaccilus vivos. Auxilia na manuten��o da flora intestinal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 91.4,
                    QtdEmEstoque = 162,
                    PrecisaDeCarro = false,
                    Descricao = "Composto por Lactobaccilus vivos. Auxilia na manuten��o da flora intestinal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 95,
                    QtdEmEstoque = 162,
                    PrecisaDeCarro = false,
                    Descricao = "Composto por Lactobaccilus vivos. Auxilia na manuten��o da flora intestinal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 9.95,
                    QtdEmEstoque = 166,
                    PrecisaDeCarro = false,
                    Descricao = "Composto por Lactobaccilus vivos. Auxilia na manuten��o da flora intestinal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });
                
                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 36.5,
                    QtdEmEstoque = 185,
                    PrecisaDeCarro = false,
                    Descricao = "Para assaduras.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 147,
                    PrecisaDeCarro = false,
                    Descricao = "Para sarar o machucado mais r�pido.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37.5,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Para passar em peles sens�veis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38,
                    QtdEmEstoque = 126,
                    PrecisaDeCarro = false,
                    Descricao = "Usado para passar em p�s cirurgia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38.9,
                    QtdEmEstoque = 162,
                    PrecisaDeCarro = false,
                    Descricao = "Usado para passar em p�s cirurgia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 185,
                    PrecisaDeCarro = false,
                    Descricao = "Para assaduras.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); _context.Produto.Add(new Produto()

                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37.5,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "Para sarar o machucado mais r�pido.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); _context.Produto.Add(new Produto()

                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38,
                    QtdEmEstoque = 167,
                    PrecisaDeCarro = false,
                    Descricao = "Para passar em peles sens�veis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38.9,
                    QtdEmEstoque = 147,
                    PrecisaDeCarro = false,
                    Descricao = "Usado para passar em p�s cirurgia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38.5,
                    QtdEmEstoque = 140,
                    PrecisaDeCarro = false,
                    Descricao = "Usado para passar em p�s cirurgia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });
            
                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 36.9,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Usado para passar em p�s cirurgia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "Usado para passar em p�s cirurgia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37.9,
                    QtdEmEstoque = 155,
                    PrecisaDeCarro = false,
                    Descricao = "Para passar em peles sens�veis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38,
                    QtdEmEstoque = 111,
                    PrecisaDeCarro = false,
                    Descricao = "Para sarar o machucado mais r�pido.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 40,
                    QtdEmEstoque = 101,
                    PrecisaDeCarro = false,
                    Descricao = "Para usar em assaduras.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });
                
                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 185,
                    PrecisaDeCarro = false,
                    Descricao = "Para usar em assaduras.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37.6,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Para sarar o machucado mais r�pido.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 36.9,
                    QtdEmEstoque = 183,
                    PrecisaDeCarro = false,
                    Descricao = "Para passar em peles sens�veis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 39,
                    QtdEmEstoque = 178,
                    PrecisaDeCarro = false,
                    Descricao = "Usado para passar em p�s cirurgia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38.9,
                    QtdEmEstoque = 169,
                    PrecisaDeCarro = false,
                    Descricao = "Para passar em peles sens�veis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });
                
                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Para usar em assaduras.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37.9,
                    QtdEmEstoque = 178,
                    PrecisaDeCarro = false,
                    Descricao = "Para passar em machucados.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Passar em queimadura.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 39,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Fixa nas esCamas do seu pet. Aprova d'�gua.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38.5,
                    QtdEmEstoque = 147,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda o seu pet na trca de pele, amolecendo a pele antiga.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });
                
                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38.5,
                    QtdEmEstoque = 147,
                    PrecisaDeCarro = false,
                    Descricao = "Para passar na parte lesionada do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 39,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Aprova d'�gua.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Passar em queimadura.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37.9,
                    QtdEmEstoque = 178,
                    PrecisaDeCarro = false,
                    Descricao = "Para passar em machucados.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomadas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Para usarm em assaduras.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });
               
                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 27.5,
                    QtdEmEstoque = 148,
                    PrecisaDeCarro = false,
                    Descricao = "Retarda o envelhecimento celular.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 28,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Protege as fun��es renal e card�aca.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 24,
                    QtdEmEstoque = 140,
                    PrecisaDeCarro = false,
                    Descricao = "Suplemento nutricional indicado para c�es de qualquer idade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 30,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Reduz a queda e a quebra dos fios.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 32,
                    QtdEmEstoque = 148,
                    PrecisaDeCarro = false,
                    Descricao = "Rico em prote�nas, amino�cidos, minerais e vitaminas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });
                
                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 29,
                    QtdEmEstoque = 178,
                    PrecisaDeCarro = false,
                    Descricao = "Auxilia no crescimento do pelo, at� em partes lesionadas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 30.5,
                    QtdEmEstoque = 165,
                    PrecisaDeCarro = false,
                    Descricao = "Favorece a elimina��o das bolas de pelo.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 36,
                    QtdEmEstoque = 159,
                    PrecisaDeCarro = false,
                    Descricao = "Suplemento alimentar para gatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 45,
                    QtdEmEstoque = 189,
                    PrecisaDeCarro = false,
                    Descricao = "Aumenta o apetite.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38,
                    QtdEmEstoque = 148,
                    PrecisaDeCarro = false,
                    Descricao = "Suplemento � base de amino�cidos e vitaminas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tapete higi�nico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 44.9,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Ultra absor��o.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tapete higi�nico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 44,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "N�o deixa odor.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tapete higi�nico",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 46,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "F�cil limpeza.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coletor de fezes",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 23,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "Pl�stico resist�nte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coletor de fezes",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 24.5,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Para coletar as fezes do seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coletor de fezes",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 26,
                    QtdEmEstoque = 148,
                    PrecisaDeCarro = false,
                    Descricao = "Imperme�vel. Cont�m 4 rolos com 20 saquinhos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 35.9,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "2 em 1. Cont�m �leo de am�ndoas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36.5,
                    QtdEmEstoque = 147,
                    PrecisaDeCarro = false,
                    Descricao = " Produz brilho e maciez ao pelos. Deixa f�cil para escova��o.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });
                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 39,
                    QtdEmEstoque = 185,
                    PrecisaDeCarro = false,
                    Descricao = "Desenvolvido para proporcionar maciez e brilho para c�es de todas as ra�as.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36.9,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Desenvolvido para cuidar com carinho dos felinos que tem uma pele sens�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 39.9,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = " Foi criada para deixar o seu pet com um perfume suave e duradouro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 40,
                    QtdEmEstoque = 185,
                    PrecisaDeCarro = false,
                    Descricao = "Sua composi��o � feita com ingredientes que hidratam o p�lo do animal.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });
                
                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de unhas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 25.9,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "A�o Inox e emborrachado.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de unhas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 196,
                    PrecisaDeCarro = false,
                    Descricao = "Produto at�xico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de unhas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 25.9,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Com trava de seguran�a.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de unhas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 147,
                    PrecisaDeCarro = false,
                    Descricao = "Para higiene e beleza.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de unhas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 35.8,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "A�o inox e emborrachado.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de unhas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 25.99,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Produto at�xico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });
               
                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova rasqueira",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 25.99,
                    QtdEmEstoque = 155,
                    PrecisaDeCarro = false,
                    Descricao = "Tira os pelos mortos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova rasqueira",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Leve e f�cil de usar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova rasqueira",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 40,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Desembola pelo sem sofrimento.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });
                
                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova rasqueira",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 39,
                    QtdEmEstoque = 150,
                    PrecisaDeCarro = false,
                    Descricao = "Tira os pelos mortos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova rasqueira",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 25.99,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Leve e f�cil de usar..",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova rasqueira",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 25.99,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Desembola pelo sem sofrimento.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });
             
                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de areia",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 25.99,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "F�cil de limpar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de areia",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 30,
                    QtdEmEstoque = 150,
                    PrecisaDeCarro = false,
                    Descricao = "�tima durabilidade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de areia",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 116,
                    PrecisaDeCarro = false,
                    Descricao = "Vem com 3 bandejas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });
              
                _context.Produto.Add(new Produto()
                {
                    Nome = "Areia higi�nica",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 23,
                    QtdEmEstoque = 230,
                    PrecisaDeCarro = false,
                    Descricao = "Gr�os super finos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Areia higi�nica",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 12.55,
                    QtdEmEstoque = 111,
                    PrecisaDeCarro = false,
                    Descricao = "Elimina os odores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Areia higi�nica",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 158,
                    PrecisaDeCarro = false,
                    Descricao = "Econ�mica: rende mais.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });
                
                _context.Produto.Add(new Produto()
                {
                    Nome = "P� de Banho",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 24.5,
                    QtdEmEstoque = 158,
                    PrecisaDeCarro = false,
                    Descricao = "Econ�mica: rende mais.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "P� de Banho",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 16.5,
                    QtdEmEstoque = 150,
                    PrecisaDeCarro = false,
                    Descricao = "Para peles sens�veis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "P� de Banho",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 18,
                    QtdEmEstoque = 155,
                    PrecisaDeCarro = false,
                    Descricao = "Deixa seu pet cheiroso e com pelos brilhantes.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });
           
                _context.Produto.Add(new Produto()
                {
                    Nome = "Bolinhas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 12.5,
                    QtdEmEstoque = 165,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� se divertir com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bolinhas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 13,
                    QtdEmEstoque = 155,
                    PrecisaDeCarro = false,
                    Descricao = "Brinquedo n�o t�xico para a seguran�a do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bolinhas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 11.5,
                    QtdEmEstoque = 144,
                    PrecisaDeCarro = false,
                    Descricao = "Foi produzida em 100% vinil, material n�o t�xico de alta qualidade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });
               
                _context.Produto.Add(new Produto()
                {
                    Nome = "Ossinhos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 12,
                    QtdEmEstoque = 111,
                    PrecisaDeCarro = false,
                    Descricao = "N�o desgasta os dentes.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ossinhos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 12,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Com alto n�vel de resist�ncia.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });
                _context.Produto.Add(new Produto()
                {
                    Nome = "Ossinhos",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 13,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "O brinquedo certo para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });
                
                _context.Produto.Add(new Produto()
                {
                    Nome = "Ratinho",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 9,
                    QtdEmEstoque = 112,
                    PrecisaDeCarro = false,
                    Descricao = "Ratinho e Bolinhas, melhor distrativo para gatos.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;
                _context.Produto.Add(new Produto()
                {
                    Nome = "Ratinho",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 10.5,
                    QtdEmEstoque = 132,
                    PrecisaDeCarro = false,
                    Descricao = "Material de qualidade e resistente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });
                _context.Produto.Add(new Produto()
                {
                    Nome = "Ratinho",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 11,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Ideal para aliviar o estresse.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });
             
                _context.Produto.Add(new Produto()
                {
                    Nome = "Arranhadores",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 65.5,
                    QtdEmEstoque = 90,
                    PrecisaDeCarro = false,
                    Descricao = "Feito de papel�o, ideal para o seu gato manter-se ocupado e com as unhas igualadas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Arranhadores",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 96.5,
                    QtdEmEstoque = 100,
                    PrecisaDeCarro = false,
                    Descricao = "Possui Bolinhas que aumentam a brincadeira.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Arranhadores",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 99.9,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Tem o �ngulo perfeito para seu pet se acalmar e n�o arranhar mais seu sof�.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });
               
                _context.Produto.Add(new Produto()
                {
                    Nome = "Balan�os",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25.5,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "Fabricado em madeira pinus, plastico,esculpido a fogo, materiais de altissima qualidade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Balan�os",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 24.99,
                    QtdEmEstoque = 141,
                    PrecisaDeCarro = false,
                    Descricao = "Fabricado em madeira pinus, plastico,esculpido a fogo, materiais de altissima qualidade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Balan�os",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 26,
                    QtdEmEstoque = 162,
                    PrecisaDeCarro = false,
                    Descricao = "Fabricado em madeira pinus, plastico,esculpido a fogo, materiais de altissima qualidade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });
         
                _context.Produto.Add(new Produto()
                {
                    Nome = "Argolas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 15,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda no desgaste natural o bico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Argolas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 14.5,
                    QtdEmEstoque = 112,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda no desgaste natural o bico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Argolas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 15.9,
                    QtdEmEstoque = 152,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda no desgaste natural o bico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "@adaspet.com.br").First()
                });
              
                _context.Produto.Add(new Produto()
                {
                    Nome = "Roda de exerc�cio",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 33.5,
                    QtdEmEstoque = 141,
                    PrecisaDeCarro = false,
                    Descricao = "Perfeito para distrair seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roda de exerc�cio",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 30.5,
                    QtdEmEstoque = 124,
                    PrecisaDeCarro = false,
                    Descricao = "Produto pode haver varia��o de cores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roda de exerc�cio",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 34,
                    QtdEmEstoque = 147,
                    PrecisaDeCarro = false,
                    Descricao = "Acess�rio para seu pet se exercitar e brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });
              
                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho P",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 22.9,
                    QtdEmEstoque = 147,
                    PrecisaDeCarro = false,
                    Descricao = "Nylon com fivelas pl�sticas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho P",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 50,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Resistente e confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho P",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 45,
                    QtdEmEstoque = 150,
                    PrecisaDeCarro = false,
                    Descricao = "Regul�vel para um ajuste perfeito.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });
              
                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 35.5,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Fecho de seguran�a anti-enforcamento.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 33.9,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Material de qualidade e costura refor�ada.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30.99,
                    QtdEmEstoque = 110,
                    PrecisaDeCarro = false,
                    Descricao = "Regul�vel para um ajuste perfeito.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });
         
                _context.Produto.Add(new Produto()
                {
                    Nome = "Focinheira Tamanho G",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 60,
                    QtdEmEstoque = 90,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� ultilizar pela seguran�a das pessoas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Focinheira Tamanho G",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 65,
                    QtdEmEstoque = 52,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� ultilizar pela seguran�a das pessoas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "�thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de transporte grande",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 40.9,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = true,
                    Descricao = "Transporte seu pet com seguran�a.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de transporte grande",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 55,
                    QtdEmEstoque = 56,
                    PrecisaDeCarro = true,
                    Descricao = "Material resistente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de transporte grande",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 60,
                    QtdEmEstoque = 33,
                    PrecisaDeCarro = true,
                    Descricao = "Transporte seu pet confortalvemente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });
               
                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de transporte M�dia",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 33,
                    QtdEmEstoque = 55,
                    PrecisaDeCarro = true,
                    Descricao = "Material resistente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de transporte M�dia",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 34,
                    QtdEmEstoque = 59,
                    PrecisaDeCarro = true,
                    Descricao = "Transporte seu pet confortalvemente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de transporte M�dia",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 35.5,
                    QtdEmEstoque = 51,
                    PrecisaDeCarro = true,
                    Descricao = "Transporte seu pet com seguran�a.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });
             
                _context.Produto.Add(new Produto()
                {
                    Nome = "Caminha Pequena",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 60,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = true,
                    Descricao = "N�o ret�m umidade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caminha Pequena",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 55.5,
                    QtdEmEstoque = 36,
                    PrecisaDeCarro = true,
                    Descricao = "Tecido externo em camur�a",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caminha Pequena",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 52.5,
                    QtdEmEstoque = 54,
                    PrecisaDeCarro = true,
                    Descricao = "Pel�cia interna em poli�ster.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });
               
                _context.Produto.Add(new Produto()
                {
                    Nome = "Caminha M�dia",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 52.5,
                    QtdEmEstoque = 54,
                    PrecisaDeCarro = true,
                    Descricao = "Pel�cia interna em poli�ster.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caminha M�dia",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 55.5,
                    QtdEmEstoque = 36,
                    PrecisaDeCarro = true,
                    Descricao = "Tecido externo em camur�a.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caminha M�dia",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 60,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = true,
                    Descricao = "N�o ret�m umidade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });
              
                _context.Produto.Add(new Produto()
                {
                    Nome = "Filtro externo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 55.9,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Melhorar a qualidade da agua do seu aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Filtro externo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 65,
                    QtdEmEstoque = 83,
                    PrecisaDeCarro = false,
                    Descricao = "Melhorar a qualidade da agua do seu aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Filtro externo",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 70,
                    QtdEmEstoque = 71,
                    PrecisaDeCarro = false,
                    Descricao = "Melhorar a qualidade da agua do seu aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });
             
                _context.Produto.Add(new Produto()
                {
                    Nome = "Substrato",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 2.9,
                    QtdEmEstoque = 156,
                    PrecisaDeCarro = false,
                    Descricao = "Decorar o fundo do seu aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Substrato",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 2.5,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Decorar o fundo do seu aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Substrato",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 3,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "Decorar o fundo do seu aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kitthypet@adaspet.com.br").First()
                });
             
                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiola M�dia",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 185.5,
                    QtdEmEstoque = 52,
                    PrecisaDeCarro = true,
                    Descricao = "A gaiola perfeita para seu p�ssaro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiola M�dia",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 186,
                    QtdEmEstoque = 20,
                    PrecisaDeCarro = true,
                    Descricao = "A gaiola perfeita para seu p�ssaro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiola M�dia",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 190,
                    QtdEmEstoque = 10,
                    PrecisaDeCarro = true,
                    Descricao = "A gaiola perfeita para seu p�ssaro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });
           
                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiolas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 119,
                    QtdEmEstoque = 20,
                    PrecisaDeCarro = true,
                    Descricao = "O conforto para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiolas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 100,
                    QtdEmEstoque = 85,
                    PrecisaDeCarro = true,
                    Descricao = "O conforto para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiolas",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 120,
                    QtdEmEstoque = 30,
                    PrecisaDeCarro = true,
                    Descricao = "O conforto para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });
            
                _context.Produto.Add(new Produto()
                {
                    Nome = "Alojamento",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 99.5,
                    QtdEmEstoque = 20,
                    PrecisaDeCarro = true,
                    Descricao = "O espa�o adequado para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kitthypets@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Alojamento",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 110,
                    QtdEmEstoque = 30,
                    PrecisaDeCarro = true,
                    Descricao = "O espa�o adequado para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Alojamneto",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 120,
                    QtdEmEstoque = 25,
                    PrecisaDeCarro = true,
                    Descricao = "O espa�o adequado para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 3L",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30.5,
                    QtdEmEstoque = 56,
                    PrecisaDeCarro = true,
                    Descricao = "Vidro de �tima qualidade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 3L",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 33.5,
                    QtdEmEstoque = 20,
                    PrecisaDeCarro = true,
                    Descricao = "Aqu�rio com borda curva.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                });

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 3L",
                    Marca = "Verde",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 39,
                    QtdEmEstoque = 15,
                    PrecisaDeCarro = true,
                    Descricao = "O vidro n�o emba�a.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                });
           
                //*********************************** MARCA AZUL - LU�ZA ***********************************

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o Filhote 5kg",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 30,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o perfeita para seu cachorro. Natural, ajuda no h�lito.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o Filhote 5kg",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 32,
                    QtdEmEstoque = 198,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o perfeita para seu cachorro. Natural, ajuda no h�lito.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o grande porte 5kg",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 32,
                    QtdEmEstoque = 265,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o gold premiun para seu cachorro viver saud�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o grande porte 5kg",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 32.9,
                    QtdEmEstoque = 275,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o gold premiun para seu cachorro viver saud�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()

                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o grande porte 5kg",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 31.9,
                    QtdEmEstoque = 266,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o gold premiun para seu cachorro viver saud�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()

                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o grande porte 5kg",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 32,
                    QtdEmEstoque = 265,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o gold premiun para seu cachorro viver saud�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o gigante porte 10kg",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 53.90,
                    QtdEmEstoque = 90,
                    PrecisaDeCarro = true,
                    Descricao = "Ra��o perfeita para seu cachorro. Ela tem uma �tima qualidade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o gigante porte 10kg",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 51.90,
                    QtdEmEstoque = 95,
                    PrecisaDeCarro = true,
                    Descricao = "Ra��o perfeita para seu cachorro. Ela tem uma �tima qualidade",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o gigante porte 10kg",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 50.90,
                    QtdEmEstoque = 90,
                    PrecisaDeCarro = true,
                    Descricao = "Ra��o perfeita para seu cachorro. Ela tem uma �tima qualidade.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o Filhote 5kg",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 29.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o perfeita para seu filhote. Natural, ajuda no h�lito.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o Filhote 5kg",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 31.90,
                    QtdEmEstoque = 206,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o perfeita para seu filhote. Natural, ajuda no h�lito.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o Filhote 2kg",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 19.90,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o perfeita para seu filhote. Ra��o natural sem corantes.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o Filhote 2kg",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 21.90,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o perfeita para seu filhote. Ra��o natural sem corantes.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o Filhote 2kg",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 19.49,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o perfeita para seu filhote. Ra��o natural sem corantes.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sache Cordeiro",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 1.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Alimenta��o completa e saborosa.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sache Cordeiro",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 2.99,
                    QtdEmEstoque = 208,
                    PrecisaDeCarro = false,
                    Descricao = "Alimenta��o completa e saborosa.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sache Salm�o",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 2.90,
                    QtdEmEstoque = 350,
                    PrecisaDeCarro = false,
                    Descricao = "Alimenta��o completa e saborosa para seu gato.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sache Salm�o",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 3.8,
                    QtdEmEstoque = 306,
                    PrecisaDeCarro = false,
                    Descricao = "Alimenta��o completa e saborosa para seu gato.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sache Salm�o",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 3.69,
                    QtdEmEstoque = 350,
                    PrecisaDeCarro = false,
                    Descricao = "Alimenta��o completa e saborosa para seu gato.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Mistura de sementes Calopsitas 200g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 22.90,
                    QtdEmEstoque = 320,
                    PrecisaDeCarro = false,
                    Descricao = "Mistura de sementes completa para sua calopsita.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Mistura de sementes Calopsitas 200g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 21.90,
                    QtdEmEstoque = 325,
                    PrecisaDeCarro = false,
                    Descricao = "Mistura de sementes completa para sua calopsita.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Mistura de sementes Calopsitas 200g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 23.5,
                    QtdEmEstoque = 306,
                    PrecisaDeCarro = false,
                    Descricao = "Mistura de sementes completa para sua calopsita.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()

                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Mistura de sementes Periquitos 200g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 15.90,
                    QtdEmEstoque = 450,
                    PrecisaDeCarro = false,
                    Descricao = "Mistura de sementes completa para seu periquito.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Mistura de sementes Periquitos 200g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 16.90,
                    QtdEmEstoque = 455,
                    PrecisaDeCarro = false,
                    Descricao = "Mistura de sementes completa para seu periquito.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Mistura de sementes Periquitos 200g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 10.30,
                    QtdEmEstoque = 450,
                    PrecisaDeCarro = false,
                    Descricao = "Mistura de sementes completa para seu periquito.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Mistura de sementes Periquitos 200g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 12.85,
                    QtdEmEstoque = 450,
                    PrecisaDeCarro = false,
                    Descricao = "Mistura de sementes completa para seu periquito.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Mistura de sementes Periquitos 200g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 13.90,
                    QtdEmEstoque = 650,
                    PrecisaDeCarro = false,
                    Descricao = "Mistura de sementes completa para seu periquito.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 250g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 14.90,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o granulada para jabutis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;


                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 250g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 12.50,
                    QtdEmEstoque = 115,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o granulada para jabutis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 250g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 17.90,
                    QtdEmEstoque = 321,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o granulada para jabutis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 250g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 11.90,
                    QtdEmEstoque = 98,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o granulada para jabutis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 250g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 9.99,
                    QtdEmEstoque = 51,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o granulada para jabutis.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 500g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 25.99,
                    QtdEmEstoque = 203,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o granulada para tartarugas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 500g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 26.90,
                    QtdEmEstoque = 210,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o granulada para tartarugas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 500g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 20.50,
                    QtdEmEstoque = 183,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o granulada para tartarugas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 500g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 21.23,
                    QtdEmEstoque = 213,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o granulada para tartarugas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 500g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 21.99,
                    QtdEmEstoque = 244,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o granulada para tartarugas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 250g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 20.90,
                    QtdEmEstoque = 300,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o completa e equilibrada para seu coelho.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 250g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 23.95,
                    QtdEmEstoque = 310,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o completa e equilibrada para seu coelho.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 250g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 18.99,
                    QtdEmEstoque = 233,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o completa e equilibrada para seu coelho.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 250g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 25.90,
                    QtdEmEstoque = 323,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o completa e equilibrada para seu coelho.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o extrusada 250g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 25.50,
                    QtdEmEstoque = 321,
                    PrecisaDeCarro = false,
                    Descricao = "Ra��o completa e equilibrada para seu coelho.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o granulada 50g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 14.90,
                    QtdEmEstoque = 321,
                    PrecisaDeCarro = false,
                    Descricao = "Alimenta��o para o dia a dia do seu peixe.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o granulada 50g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 14.90,
                    QtdEmEstoque = 321,
                    PrecisaDeCarro = false,
                    Descricao = "Alimenta��o para o dia a dia do seu peixe.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o granulada 50g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 14.90,
                    QtdEmEstoque = 321,
                    PrecisaDeCarro = false,
                    Descricao = "Alimenta��o para o dia a dia do seu peixe.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o granulada 50g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 11.90,
                    QtdEmEstoque = 321,
                    PrecisaDeCarro = false,
                    Descricao = "Alimenta��o para o dia a dia do seu peixe.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ra��o granulada 50g",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 12.90,
                    QtdEmEstoque = 333,
                    PrecisaDeCarro = false,
                    Descricao = "Alimenta��o para o dia a dia do seu peixe.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 3.90,
                    QtdEmEstoque = 333,
                    PrecisaDeCarro = false,
                    Descricao = "Petisco delicioso para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 2.90,
                    QtdEmEstoque = 213,
                    PrecisaDeCarro = false,
                    Descricao = "Petisco delicioso para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;


                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 4.90,
                    QtdEmEstoque = 343,
                    PrecisaDeCarro = false,
                    Descricao = "Petisco delicioso para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 2.90,
                    QtdEmEstoque = 333,
                    PrecisaDeCarro = false,
                    Descricao = "Petisco delicioso para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 3.90,
                    QtdEmEstoque = 333,
                    PrecisaDeCarro = false,
                    Descricao = "Petisco delicioso para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 4,
                    QtdEmEstoque = 369,
                    PrecisaDeCarro = false,
                    Descricao = "Petisco delicioso para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 5.90,
                    QtdEmEstoque = 369,
                    PrecisaDeCarro = false,
                    Descricao = "Petisco delicioso para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 1.99,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Petisco delicioso para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 5,
                    QtdEmEstoque = 369,
                    PrecisaDeCarro = false,
                    Descricao = "Petisco delicioso para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Petisco",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Alimentacao,
                    Preco = 2,
                    QtdEmEstoque = 369,
                    PrecisaDeCarro = false,
                    Descricao = "Petisco delicioso para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 64.5,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Antipulgas ou carrapatos perfeito para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 63.90,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Antipulgas ou carrapatos perfeito para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 62.99,
                    QtdEmEstoque = 115,
                    PrecisaDeCarro = false,
                    Descricao = "Antipulgas ou carrapatos perfeito para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 66.5,
                    QtdEmEstoque = 134,
                    PrecisaDeCarro = false,
                    Descricao = "Antipulgas ou carrapatos perfeito para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 64.5,
                    QtdEmEstoque = 129,
                    PrecisaDeCarro = false,
                    Descricao = "Antipulgas ou carrapatos perfeito para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 64.5,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Antipulgas ou carrapatos perfeito para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 63.5,
                    QtdEmEstoque = 135,
                    PrecisaDeCarro = false,
                    Descricao = "Antipulgas ou carrapatos perfeito para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 62.99,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Antipulgas ou carrapatos perfeito para seu pet",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 65.5,
                    QtdEmEstoque = 135,
                    PrecisaDeCarro = false,
                    Descricao = "Antipulgas ou carrapatos perfeito para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antipulgas e Carrapatos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 64.5,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Antipulgas ou carrapatos perfeito para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 12.9,
                    QtdEmEstoque = 158,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio perfeito contra vermes para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 13.9,
                    QtdEmEstoque = 158,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio perfeito contra vermes para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 11.9,
                    QtdEmEstoque = 148,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio perfeito contra vermes para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 12.9,
                    QtdEmEstoque = 158,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio perfeito contra vermes para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 12.9,
                    QtdEmEstoque = 158,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio perfeito contra vermes para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 12.9,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio perfeito contra vermes para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 13.9,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio perfeito contra vermes para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 13.9,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio perfeito contra vermes para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 11.9,
                    QtdEmEstoque = 95,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio perfeito contra vermes para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Verm�fugo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 14.9,
                    QtdEmEstoque = 128,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio perfeito contra vermes para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 12.9,
                    QtdEmEstoque = 201,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio que combate a intoxica��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 13.9,
                    QtdEmEstoque = 211,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio que combate a intoxica��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 12,
                    QtdEmEstoque = 214,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio que combate a intoxica��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 11.9,
                    QtdEmEstoque = 196,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio que combate a intoxica��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 12.9,
                    QtdEmEstoque = 205,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio que combate a intoxica��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 12.9,
                    QtdEmEstoque = 205,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio que combate a intoxica��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 12.9,
                    QtdEmEstoque = 205,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio que combate a intoxica��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 10.9,
                    QtdEmEstoque = 205,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio que combate a intoxica��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 13.9,
                    QtdEmEstoque = 205,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio que combate a intoxica��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Antit�xico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 11.9,
                    QtdEmEstoque = 205,
                    PrecisaDeCarro = false,
                    Descricao = "Rem�dio que combate a intoxica��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 105,
                    QtdEmEstoque = 147,
                    PrecisaDeCarro = false,
                    Descricao = "Previnir a coloniza��o de bact�rias patog�nicas, melhorar a absor��o de nutrientes e auxiliar na s�ntese de vitaminas e prote�nas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 109.99,
                    QtdEmEstoque = 157,
                    PrecisaDeCarro = false,
                    Descricao = "Previnir a coloniza��o de bact�rias patog�nicas, melhorar a absor��o de nutrientes e auxiliar na s�ntese de vitaminas e prote�nas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 107.90,
                    QtdEmEstoque = 127,
                    PrecisaDeCarro = false,
                    Descricao = "Previnir a coloniza��o de bact�rias patog�nicas, melhorar a absor��o de nutrientes e auxiliar na s�ntese de vitaminas e prote�nas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 105,
                    QtdEmEstoque = 147,
                    PrecisaDeCarro = false,
                    Descricao = "Previnir a coloniza��o de bact�rias patog�nicas, melhorar a absor��o de nutrientes e auxiliar na s�ntese de vitaminas e prote�nas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 111,
                    QtdEmEstoque = 183,
                    PrecisaDeCarro = false,
                    Descricao = "Previnir a coloniza��o de bact�rias patog�nicas, melhorar a absor��o de nutrientes e auxiliar na s�ntese de vitaminas e prote�nas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 105,
                    QtdEmEstoque = 147,
                    PrecisaDeCarro = false,
                    Descricao = "Previnir a coloniza��o de bact�rias patog�nicas, melhorar a absor��o de nutrientes e auxiliar na s�ntese de vitaminas e prote�nas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 109.99,
                    QtdEmEstoque = 147,
                    PrecisaDeCarro = false,
                    Descricao = "Previnir a coloniza��o de bact�rias patog�nicas, melhorar a absor��o de nutrientes e auxiliar na s�ntese de vitaminas e prote�nas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 107.90,
                    QtdEmEstoque = 167,
                    PrecisaDeCarro = false,
                    Descricao = "Previnir a coloniza��o de bact�rias patog�nicas, melhorar a absor��o de nutrientes e auxiliar na s�ntese de vitaminas e prote�nas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 105,
                    QtdEmEstoque = 147,
                    PrecisaDeCarro = false,
                    Descricao = "Previnir a coloniza��o de bact�rias patog�nicas, melhorar a absor��o de nutrientes e auxiliar na s�ntese de vitaminas e prote�nas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 103,
                    QtdEmEstoque = 140,
                    PrecisaDeCarro = false,
                    Descricao = "Previnir a coloniza��o de bact�rias patog�nicas, melhorar a absor��o de nutrientes e auxiliar na s�ntese de vitaminas e prote�nas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Probi�tico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 103,
                    QtdEmEstoque = 140,
                    PrecisaDeCarro = false,
                    Descricao = "Previnir a coloniza��o de bact�rias patog�nicas, melhorar a absor��o de nutrientes e auxiliar na s�ntese de vitaminas e prote�nas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 30,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 34,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 30,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 34,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 39,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 33,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 35,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 34,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 36,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pomada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Pomada para ajudar na cicatriza��o do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 25.2,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 34,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 30,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 34,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 30,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 34,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 39,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 33,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 35,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 34,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 36,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 38,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Vitaminas e Suplementos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Farmacia,
                    Preco = 37,
                    QtdEmEstoque = 106,
                    PrecisaDeCarro = false,
                    Descricao = "Vitamina e Suplementos para seu pet ficar forte.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tapete higi�nico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Tapete higi�nico para seu amigo pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tapete higi�nico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Tapete higi�nico para seu amigo pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tapete higi�nico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Tapete higi�nico para seu amigo pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tapete higi�nico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Tapete higi�nico para seu amigo pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tapete higi�nico",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Tapete higi�nico para seu amigo pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Shampoo para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Shampoo para seu pet ficar cheiroso",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 46,
                    PrecisaDeCarro = false,
                    Descricao = "Shampoo para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Shampoo para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 56,
                    PrecisaDeCarro = false,
                    Descricao = "Shampoo para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Banheiros para cacochorros",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 69.90,
                    QtdEmEstoque = 56,
                    PrecisaDeCarro = false,
                    Descricao = "Banheiro para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Banheiros para cacochorros",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 69.90,
                    QtdEmEstoque = 56,
                    PrecisaDeCarro = false,
                    Descricao = "Banheiro para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Banheiros para cacochorros",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 69.90,
                    QtdEmEstoque = 56,
                    PrecisaDeCarro = false,
                    Descricao = "Banheiro para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Banheiros para cacochorros",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 69.90,
                    QtdEmEstoque = 56,
                    PrecisaDeCarro = false,
                    Descricao = "Banheiro para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Banheiros para cacochorros",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 69.90,
                    QtdEmEstoque = 56,
                    PrecisaDeCarro = false,
                    Descricao = "Banheiro para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;
 
                _context.Produto.Add(new Produto()
                {
                    Nome = "Coletor de fezes",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 19.90,
                    QtdEmEstoque = 56,
                    PrecisaDeCarro = false,
                    Descricao = "Coletor de fezes para deixar o ambiete agrad�vel para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coletor de fezes",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 19.90,
                    QtdEmEstoque = 56,
                    PrecisaDeCarro = false,
                    Descricao = "Coletor de fezes para deixar o ambiete agrad�vel para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coletor de fezes",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 19.90,
                    QtdEmEstoque = 56,
                    PrecisaDeCarro = false,
                    Descricao = "Coletor de fezes para deixar o ambiete agrad�vel para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coletor de fezes",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 19.90,
                    QtdEmEstoque = 56,
                    PrecisaDeCarro = false,
                    Descricao = "Coletor de fezes para deixar o ambiete agrad�vel para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coletor de fezes",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 19.90,
                    QtdEmEstoque = 56,
                    PrecisaDeCarro = false,
                    Descricao = "Coletor de fezes para deixar o ambiete agrad�vel para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Shampoo para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Shampoo para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 46,
                    PrecisaDeCarro = false,
                    Descricao = "Shampoo para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Shampoo para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Shampoo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 56,
                    PrecisaDeCarro = false,
                    Descricao = "Shampoo para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de unhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Cortador de unhas para seu pet ficar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de unhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Cortador de unhas para seu pet ficar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de unhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 33,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Cortador de unhas para seu pet ficar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de unhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 35.90,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Cortador de unhas para seu pet ficar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de unhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 34,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Cortador de unhas para seu pet ficar confort�vel",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;
 
                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de unhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Cortador de unhas para seu pet ficar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de unhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 36,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Cortador de unhas para seu pet ficar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de unhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 33,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Cortador de unhas para seu pet ficar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de unhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 35.90,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Cortador de unhas para seu pet ficar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cortador de unhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 34,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Cortador de unhas para seu pet ficar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sabonete",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 17.50,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Sabonete para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sabonete",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 17.50,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Sabonete para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sabonete",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 16.50,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Sabonete para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sabonete",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 17.50,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Sabonete para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitao@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sabonete",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 15.50,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Sabonete para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sabonete",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 17.50,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Sabonete para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sabonete",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 17.50,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Sabonete para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sabonete",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 16.50,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Sabonete para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sabonete",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 17.50,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Sabonete para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitao@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sabonete",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 15.50,
                    QtdEmEstoque = 125,
                    PrecisaDeCarro = false,
                    Descricao = "Sabonete para seu pet ficar cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova Rasquiadeira",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 31.90,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Escova para o pelo do seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova Rasquiadeira",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 31.90,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Escova para o pelo do seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova Rasquiadeira",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 31.90,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Escova para o pelo do seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova Rasquiadeira",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 31.90,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Escova para o pelo do seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova Rasquiadeira",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 31.90,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Escova para o pelo do seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova Rasquiadeira",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 31.90,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Escova para o pelo do seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova Rasquiadeira",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 31.90,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Escova para o pelo do seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova Rasquiadeira",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 31.90,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Escova para o pelo do seu pet ficar estiloso",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova Rasquiadeira",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 31.90,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Escova para o pelo do seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escova Rasquiadeira",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 31.90,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Escova para o pelo do seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de areia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 29.90,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Caixa de areia fofa para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de areia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 29.90,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Caixa de areia fofa para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de areia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 29.50,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Caixa de areia fofa para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de areia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 29.99,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Caixa de areia fofa para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa de areia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 28.90,
                    QtdEmEstoque = 136,
                    PrecisaDeCarro = false,
                    Descricao = "Caixa de areia fofa para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Areia higi�nica",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 29,
                    QtdEmEstoque = 110,
                    PrecisaDeCarro = false,
                    Descricao = "Areia para seu pet fazer as necessidades.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Areia higi�nica",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 29,
                    QtdEmEstoque = 110,
                    PrecisaDeCarro = false,
                    Descricao = "Areia para seu pet fazer as necessidades.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Areia higi�nica",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 22,
                    QtdEmEstoque = 110,
                    PrecisaDeCarro = false,
                    Descricao = "Areia para seu pet fazer as necessidades.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Areia higi�nica",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 30,
                    QtdEmEstoque = 110,
                    PrecisaDeCarro = false,
                    Descricao = "Areia para seu pet fazer as necessidades.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Areia higi�nica",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 25,
                    QtdEmEstoque = 110,
                    PrecisaDeCarro = false,
                    Descricao = "Areia para seu pet fazer as necessidades.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pazinha coletora",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 4.5,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "Pazinha para coletar as fezes do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pazinha coletora",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 4.5,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "Pazinha para coletar as fezes do seu pet",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pazinha coletora",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 2.5,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "Pazinha para coletar as fezes do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pazinha coletora",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 3.99,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "Pazinha para coletar as fezes do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pazinha coletora",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 5,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "Pazinha para coletar as fezes do seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "P� de Banho",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 25.5,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "P� de Banho para seu pet ficar seguro e cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "P� de Banho",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 25.5,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "P� de Banho para seu pet ficar seguro e cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "P� de Banho",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 25.5,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "P� de Banho para seu pet ficar seguro e cheiroso",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "P� de Banho",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 23.5,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "P� de Banho para seu pet ficar seguro e cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "P� de Banho",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Higiene,
                    Preco = 25,
                    QtdEmEstoque = 145,
                    PrecisaDeCarro = false,
                    Descricao = "P� de Banho para seu pet ficar seguro e cheiroso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bolinhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 12.5,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Bolinhas para seu cachorro se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bolinhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 12.5,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Bolinhas para seu cachorro se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bolinhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 11.99,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Bolinhas para seu cachorro se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bolinhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 12.5,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Bolinhas para seu cachorro se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Bolinhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 13,
                    QtdEmEstoque = 123,
                    PrecisaDeCarro = false,
                    Descricao = "Bolinhas para seu cachorro se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ossinhos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 12,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Ossinhos para seu cachorro se divertir e relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ossinhos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 13,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Ossinhos para seu cachorro se divertir e relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ossinhos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 12.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Ossinhos para seu cachorro se divertir e relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ossinhos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 12,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Ossinhos para seu cachorro se divertir e relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ossinhos",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 12,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Ossinhos para seu cachorro se divertir e relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ratinho",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 5.6,
                    QtdEmEstoque = 158,
                    PrecisaDeCarro = false,
                    Descricao = "Ratinho para seu pet se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ratinho",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 5.6,
                    QtdEmEstoque = 158,
                    PrecisaDeCarro = false,
                    Descricao = "Ratinho para seu pet se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ratinho",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 5,
                    QtdEmEstoque = 158,
                    PrecisaDeCarro = false,
                    Descricao = "Ratinho para seu pet se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ratinho",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 5.6,
                    QtdEmEstoque = 158,
                    PrecisaDeCarro = false,
                    Descricao = "Ratinho para seu pet se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Ratinho",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 5.99,
                    QtdEmEstoque = 158,
                    PrecisaDeCarro = false,
                    Descricao = "Ratinho para seu pet se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Varinhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.90,
                    QtdEmEstoque = 201,
                    PrecisaDeCarro = false,
                    Descricao = "Varinhas para seu pet se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Varinhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.90,
                    QtdEmEstoque = 201,
                    PrecisaDeCarro = false,
                    Descricao = "Varinhas para seu pet se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Varinhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.90,
                    QtdEmEstoque = 201,
                    PrecisaDeCarro = false,
                    Descricao = "Varinhas para seu pet se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Varinhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 17.50,
                    QtdEmEstoque = 201,
                    PrecisaDeCarro = false,
                    Descricao = "Varinhas para seu pet se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Varinhas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.99,
                    QtdEmEstoque = 201,
                    PrecisaDeCarro = false,
                    Descricao = "Varinhas para seu pet se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Arranhadores",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 69.50,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Arranhadores para seu pet se divertir e relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Arranhadores",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 65.50,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Arranhadores para seu pet se divertir e relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Arranhadores",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 65.50,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Arranhadores para seu pet se divertir e relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Arranhadores",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 66.50,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Arranhadores para seu pet se divertir e relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Arranhadores",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 65,
                    QtdEmEstoque = 96,
                    PrecisaDeCarro = false,
                    Descricao = "Arranhadores para seu pet se divertir e relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pel�cia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 45.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Pel�cia fofa para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pel�cia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 45.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Pel�cia fofa para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pel�cia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 45.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Pel�cia fofa para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;
  
                _context.Produto.Add(new Produto()
                {
                    Nome = "Pel�cia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 45.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Pel�cia fofa para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pel�cia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 45.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Pel�cia fofa para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pel�cia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 45.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Pel�cia fofa para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pel�cia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 45.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Pel�cia fofa para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pel�cia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 45.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Pel�cia fofa para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pel�cia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 45.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Pel�cia fofa para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pel�cia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 45.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Pel�cia fofa para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Mordedor",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.9,
                    QtdEmEstoque = 163,
                    PrecisaDeCarro = false,
                    Descricao = "Mordedor para seu cachorro relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Mordedor",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.9,
                    QtdEmEstoque = 163,
                    PrecisaDeCarro = false,
                    Descricao = "Mordedor para seu cachorro relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Mordedor",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.9,
                    QtdEmEstoque = 163,
                    PrecisaDeCarro = false,
                    Descricao = "Mordedor para seu cachorro relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Mordedor",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.9,
                    QtdEmEstoque = 163,
                    PrecisaDeCarro = false,
                    Descricao = "Mordedor para seu cachorro relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Mordedor",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.9,
                    QtdEmEstoque = 163,
                    PrecisaDeCarro = false,
                    Descricao = "Mordedor para seu cachorro relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Balan�os",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Balan�os para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Balan�os",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Balan�os para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Balan�os",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Balan�os para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Balan�os",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Balan�os para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Balan�os",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Balan�os para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Trap�zios",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Trap�zios para seu p�ssaro brincar",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Trap�zios",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 26.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Trap�zios para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Trap�zios",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 23.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Trap�zios para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Trap�zios",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Trap�zios para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Trap�zios",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Trap�zios para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 26.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Escada para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 26.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Escada para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Escada para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 26.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Escada para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Escada",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 26.5,
                    QtdEmEstoque = 63,
                    PrecisaDeCarro = false,
                    Descricao = "Escada para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Argolas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.5,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Argolas para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Argolas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.5,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Argolas para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Argolas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.5,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Argolas para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Argolas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.5,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Argolas para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Argolas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.5,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Argolas para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cabana",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25.5,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Cabana para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cabana",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 26,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Cabana para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cabana",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 24.99,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Cabana para seu p�ssaro brincar",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cabana",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25.5,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Cabana para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cabana",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25.5,
                    QtdEmEstoque = 65,
                    PrecisaDeCarro = false,
                    Descricao = "Cabana para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Espiral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25.5,
                    QtdEmEstoque = 45,
                    PrecisaDeCarro = false,
                    Descricao = "Espiral para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Espiral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25,
                    QtdEmEstoque = 45,
                    PrecisaDeCarro = false,
                    Descricao = "Espiral para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Espiral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 22.99,
                    QtdEmEstoque = 45,
                    PrecisaDeCarro = false,
                    Descricao = "Espiral para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Espiral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25.5,
                    QtdEmEstoque = 45,
                    PrecisaDeCarro = false,
                    Descricao = "Espiral para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Espiral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 25.5,
                    QtdEmEstoque = 45,
                    PrecisaDeCarro = false,
                    Descricao = "Espiral para seu p�ssaro brincar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roda de exerc�cio",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 33,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Roda para seu Roedor se exercitar e se manter saud�vel e em forma.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roda de exerc�cio",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 33,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Roda para seu Roedor se exercitar e se manter saud�vel e em forma",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roda de exerc�cio",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 33,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Roda para seu Roedor se exercitar e se manter saud�vel e em forma.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roda de exerc�cio",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 33,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Roda para seu Roedor se exercitar e se manter saud�vel e em forma.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roda de exerc�cio",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 33,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Roda para seu Roedor se exercitar e se manter saud�vel e em forma.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roedor",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Roedor para seu pet relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roedor",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Roedor para seu pet relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roedor",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Roedor para seu pet relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roedor",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Roedor para seu pet relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roedor",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Roedor para seu pet relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roedor",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Roedor para seu coelhiho relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roedor",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Roedor para seu coelhiho relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roedor",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Roedor para seu coelhiho relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roedor",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Roedo para seu coelhiho relaxar",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Roedor",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 16.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Roedor para seu coelhiho relaxar.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra mineral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 7.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Pedra mineral para seu pet ",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra mineral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 7.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Pedra mineral para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra mineral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 7.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Pedra mineral para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra mineral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 7.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Pedra mineral para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra mineral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 7.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Pedra mineral para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra mineral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 7.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Pedra mineral para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra mineral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 7.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Pedra mineral para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra mineral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 7.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Pedra mineral para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra mineral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 8,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Pedra mineral para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra mineral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 9.99,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Pedra mineral para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra mineral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 7.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Pedra mineral para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra mineral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 7.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Pedra mineral para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra mineral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 7.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Pedra mineral para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra mineral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 7.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Pedra mineral para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pedra mineral",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 7.5,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Pedra mineral para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "T�nel",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 19.90,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "T�nel para seu Roedor se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "T�nel",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 19.90,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "T�nel para seu Roedor se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "T�nel",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 19.90,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "T�nel para seu Roedor se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "T�nel",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 19.90,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "T�nel para seu Roedor se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "T�nel",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 19.90,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "T�nel para seu Roedor se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "T�nel",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 19.90,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "T�nel para seu coelho se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "T�nel",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 19.90,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "T�nel para seu coelho se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "T�nel",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 19.90,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "T�nel para seu coelho se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "T�nel",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 19.90,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "T�nel para seu coelho se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "T�nel",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Coelho,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 19.90,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "T�nel para seu coelho se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tubo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 19.90,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Tubo para seu Roedor se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tubo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 19.90,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Tubo para seu Roedor se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigiopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tubo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 19.90,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Tubo para seu Roedor se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tubo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 19.90,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Tubo para seu Roedor se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tubo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Roedores,
                    Categoria = ProdutoCategorias.Brinquedos,
                    Preco = 19.90,
                    QtdEmEstoque = 32,
                    PrecisaDeCarro = false,
                    Descricao = "Tubo para seu Roedor se divertir.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;
    
                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho P",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para passear com seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho P",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para passear com seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho P",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para passear com seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho P",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para passear com seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho P",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para passear com seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;
 
                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para passear com seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para passear com seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 32.40,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para passear com seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 29.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para passear com seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 32,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para passear com seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho G",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 50.50,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para passear com seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho G",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 55,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para passear com seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho G",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 49.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para passear com seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho G",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 50.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para passear com seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho G",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 50.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para passear com seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho P",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 29.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho P",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 29.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho P",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 19.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho P",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 29.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho P",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 29.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 29.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 19.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 29.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;
 
                _context.Produto.Add(new Produto()
                {
                    Nome = "Coleira Tamanho M",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Coleira para seu pet ficar estiloso.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Focinheira Tamanho P",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 23.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Focinheira para manter as pessoas seguras.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Focinheira Tamanho P",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 23.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Focinheira para manter as pessoas seguras.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Focinheira Tamanho P",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 25.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Focinheira para manter as pessoas seguras.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Focinheira Tamanho P",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 23.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Focinheira para manter as pessoas seguras.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Focinheira Tamanho P",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 23.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Focinheira para manter as pessoas seguras.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 21.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 21.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 22.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 21.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 20.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 21.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 21.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 49.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 45.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 46.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 21.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 21.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 18.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 19.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 20.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;
 
                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 21.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 31.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 29.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Caixa Transportadora M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 32.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para voc� passear com mais praticidade com seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cama Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu pet descansar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cama Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu pet descansar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cama Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu pet descansar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cama Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu pet descansar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cama Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 30,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu pet descansar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cama M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 45,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu pet descansar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cama M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 45,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu pet descansar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cama M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 45,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu pet descansar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cama M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 44.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu pet descansar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cama M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 45.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu pet descansar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cama Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 39.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu pet descansar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cama Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 39.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu pet descansar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cama Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 39.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu pet descansar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cama Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 39.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu pet descansar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Cama Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 40,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para seu pet descansar confort�vel.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Filtro interno",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 49.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Melhora a qualidade da �gua de seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Filtro interno",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 49.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Melhora a qualidade da �gua de seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Filtro interno",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 49.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Melhora a qualidade da �gua de seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Filtro interno",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 49.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Melhora a qualidade da �gua de seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Filtro interno",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 49.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Melhora a qualidade da �gua de seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Filtro externo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 59.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Melhora a qualidade da �gua de seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Filtro externo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 59.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Melhora a qualidade da �gua de seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Filtro externo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 59.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Melhora a qualidade da �gua de seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Filtro externo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 59.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Melhora a qualidade da �gua de seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capiaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Filtro externo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 59.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Melhora a qualidade da �gua de seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Subastrato",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 2.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Substrato para decorar o fundo do seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Subastrato",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 2.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Substrato para decorar o fundo do seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Subastrato",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 2.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Substrato para decorar o fundo do seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Subastrato",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 2.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Substrato para decorar o fundo do seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Subastrato",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 2.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Substrato para decorar o fundo do seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 500ml",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 14,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = true,
                    Descricao = "Aqu�rio para seu pet aqu�tico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 500ml",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 14,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = true,
                    Descricao = "Aqu�rio para seu pet aqu�tico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 500ml",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 14,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = true,
                    Descricao = "Aqu�rio para seu pet aqu�tico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 500ml",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 14,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = true,
                    Descricao = "Aqu�rio para seu pet aqu�tico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 500ml",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 14,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = true,
                    Descricao = "Aqu�rio para seu pet aqu�tico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 1L",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 24.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = true,
                    Descricao = "Aqu�rio para seu pet aqu�tico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 1L",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 24.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = true,
                    Descricao = "Aqu�rio para seu pet aqu�tico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 1L",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 24.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = true,
                    Descricao = "Aqu�rio para seu pet aqu�tico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 1L",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 24.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = true,
                    Descricao = "Aqu�rio para seu pet aqu�tico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Aqu�rio 1L",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 24.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = true,
                    Descricao = "Aqu�rio para seu pet aqu�tico.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "L�mpada para Aqu�rio ",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 64.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para l�mpadas aqu�ticas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "L�mpada para Aqu�rio ",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 64.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para l�mpadas aqu�ticas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "L�mpada para Aqu�rio ",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 64.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para l�mpadas aqu�ticas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "L�mpada para Aqu�rio ",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 64.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para l�mpadas aqu�ticas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "L�mpada para Aqu�rio ",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 64.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para l�mpadas aqu�ticas.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Termostato para Aqu�rio ",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 56,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Aquecer seu Aqu�rio e manter uma temperatura constante.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Termostato para Aqu�rio ",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 56,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Aquecer seu Aqu�rio e manter uma temperatura constante.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Termostato para Aqu�rio ",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 56,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Aquecer seu Aqu�rio e manter uma temperatura constante.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Termostato para Aqu�rio ",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 56,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Aquecer seu Aqu�rio e manter uma temperatura constante.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Rocha decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Rocha decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Rocha decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Rocha decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Rocha decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Rocha decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Rocha decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Rocha decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Rocha decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Rocha decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tronco decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu ambiente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tronco decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu ambiente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tronco decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 34.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu ambiente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tronco decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 35,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu ambiente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tronco decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu ambiente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tronco decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu ambiente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tronco decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu ambiente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tronco decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 34.99,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu ambiente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tronco decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 35,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu ambiente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Tronco decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 36.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu ambiente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Planta decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 12.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu ambiente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Planta decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 12.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu ambiente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Planta decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 12.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu ambiente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Planta decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 12.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu ambiente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Planta decorativa",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 12.90,
                    QtdEmEstoque = 200,
                    PrecisaDeCarro = false,
                    Descricao = "Para decorar seu ambiente.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sinf�o manual",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 16.90,
                    QtdEmEstoque = 23,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a limpar o substrato do Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sinf�o manual",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 16.90,
                    QtdEmEstoque = 23,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a limpar o substrato do Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sinf�o manual",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 16.90,
                    QtdEmEstoque = 23,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a limpar o substrato do Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sinf�o manual",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 16.90,
                    QtdEmEstoque = 23,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a limpar o substrato do Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sinf�o manual",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 16.90,
                    QtdEmEstoque = 23,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a limpar o substrato do Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sinf�o manual",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 16.90,
                    QtdEmEstoque = 23,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a limpar o substrato do Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sinf�o manual",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 16.90,
                    QtdEmEstoque = 23,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a limpar o substrato do Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sinf�o manual",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 16.90,
                    QtdEmEstoque = 23,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a limpar o substrato do Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sinf�o manual",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 16.90,
                    QtdEmEstoque = 23,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a limpar o substrato do Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Sinf�o manual",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Repteis,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 16.90,
                    QtdEmEstoque = 23,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a limpar o substrato do Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Midias biol�gicas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 19.90,
                    QtdEmEstoque = 23,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a filtrar o Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Midias biol�gicas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 19.90,
                    QtdEmEstoque = 23,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a filtrar o Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Midias biol�gicas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 19.90,
                    QtdEmEstoque = 23,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a filtrar o Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Midias biol�gicas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 19.90,
                    QtdEmEstoque = 23,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a filtrar o Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Midias biol�gicas",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 19.90,
                    QtdEmEstoque = 23,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a filtrar o Aqu�rio.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Carv�o ativado",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 20,
                    QtdEmEstoque = 234,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a manter um cheiro agrad�vel e melhora a qualidade da �gua.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Carv�o ativado",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 20,
                    QtdEmEstoque = 234,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a manter um cheiro agrad�vel e melhora a qualidade da �gua.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Carv�o ativado",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 20,
                    QtdEmEstoque = 234,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a manter um cheiro agrad�vel e melhora a qualidade da �gua ",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Carv�o ativado",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 20,
                    QtdEmEstoque = 234,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a manter um cheiro agrad�vel e melhora a qualidade da �gua.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Carv�o ativado",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 20,
                    QtdEmEstoque = 234,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a manter um cheiro agrad�vel e melhora a qualidade da �gua.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Esponja biologica",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 12.50,
                    QtdEmEstoque = 234,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a filtragem de res�duos maiores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Esponja biologica",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 12.50,
                    QtdEmEstoque = 234,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a filtragem de res�duos maiores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Esponja biologica",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 12.50,
                    QtdEmEstoque = 234,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a filtragem de res�duos maiores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Esponja biologica",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 12.50,
                    QtdEmEstoque = 234,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a filtragem de res�duos maiores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Esponja biologica",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 12.50,
                    QtdEmEstoque = 234,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a filtragem de res�duos maiores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Refil para filtro externo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 15,
                    QtdEmEstoque = 34,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a filtragem de res�duos maiores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Refil para filtro externo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 15,
                    QtdEmEstoque = 34,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a filtragem de res�duos maiores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Refil para filtro externo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 15,
                    QtdEmEstoque = 34,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a filtragem de res�duos maiores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Refil para filtro externo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 15,
                    QtdEmEstoque = 34,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a filtragem de res�duos maiores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Refil para filtro externo",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Peixe,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 15,
                    QtdEmEstoque = 34,
                    PrecisaDeCarro = false,
                    Descricao = "Ajuda a filtragem de res�duos maiores.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiola Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 96.90,
                    QtdEmEstoque = 34,
                    PrecisaDeCarro = false,
                    Descricao = "Gaiola para seu p�ssaro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiola Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 96.90,
                    QtdEmEstoque = 34,
                    PrecisaDeCarro = false,
                    Descricao = "Gaiola para seu p�ssaro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiola Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 96.90,
                    QtdEmEstoque = 34,
                    PrecisaDeCarro = false,
                    Descricao = "Gaiola para seu p�ssaro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiola Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 95.90,
                    QtdEmEstoque = 34,
                    PrecisaDeCarro = false,
                    Descricao = "Gaiola para seu p�ssaro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiola Pequena",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 96.99,
                    QtdEmEstoque = 34,
                    PrecisaDeCarro = false,
                    Descricao = "Gaiola para seu p�ssaro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiola M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 150,
                    QtdEmEstoque = 34,
                    PrecisaDeCarro = false,
                    Descricao = "Gaiola para seu p�ssaro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiola M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 150,
                    QtdEmEstoque = 34,
                    PrecisaDeCarro = false,
                    Descricao = "Gaiola para seu p�ssaro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiola M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 150,
                    QtdEmEstoque = 34,
                    PrecisaDeCarro = false,
                    Descricao = "Gaiola para seu p�ssaro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiola M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 150,
                    QtdEmEstoque = 34,
                    PrecisaDeCarro = false,
                    Descricao = "Gaiola para seu p�ssaro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Gaiola M�dia",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 150,
                    QtdEmEstoque = 34,
                    PrecisaDeCarro = false,
                    Descricao = "Gaiola para seu p�ssaro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Puleiro pequeno",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Passaro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 25,
                    QtdEmEstoque = 101,
                    PrecisaDeCarro = false,
                    Descricao = "Puleiro para seu p�ssaro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de ra��o",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 10,
                    QtdEmEstoque = 101,
                    PrecisaDeCarro = false,
                    Descricao = "Pote para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de ra��o",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 10,
                    QtdEmEstoque = 101,
                    PrecisaDeCarro = false,
                    Descricao = "Pote para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de ra��o",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 10,
                    QtdEmEstoque = 101,
                    PrecisaDeCarro = false,
                    Descricao = "Pote para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de ra��o",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 10,
                    QtdEmEstoque = 101,
                    PrecisaDeCarro = false,
                    Descricao = "Pote para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de ra��o",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Cachorro,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 10,
                    QtdEmEstoque = 101,
                    PrecisaDeCarro = false,
                    Descricao = "Pote para seu cachorro.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de ra��o",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 10,
                    QtdEmEstoque = 101,
                    PrecisaDeCarro = false,
                    Descricao = "Pote para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de ra��o",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 10,
                    QtdEmEstoque = 101,
                    PrecisaDeCarro = false,
                    Descricao = "Pote para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de ra��o",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 10,
                    QtdEmEstoque = 101,
                    PrecisaDeCarro = false,
                    Descricao = "Pote para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de ra��o",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 10,
                    QtdEmEstoque = 101,
                    PrecisaDeCarro = false,
                    Descricao = "Pote para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
                }); ;

                _context.Produto.Add(new Produto()
                {
                    Nome = "Pote de ra��o",
                    Marca = "Azul",
                    TipoDeAnimal = ProdutoAnimais.Gato,
                    Categoria = ProdutoCategorias.Acessorio,
                    Preco = 10,
                    QtdEmEstoque = 101,
                    PrecisaDeCarro = false,
                    Descricao = "Pote para seu pet.",
                    ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
                }); ;



            


            _context.SaveChanges();


        }

    }
}
