﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabMVC.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public Categoria Categoria { get; set; }
        public int IncrementarEstoque(int quantidade)
        {
            this.Estoque += quantidade;
            return this.Estoque;
        }
    }
}