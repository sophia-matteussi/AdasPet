using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdasPet.Data;
using AdasPet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdasPet.Areas.Loja.Pages.Testes
{
    public class CriarProdutosModel : PageModel
    {
        public ApplicationDbContext _context { get; set; }

        public CriarProdutosModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            _context.Produto.Add(new Produto()
            {
                Nome = "Ração 5Kg",
                Marca = "Vermelha",
                TipoDeAnimal = "Cachorro",
                Categoria = "Alimento",
                Preco = 100,
                QtdEmEstoque = 30,
                PrecisaDeCarro = false,
                Descricao = "Ração muito gostosa",
                ContaCadastro = _context.Users.Where(o => o.Id == "4658a4ad-a931-4ae1-8e1b-c5b7fc3eb10f").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Ração 10Kg",
                Marca = "Vermelha",
                TipoDeAnimal = "Cachorro",
                Categoria = "Alimento",
                Preco = 200,
                QtdEmEstoque = 30,
                PrecisaDeCarro = false,
                Descricao = "Ração muito gostosa",
                ContaCadastro = _context.Users.Where(o => o.Id == "4658a4ad-a931-4ae1-8e1b-c5b7fc3eb10f").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Ração 5Kg",
                Marca = "Azul",
                TipoDeAnimal = "Cachorro",
                Categoria = "Alimento",
                Preco = 150,
                QtdEmEstoque = 30,
                PrecisaDeCarro = false,
                Descricao = "Ração muito gostosa",
                ContaCadastro = _context.Users.Where(o => o.Id == "4658a4ad-a931-4ae1-8e1b-c5b7fc3eb10f").First()
            });

            _context.Produto.Add(new Produto()
            {
                Nome = "Ração 10Kg",
                Marca = "Azul",
                TipoDeAnimal = "Cachorro",
                Categoria = "Alimento",
                Preco = 300,
                QtdEmEstoque = 30,
                PrecisaDeCarro = false,
                Descricao = "Ração muito gostosa",
                ContaCadastro = _context.Users.Where(o => o.Id == "4658a4ad-a931-4ae1-8e1b-c5b7fc3eb10f").First()
            });

            _context.SaveChanges();


        }

    }
}
