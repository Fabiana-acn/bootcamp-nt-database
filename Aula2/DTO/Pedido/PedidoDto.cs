using System;

namespace ProjetoWeb.DTO.Produto
{
    public class PedidoDto
    {

        public int id { get; set; }
        public string Cliente { get; set; }
        public DateTime Data { get; set; }
        public decimal valorTotal { get; set; }
    }
}
