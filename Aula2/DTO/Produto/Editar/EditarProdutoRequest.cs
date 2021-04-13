using Aula2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWeb.DTO.Produto.Editar
{
    public class EditarProdutoRequest
    {
        public string descricao { get; set; }
        public decimal valor { get; set; }
        public string Cor { get; set; }
    }
}
