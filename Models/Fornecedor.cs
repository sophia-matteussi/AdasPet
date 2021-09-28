using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdasPet.Models
{
    public class Fornecedor
    {   
        public Guid ID { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string RazaoSocial { get; set; }

        [Required]
        [Column(TypeName = "varchar(14)")]
        public string CNPJ { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Telefone { get; set; }

        [Required]
        public Microsoft.AspNetCore.Identity.IdentityUser ContaCadastro { get; set; }

    }
}
