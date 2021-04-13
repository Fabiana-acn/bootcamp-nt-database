using Aula2.Context;
using Aula2.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Aula2.Services
{
    public class PedidoService : IPedidoService//classe concreta implementa a interface
    {

        private readonly LocalDbContext _local;// variavel global

        public PedidoService(LocalDbContext local)
        {
            _local = local;
        }

        public bool AdicionarPedido(Pedido pedido)
        {
            _local.Pedidos.Add(pedido);//adicionando Pedido
            _local.SaveChanges();//comitar no bb
            return true;
        }

        public bool AtualizarPedido(Pedido novoPedido)
        {
            _local.Pedidos.Attach(novoPedido);
            _local.Entry(novoPedido).State = EntityState.Modified;
            _local.SaveChanges();
            return true;
        }

        public bool DeletarPedido(int id)
        {
            var objApagar = _local.Pedidos.Where(d => d.id == id).FirstOrDefault();//metodo where com expressao lãmbida
            _local.Pedidos.Remove(objApagar);
            _local.SaveChanges();
            return true;
        }

        public List<Pedido> RetonarListaPedido()
        {
            return _local.Pedidos.ToList();//retorna todos os Pedidos do banco
        }

        public Pedido RetornarPedidoPorId(int id)
        {
            return _local.Pedidos.Where(d => d.id == id).FirstOrDefault();
        }
    }
}
