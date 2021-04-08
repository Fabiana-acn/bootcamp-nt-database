using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.Entities
{
    public class PedidoItem
    {
        [Key]
        public int id { get; set; }
        public int PedidoId { get; set; }

        public Pedido Pedido { get; set; } //relacioname
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public decimal Valor { get; set; }
        public decimal Quantidade { get; set; }

    }
}
