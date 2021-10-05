using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using AdasPet.Data;
using AdasPet.Models;
using System.Configuration;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.Data.Entity;
using System.Net.Http;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace AdasPet.Areas.Identity.Pages.Account
{

    [Authorize]
    public class CadastroCompletoModel : PageModel
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public string erro;

        // O atributo BindProperty quer dizer que a pagina pode acessar essa variavel
        [BindProperty]
        public string TipoCadastro { get; set; } = "cliente";

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Campo obrigat�rio!!!")]
            [StringLength(200, ErrorMessage = "Maximo de 200 caracteres")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "Campo obrigat�rio!!!")]
            [StringLength(11, ErrorMessage = "O CPF deve ter 11 caracteres apenas num�ricos.", MinimumLength = 11)]
            public string CPF { get; set; }

            [Required(ErrorMessage = "Campo obrigat�rio!!!")]
            [DataType(DataType.Date)]
            [Display(Name = "Data de Nascimento")]
            public DateTime DataNascimento { get; set; }

            [Required(ErrorMessage = "Campo obrigat�rio!!!")]
            [Phone]
            [DataType(DataType.PhoneNumber)]
            [StringLength(15, ErrorMessage = "O telefone precisa ter entre 9 e 15 caracteres", MinimumLength = 9)]
            public string Telefone { get; set; }

            [Required(ErrorMessage = "Campo obrigat�rio!!!")]
            [StringLength(200)]
            [Display(Name = "Raz�o Social")]
            public string RazaoSocial { get; set; }

            [Required(ErrorMessage = "Campo obrigat�rio!!!")]
            [StringLength(14, ErrorMessage = "O CNPJ deve ter 14 caracteres num�ricos.", MinimumLength = 14)]
            public string CNPJ { get; set; }

            [Required(ErrorMessage = "Campo obrigat�rio!!!")]
            [StringLength(20)]
            public string CNH { get; set; }

            [Required(ErrorMessage = "Campo obrigat�rio!!!")]
            [StringLength(5)]
            [Display(Name = "Tipo do Veiculo")]
            public string TipoVeiculo { get; set; }

            [Required(ErrorMessage = "Campo obrigat�rio!!!")]
            [StringLength(7, ErrorMessage = "A Placa do ve�culo deve ter 7 caracteres, entre letras e numeros.", MinimumLength = 7)]
            public string Placa { get; set; }

            [Required(ErrorMessage = "Campo obrigat�rio!!!")]
            [StringLength(30)]
            public string Renavam { get; set; }

            [Required]
            public string Tipo { get; set; }

            [Required(ErrorMessage = "Campo obrigat�rio!!!")]
            [StringLength(8, ErrorMessage = "O CEP deve ter 8 caracteres num�ricos.", MinimumLength = 8)]
            public string Cep { get; set; }

            [Required(ErrorMessage = "Campo obrigat�rio!!!")]
            [StringLength(5)]
            [Display(Name = "Numero da Casa")]
            public string NumeroCasa { get; set; }

            [StringLength(30)]
            public string Complemento { get; set; }

        }

        public CadastroCompletoModel(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        /// <summary>
        /// Executa quando usuario entra na pagina
        /// </summary>
        /// <param name="tipo">Tipo de Cadastro que sera feito. Pode ser cliente, fornecedor ou entregador</param>
        /// <param name="Erro">Mensagem de erro para ser passada para o usuario</param>
        /// <returns></returns>
        public IActionResult OnGet(string tipo, string Erro)
        {
            // Checa a session do usuario para ver se existe a chave CadastroCompleto
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("CadastroCompleto")))
            {
                // Se a chave CadastroCompleto existir ent�o sabemos que o usuario ja completou seu cadastro
                // Ent�o mandamos ele para a pagina inicial
                return Redirect("/");
            }

            // Pegamos o ID do usuario
            string UserId = _userManager.GetUserId(User);

            bool temCadastroCompleto = false;

            // Como n�o sabemos que tipo de conta o usuario tem
            // Temos que checar no banco de dados se seu ID esta em qualquer uma das tabelas de Cliente, Fornecedor ou Entregador
            if (_context.Cliente.Where(o => o.ContaCadastro.Id.Equals(UserId)).Any())
            {
                temCadastroCompleto = true;
            }
            else if (_context.Fornecedor.Where(o => o.ContaCadastro.Id.Equals(UserId)).Any())
            {
                temCadastroCompleto = true;
            }
            else if (_context.Entregador.Where(o => o.ContaCadastro.Id.Equals(UserId)).Any())
            {
                temCadastroCompleto = true;
            }

            // Se o usuario estiver em qualqquer uma das tabelas que checamos anteriormente
            if (temCadastroCompleto)
            {
                // Adicionamos � session a chave CadastroCompleto com o valor true
                HttpContext.Session.SetString("CadastroCompleto","true");
                // E ent�o redirecionamos ele de volta para a pagina principal
                return Redirect("/");
            }
            else
            {
                // O padr�o da propriedade TipoCadastro � Cliente
                // Se o parametro tipo n�o for vazio nos atribuimos ele a propriedade TipoCadastro da classe
                if (!string.IsNullOrEmpty(tipo))
                {
                    TipoCadastro = tipo;
                }
                erro = Erro;
                // Se o usuario chegou at� aqui ent�o ele n�o terminou o cadastro, ent�o retornamos a pagina para terminar o cadastro
                return Page();
            }
        }

        
        /// <summary>
        /// Executa quando o formulario da pagina � submetido
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPostAsync()
        {

            // Checamos o tipo de cadastro do usuario e ent�o criamos um objeto de seu tipo e adicionamos no BD
            if (Input.Tipo == "cliente")
            {
                Cliente cadastro = new Cliente
                {
                    Nome = Input.Nome,
                    CPF = Input.CPF.Replace("-", ""),
                    DataNascimento = Input.DataNascimento,
                    Telefone = Input.Telefone,
                    ContaCadastro = await _userManager.GetUserAsync(User)
                };


                Endereco endereco = await Endereco.GetEnderecoDeCepAsync(Input.Cep);
                if (string.IsNullOrEmpty(endereco.Rua))
                {
                    // Se a API de CEP nao retornar uma rua quer dizer que o CEP n�o existe
                    ModelState.AddModelError("Cep", "CEP Inv�lido!");
                    return Page();
                }

                endereco.CEP = Input.Cep;
                endereco.NumeroCasa = Input.NumeroCasa;
                endereco.Complemento = Input.Complemento;
                endereco.Principal = true;
                endereco.Cliente = cadastro;

                _context.Cliente.Add(cadastro);
                _context.Endereco.Add(endereco);

            }
            else if (Input.Tipo == "fornecedor")
            {
                Fornecedor cadastro = new Fornecedor
                {
                    RazaoSocial = Input.RazaoSocial,
                    CNPJ = Input.CNPJ.Replace("-", ""),
                    Telefone = Input.Telefone,
                    ContaCadastro = await _userManager.GetUserAsync(User)
                };


                Endereco endereco = await Endereco.GetEnderecoDeCepAsync(Input.Cep);
                if (string.IsNullOrEmpty(endereco.Rua))
                {
                    // Se a API de CEP nao retornar uma rua quer dizer que o CEP n�o existe
                    ModelState.AddModelError("Cep", "CEP Inv�lido!");
                    return Page();
                }
                endereco.CEP = Input.Cep;
                endereco.NumeroCasa = Input.NumeroCasa;
                endereco.Complemento = Input.Complemento;
                endereco.Principal = true;
                endereco.Fornecedor = cadastro;

                _context.Fornecedor.Add(cadastro);
                _context.Endereco.Add(endereco);
            }
            else if (Input.Tipo == "entregador")
            {
                Entregador cadastro = new Entregador
                {
                    Nome = Input.Nome,
                    CPF = Input.CPF.Replace("-", ""),
                    CNH = Input.CNH,
                    DataNascimento = Input.DataNascimento,
                    Telefone = Input.Telefone,
                    TipoVeiculo = Input.TipoVeiculo,
                    Placa = Input.Placa,
                    Renavam = Input.Renavam,
                    ContaCadastro = await _userManager.GetUserAsync(User)
                };

                _context.Entregador.Add(cadastro);
            }
            
            // Salvamos as mudan�as para o BD
            await _context.SaveChangesAsync();

            // Adicionamos � session a chave CadastroCompleto com o valor true
            HttpContext.Session.SetString("CadastroCompleto", "true");

            return Redirect("/");
        }

    }
}
