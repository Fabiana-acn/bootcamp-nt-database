using Aula2.Entities;
using Aula2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoWeb.DTO.Pedido.Deletar;
using ProjetoWeb.DTO.Produto.Criar;

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
            try
            {
                return Ok(_pedido.AdicionarPedido(novoPedido));
            }
            catch (System.Exception ex)
            {
                return BadRequest(new CriarPedidoResponse() { msg = ex.Message });
            }
            
        }

        [HttpPut("Editar")]
        public IActionResult Put([FromBody] Pedido novoPedido)
        {
            return Ok(_pedido.AtualizarPedido(novoPedido));
        }


        [HttpDelete("Deletar/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (_pedido.DeletarPedido(id))
                {
                    var response = new DeletarPedidoResponse() { id = id, Msg = "Excluido com Sucesso!" };
                    return Ok(response);
                }else
                {
                    throw new System.Exception("Falha ao Excluir!");
                }
            }
            catch (System.Exception ex)
            {
                var response = new DeletarPedidoResponse() { id = id, Msg = ex.Message };
                return BadRequest(response);
            }
        }
    }
}
