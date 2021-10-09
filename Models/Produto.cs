using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdasPet.Models
{
    public class Produto
    {
        public Guid ID { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Nome { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Marca { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string TipoDeAnimal { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Categoria { get; set; }

        [Required]
        [Column(TypeName = "money")]
        [RegularExpression(@"^\d+\.\d\d$", ErrorMessage = "O Preço precisa ser no formato 0.00")]
        public double Preco { get; set; }

        [Required]
        public int QtdEmEstoque { get; set; }

        [Required]
        [Column(TypeName = "bit")]
        public bool PrecisaDeCarro { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Descricao { get; set; }

        //[Required]
        public Microsoft.AspNetCore.Identity.IdentityUser ContaCadastro { get; set; }

        public List<Pedido> Pedidos { get; set; }

    }
}
