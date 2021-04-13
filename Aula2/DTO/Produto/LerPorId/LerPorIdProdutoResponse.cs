using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWeb.DTO.Produto.LerPorId
{
    public class LerPorIdProdutoResponse
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal valor { get; set; }
        public String Marca { get; set; }
        public string Cor { get; set; }
    }
}
