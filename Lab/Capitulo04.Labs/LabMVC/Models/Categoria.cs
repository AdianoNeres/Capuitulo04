using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabMVC.Models
{
    public class Categoria
    {
        public Categoria()
        {
            this.Produtos = new List<Produto>();
        }
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}