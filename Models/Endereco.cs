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

        [Required]
        [Column(TypeName = "varchar(8)")]
        public string CEP { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [JsonPropertyName("logradouro")]
        public string Rua { get; set; }

        [Required]
        [Column(TypeName = "varchar(5)")]
        public string NumeroCasa { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Complemento { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [JsonPropertyName("localidade")]
        public string Cidade { get; set; }

        [Required]
        [Column(TypeName = "varchar(2)")]
        [JsonPropertyName("uf")]
        public string Estado { get; set; }

        [Required]
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
