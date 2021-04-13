using Aula2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWeb.DTO.Produto.Criar
{
    public class CriarProdutoRequest
    {
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal valor { get; set; }
        public Marca Marca { get; set; }
        public string Cor { get; set; }
    }
}
