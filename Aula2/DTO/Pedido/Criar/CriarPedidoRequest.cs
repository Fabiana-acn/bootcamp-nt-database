using System;
using System.Collections.Generic;

namespace ProjetoWeb.DTO.Produto.Criar
{
    public class CriarPedidoRequest
    {

        public string Cliente { get; set; }
        public List<PedidoItemDto> Itens { get; set; }

    }
}
