using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Net.Http;

namespace AdasPet.Models
{
    public class Endereco
    {
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Campo obrigat�rio!!!")]
        [Column(TypeName = "varchar(8)")]
        [StringLength(8, ErrorMessage = "O CEP deve ter 8 caracteres num�ricos.", MinimumLength = 8)]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "O CEP deve ter 8 caracteres num�ricos.")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Campo obrigat�rio!!!")]
        [Column(TypeName = "varchar(100)")]
        [JsonPropertyName("logradouro")]
        [StringLength(100, ErrorMessage = "A Rua pode ter at� 100 caracteres.")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Campo obrigat�rio!!!")]
        [Column(TypeName = "varchar(5)")]
        [Display(Name = "N�mero")]
        [StringLength(5, ErrorMessage = "O N�mero pode ter at� 5 caracteres num�ricos.")]
        public string NumeroCasa { get; set; }

        [Column(TypeName = "varchar(30)")]
        [StringLength(30, ErrorMessage = "O complemento pode ter at� 30 caracteres.")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Campo obrigat�rio!!!")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100, ErrorMessage = "O Bairro pode ter at� 100 caracteres.")]
        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo obrigat�rio!!!")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100, ErrorMessage = "A cidade pode ter at� 100 caracteres.")]
        [JsonPropertyName("localidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo obrigat�rio!!!")]
        [Column(TypeName = "varchar(2)")]
        [StringLength(2, ErrorMessage = "O Estado deve ser no formato UF.")]
        [JsonPropertyName("uf")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Campo obrigat�rio!!!")]
        public bool Principal { get; set; }

        public Cliente Cliente { get; set; }

        public Fornecedor Fornecedor { get; set; }

        public static async Task<Endereco> GetEnderecoDeCepAsync(string cep)
        {
            HttpClient client = new HttpClient();

            var stringTask = client.GetStreamAsync("https://viacep.com.br/ws/" + cep + "/json/");

            var resultado = await JsonSerializer.DeserializeAsync<Endereco>(await stringTask);

            return resultado;
        }
    }
}
