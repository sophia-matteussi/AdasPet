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
        [Display(Name = "Status do Pedido")]
        public PedidoStatus StatusDoPedido { get; set; } = PedidoStatus.Novo;

        [Required]
        [Display(Name = "Data de Início")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DataInicio { get; set; }

        [Required]
        [Display(Name = "Data Final")]
        public DateTime DataFim { get; set; }        

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Forma de Pagamento")]
        public string Pagamento { get; set; }

        [Column(TypeName = "money")]
        public double Troco { get; set; }

        [Required]
        [Column(TypeName = "money")]
        [Display(Name = "Preço")]
        public double Preco { get; set; }

        [Required]
        public Cliente Cliente { get; set; }

        [Required]
        public Entregador Entregador { get; set; }
        
        [Required]
        public Endereco Endereco { get; set; }

        //[Required]
        //public List<Produto> Produtos { get; set; }

        [ForeignKey("PedidoID")]
        public virtual List<PedidoProduto> PedidoProdutos { get; set; }
    }

    public class PedidoProduto
    {
        [Key]
        //[Required]
        public Guid ID { get; set; }

        //[Required]
        [ForeignKey("Pedido")]
        public Guid PedidoID { get; set; }

        //[Required]
        [ForeignKey("Produto")]
        public Guid ProdutoID { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public PedidoStatus Status { get; set; } = PedidoStatus.Novo;
    }

    public enum PedidoStatus {
        Novo,
        Aceito,
        Recusado,
        Cancelado,
        Completo,
        Entregando

    }
}
