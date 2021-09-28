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

namespace AdasPet.Areas.Identity.Pages.Account
{

    [Authorize]
    public class CadastroCompletoModel : PageModel
    {
        private static readonly HttpClient client = new HttpClient();

        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public string erro;

        [BindProperty]
        public string TipoCadastro { get; set; } = "cliente";

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [StringLength(200)]
            public string Nome { get; set; }

            [Required]
            [StringLength(11, MinimumLength = 11)]
            public string CPF { get; set; }

            [Required]
            [DataType(DataType.Date)]
            [Display(Name = "Data de Nascimento")]
            public DateTime DataNascimento { get; set; }

            [Required]
            [Phone]
            [DataType(DataType.PhoneNumber)]
            [StringLength(15, MinimumLength = 9)]
            public string Telefone { get; set; }

            [Required]
            [StringLength(200)]
            [Display(Name = "Razão Social")]
            public string RazaoSocial { get; set; }

            [Required]
            [StringLength(14, MinimumLength = 14)]
            public string CNPJ { get; set; }

            [Required]
            [StringLength(20)]
            public string CNH { get; set; }

            [Required]
            [StringLength(5)]
            [Display(Name = "Tipo do Veiculo")]
            public string TipoVeiculo { get; set; }

            [Required]
            [StringLength(7, MinimumLength = 7)]
            public string Placa { get; set; }

            [Required]
            [StringLength(30)]
            public string Renavam { get; set; }

            [Required]
            public string Tipo { get; set; }

            [Required]
            [StringLength(8, MinimumLength = 8)]
            public string Cep { get; set; }

            [Required]
            [StringLength(5)]
            public string NumeroCasa { get; set; }

            [StringLength(30)]
            public string Complemento { get; set; }

        }

        public CadastroCompletoModel(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public IActionResult OnGet(string tipo, string Erro)
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("CadastroCompleto")))
            {
                return Redirect("/");
            }

            string UserId = _userManager.GetUserId(User);

            bool temCadastroCompleto = false;

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

            if (temCadastroCompleto)
            {
                HttpContext.Session.SetString("CadastroCompleto","true");
                return Redirect("/");
            } else
            {
                if (!string.IsNullOrEmpty(tipo))
                {
                    TipoCadastro = tipo;
                }
                erro = Erro;
                return Page();
            }
        }

        public async Task<Endereco> GetEnderecoAsync(string cep)
        {
            var stringTask = client.GetStreamAsync("https://viacep.com.br/ws/"+cep+"/json/");

            var resultado = await JsonSerializer.DeserializeAsync<Endereco>(await stringTask);

            return resultado;
        }

        public async Task<IActionResult> OnPostAsync()
        {
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


                Endereco endereco = await GetEnderecoAsync(Input.Cep);
                if (string.IsNullOrEmpty(endereco.Rua))
                {
                    //return Redirect("~/Identity/Account/CadastroCompleto?Erro=CEP%20Inv%C3%A1lido.%20%20Insira%20novamente%21");
                    ModelState.AddModelError("Cep", "CEP Inválido!");
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


                Endereco endereco = await GetEnderecoAsync(Input.Cep);
                if (string.IsNullOrEmpty(endereco.Rua))
                {
                    return Redirect("~/Identity/Account/CadastroCompleto?Erro=CEP%20Inv%C3%A1lido.%20%20Insira%20novamente%21");
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
            
            await _context.SaveChangesAsync();

            HttpContext.Session.SetString("CadastroCompleto", "true");

            return Redirect("/");
        }

    }
}
