using System;
using System.Collections.Generic;

namespace ProjetoWeb.DTO.Produto.Criar
{
    public class LerTodosPedidoResponse
    {
        public string Msg { get; set; }
        public List<PedidoDto> Data { get; set; }        
    }
}
