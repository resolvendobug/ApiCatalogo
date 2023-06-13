using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Api.Models
{
    
    public class Categoria
    {
        public Categoria(){
            Produtos = new Collection<Produto>();
        }

        [Key]
        public int CategoriaId { get; set; }
        [Required]
        [StringLength(100)]
        public string? Nome { get; set; }
        
        [Required]
        [StringLength(300)]
        public string? ImageUrl { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}