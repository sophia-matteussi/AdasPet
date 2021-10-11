using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdasPet.Models
{
    /// <summary>
    /// Enum com todos os tipos de animais possiveis
    /// </summary>
    public enum ProdutoAnimais
    {
        [Display(Name = "Cachorros")]
        Cachorro,
        [Display(Name = "Gatos")]
        Gato,
        [Display(Name = "Passáros")]
        Passaro,
        [Display(Name = "Peixes")]
        Peixe,
        [Display(Name = "Coelhos")]
        Coelho,
        [Display(Name = "Roedores")]
        Roedores,
        [Display(Name = "Répteis")]
        Repteis
    }

    /// <summary>
    /// Enum com todos os tipos de categorias possiveis
    /// </summary>
    public enum ProdutoCategorias
    {
        [Display(Name="Alimentação")]
        Alimentacao,
        [Display(Name = "Acessórios e Equipamentos")]
        Acessorio,
        [Display(Name = "Brinquedos")]
        Brinquedos,
        [Display(Name = "Farmácia")]
        Farmacia,
        [Display(Name = "Higiene")]
        Higiene
    }
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
        //[Column(TypeName = "varchar(20)")]
        public ProdutoAnimais TipoDeAnimal { get; set; }

        [Required]
        //[Column(TypeName = "varchar(20)")]
        public ProdutoCategorias Categoria { get; set; }

        [Required]
        [Column(TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name ="Preço")]
        public double Preco { get; set; }

        [Required]
        [Display(Name = "Quantidade em estoque")]
        public int QtdEmEstoque { get; set; }

        [Required]
        [Column(TypeName = "bit")]
        public bool PrecisaDeCarro { get; set; }

        [Column(TypeName = "varchar(200)")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        //[Required]
        public Microsoft.AspNetCore.Identity.IdentityUser ContaCadastro { get; set; }

        public List<Pedido> Pedidos { get; set; }

    }
}
