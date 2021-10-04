using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdasPet.Models
{
    public class Pedido
    {
        public Guid ID { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string StatusDoPedido { get; set; }

        [Required]
        public DateTime DataInicio { get; set; }

        [Required]
        public DateTime DataFim { get; set; }        

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Pagamento { get; set; }

        [Column(TypeName = "money")]
        public double Troco { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public double Preco { get; set; }

        [Required]
        public Cliente Cliente { get; set; }

        [Required]
        public Entregador Entregador { get; set; }
        
        [Required]
        public Endereco Endereco { get; set; }

        //[Required]
        public List<Produto> Produtos { get; set; }
    }
}
