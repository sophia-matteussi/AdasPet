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

        public double Preco { get; set; }

        public double Frete { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public Pedido Pedido { get; set; } = new Pedido();
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
            }
            catch
            {
                return Redirect("~/Identity/Account/CadastroCompleto");
            }

            Produtos = GetProdutosCarrinho(HttpContext.Session);

            Preco = ValorTotal();

            return Page();
        }

        public List<Produto> GetProdutosCarrinho(ISession session)
        {
            //id dos produtos que estão no carrinho
            var CarrinhoListID = CarrinhoOp.GetCarrinho(session);
            for (int i = 0; i < CarrinhoListID.Count; i++)
            {
                var ProdutoId = CarrinhoListID[i];
                var produto = _context.Produto.Find(ProdutoId);
                // Quando buscamos o objeto com find os objetos relacionados nao sao carregados automaticamente
                // Então precisamos diizer para o entity framework carrega-los
                _context.Entry(produto).Reference(p => p.ContaCadastro).Load();
                Produtos.Add(produto);
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

        public async Task<IActionResult> OnPostAsync()
        {
            string Pagamento;
            if (Input.FormaPgto == "Cartao")
            {
                Pagamento = Input.FormaPgto + " " + Input.CartaoTipo + " " + Input.Bandeira;
            }
            else
            {
                Pagamento = Input.FormaPgto;
            }
            Produtos = GetProdutosCarrinho(HttpContext.Session);

            Pedido pedido = Input.Pedido;
            pedido.Produtos = Produtos;
            pedido.StatusDoPedido = "Novo";
            pedido.DataInicio = DateTime.Now;
            pedido.Preco = ValorTotal();
            pedido.Pagamento = Pagamento;
            var userId = _userManager.GetUserId(User);
            pedido.Cliente = _context.Cliente.Where(c => c.ContaCadastro.Id == userId).First();

            _context.Pedido.Add(pedido);

            _context.SaveChanges();

            return Redirect("~/Identity/Account/Manage/Pedidos");

        }

        //calcula o valor total da compra
        public double ValorTotal()
        {
            double valorTotal = CalculaFrete(ChecaFornecedor(Produtos));
            foreach (var item in Produtos)
            {
                valorTotal += item.Preco;
            }
            return valorTotal;
        }

        //calcula o frete de acordo com a quantidade de fornecedores
        public double CalculaFrete(Dictionary<IdentityUser, List<Produto>> dicionario)
        {
            double numeroFornecedores = dicionario.Keys.Count;
            double frete = 10; //começa em 10 por causa do frete
            frete += (numeroFornecedores - 1) * 5;
            Frete = frete;
            return frete;
        }



    }


}
