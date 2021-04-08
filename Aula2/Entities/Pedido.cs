using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.Entities
{
    public class Pedido
    {
        [Key]
        public int id { get; set; }
        public string Cliente { get; set; }
        public DateTime Data { get; set; }
        public decimal valor { get; set; }
        public ICollection<PedidoItem> Items { get; set; }// criar uma lista de pedidos 
       
    }
}
