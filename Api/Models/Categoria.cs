using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string? Nome { get; set; }
        public string? ImageUrl { get; set; }
    }
}