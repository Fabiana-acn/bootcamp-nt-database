using Aula2.Entities;
using Aula2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Aula2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
 
        private readonly ILogger<PedidoController> _logger;
        private readonly IPedidoService _pedido;

        public PedidoController(ILogger<PedidoController> logger, IPedidoService pedido)
        {
            _logger = logger;
            _pedido = pedido;
        }


        //[HttpGet]
        //[Route("LerTodos")]
        //[Route("LerTodos2")]
        [HttpGet("LerTodos")]
        public IActionResult Get()
        {
            return Ok(_pedido.RetonarListaPedido());
        }

        [HttpGet("LerPorId/{id}")]
        public IActionResult Pedido(int id)
        {
            return Ok(_pedido.RetornarPedidoPorId(id));
        }

        [HttpPost("Criar")]
        public IActionResult Post([FromBody] Pedido novoPedido)
        {
            return Ok(_pedido.AdicionarPedido(novoPedido));
        }

        [HttpPut("Editar")]
        public IActionResult Put([FromBody] Pedido novoPedido)
        {
            return Ok(_pedido.AtualizarPedido(novoPedido));
        }


        [HttpDelete("Deletar/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_pedido.DeletarPedido(id));
        }




    }
}
