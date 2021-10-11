using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdasPet.Areas.Loja.Pages.Carrinho;
using AdasPet.Data;
using AdasPet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdasPet.Areas.Loja.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel( ApplicationDbContext context)
        {
            _context = context;
        }

        public string Animal { get; set; }
        public string Categoria { get; set; }

        public List<Produto> Produtos { get; set; }

        public IActionResult OnGet(string animal, string categoria)
        {
            Animal = animal;

            // Categoria é opcional, entao se é null chamamos o GetProdutos apenas com o animal
            if (String.IsNullOrEmpty(categoria))
            {
                return GetProdutos(animal);
            }
            else
            {
                return GetProdutos(animal, categoria);
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Pega o corpo do requerimento mandado pela pagina
            var BodyForm = await HttpContext.Request.ReadFormAsync();
            // Extrai o id do produto desse corpo e adiciona ao carrinho
            CarrinhoOp.AdicionarItem(HttpContext.Session, new Guid(BodyForm["item.ID"]));
            // Retorna OK
            return Content("OK");
        }
        /// <summary>
        /// Adiciona todos os produtos do animal selecionado ao prop Produtos
        /// </summary>
        /// <param name="animal">Animal</param>
        /// <returns>Retorna resultado da pagina, se o animal não for encontrado, retornara NotFound</returns>
        private IActionResult GetProdutos(string animal)
        {
            // Checa se a string animal esta dentro do enum ProdutosAnimais
            // Nesse enum temos todos os tipos de animais possiveis
            if (!Enum.TryParse<ProdutoAnimais>(animal, true, out ProdutoAnimais animalEnum))
            {
                return NotFound(animal);
            }

            //seleciona os produtos no DB
            Produtos = _context.Produto.Where(p => p.TipoDeAnimal == animalEnum).ToList();

            return Page();
        }

        /// <summary>
        /// Adiciona todos os produtos do animal por categoria selecionada a prop Produtos 
        /// </summary>
        /// <param name="animal">Animal</param>
        /// <param name="categoria">Categoria</param>
        /// <returns>Retorna resultado da pagina, se o animal e/ou categoria não for encontrada, retornara NotFound</returns>
        private IActionResult GetProdutos(string animal,string categoria)
        {
            // Checa se a string animal esta dentro do enum ProdutosAnimais
            // Nesse enum temos todos os tipos de animais possiveis
            if (!Enum.TryParse<ProdutoAnimais>(animal, true, out ProdutoAnimais animalEnum))
            {
                return NotFound(animal);
            }
            // Checa se a string categoria esta dentro do enum ProdutosCategorias
            // Nesse enum temos todos os tipos de categorias possiveis
            if (!Enum.TryParse<ProdutoCategorias>(categoria, true, out ProdutoCategorias categoriaEnum))
            {
                return NotFound(categoria);
            }

            //seleciona os produtos no DB
            Produtos = _context.Produto.Where(p => p.TipoDeAnimal == animalEnum && p.Categoria == categoriaEnum).ToList();

            return Page();
        }

    }
}
