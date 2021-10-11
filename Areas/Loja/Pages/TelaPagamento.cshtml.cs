using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdasPet.Areas.Loja.Pages.Carrinho;
using AdasPet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AdasPet.Areas.Loja.Pages
{
    public class TelaPagamentoModel : PageModel
    {
        [BindProperty]
        public string Tipo { get; set; }

        private readonly AdasPet.Data.ApplicationDbContext _context;

        private readonly UserManager<IdentityUser> _userManager;

        public TelaPagamentoModel(AdasPet.Data.ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        public List<SelectListItem> Enderecos { get; private set; }

        [BindProperty]
        public List<Produto> Produtos { get; set; } = new List<Produto>();


        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public Pedido Pedido { get; set; }
            public string Bandeira { get; set; }
            public string CartaoTipo { get; set; }
            public string EnderecoId { get; set; }
            public string FormaPgto { get; set; }

        }

        public IActionResult OnGet(string tipo)
        {
            Tipo = tipo;

            string UserId = _userManager.GetUserId(User);

            var cliente = _context.Cliente.Where(user => user.ContaCadastro.Id == UserId);

            var enderecos = _context.Endereco.Where(end => end.Cliente.ID == cliente.First().ID);

            try
            {
                Enderecos = enderecos.Select(end => new SelectListItem
                {
                    Value = end.ID.ToString(),
                    Text = end.Rua
                }
                ).ToList();
            } catch
            {
                return Redirect("~/Identity/Account/CadastroCompleto");
            }

            Produtos = GetProdutosCarrinho(HttpContext.Session);

            return Page();
        }

        public List<Produto> GetProdutosCarrinho(ISession session )
        {
            //id dos produtos que estão no carrinho
            var CarrinhoListID = CarrinhoOp.GetCarrinho(session);
            for (int i = 0; i < CarrinhoListID.Count; i++)
            {
                var ProdutoId = CarrinhoListID[i];
                Produtos.Add(_context.Produto.Find(ProdutoId));
            }
            return Produtos;
        }

        //checa a lista de produtos e retorna um dicionario separado por fornecedores
        public Dictionary<IdentityUser, List<Produto>> ChecaFornecedor(List<Produto> produtos)
        {
            Dictionary<IdentityUser, List<Produto>> dicionario = new Dictionary<IdentityUser, List<Produto>>();
            foreach (var item in produtos)
            {
                //checa se o dicionario já possui aquela chave nele, se tiver, só adiona o item,
                //senao, adiciona a nova chave +  lista vazia (que depois será adicionado o item na lista)
                if (!dicionario.ContainsKey(item.ContaCadastro))
                {
                    dicionario.Add(item.ContaCadastro, new List<Produto>());
                }
                dicionario[item.ContaCadastro].Add(item);
            }
            return dicionario;
        }

        public IActionResult OnPost()
        {
            Produtos = GetProdutosCarrinho(HttpContext.Session);
            var dicionario = ChecaFornecedor(Produtos);
            foreach (var item in dicionario)
            {
                Pedido pedido = new Pedido();
                pedido.Produtos = item.Value;
                //pedido.
                _context.Pedido.Add(pedido);
            }
            return Redirect("~/Identity/Account/Manage/Pedidos");

        }
    
    
        
    }


}
