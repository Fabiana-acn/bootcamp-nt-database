using Aula2.Entities;
using System.Collections.Generic;

namespace Aula2.Services
{
    public interface IPedidoService
    {
        bool AdicionarPedido(Pedido pedido);
        List<Pedido> RetonarListaPedido();
        Pedido RetornarPedidoPorId(int id);
        bool AtualizarPedido(Pedido novoPedido);
        bool DeletarPedido(int id);
    }
}

