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

        [Required(ErrorMessage = "Campo obrigatório!!!")]
        [Column(TypeName = "varchar(8)")]
        [StringLength(8, ErrorMessage = "O CEP deve ter 8 caracteres numéricos.", MinimumLength = 8)]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "O CEP deve ter 8 caracteres numéricos.")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!!!")]
        [Column(TypeName = "varchar(100)")]
        [JsonPropertyName("logradouro")]
        [StringLength(100, ErrorMessage = "A Rua pode ter até 100 caracteres.")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!!!")]
        [Column(TypeName = "varchar(5)")]
        [Display(Name = "Número")]
        [StringLength(5, ErrorMessage = "O Número pode ter até 5 caracteres numéricos.")]
        public string NumeroCasa { get; set; }

        [Column(TypeName = "varchar(30)")]
        [StringLength(30, ErrorMessage = "O complemento pode ter até 30 caracteres.")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!!!")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100, ErrorMessage = "O Bairro pode ter até 100 caracteres.")]
        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!!!")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100, ErrorMessage = "A cidade pode ter até 100 caracteres.")]
        [JsonPropertyName("localidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!!!")]
        [Column(TypeName = "varchar(2)")]
        [StringLength(2, ErrorMessage = "O Estado deve ser no formato UF.")]
        [JsonPropertyName("uf")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!!!")]
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
