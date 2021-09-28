using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;

namespace AdasPet.Models
{
    public class Entregador
    {
        public Guid ID { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Nome { get; set; }

        [Required]
        [Column(TypeName = "varchar(11)")]
        public string CPF { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string CNH { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Telefone { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string TipoVeiculo { get; set; }

        [Required]
        [Column(TypeName = "varchar(7)")]
        public string Placa { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Renavam { get; set; }

        [Required]
        public Microsoft.AspNetCore.Identity.IdentityUser ContaCadastro { get; set; }

    }
}
