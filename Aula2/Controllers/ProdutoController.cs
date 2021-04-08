using Aula2.Entities;
using Aula2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
 
        private readonly ILogger<ProdutoController> _logger;
        private readonly IProdutoService _produto;

        public ProdutoController(ILogger<ProdutoController> logger, IProdutoService produto)
        {
            _logger = logger;
            _produto = produto;
        }


        //[HttpGet]
        //[Route("LerTodos")]
        //[Route("LerTodos2")]
        [HttpGet("LerTodos")]
        public IActionResult TodosProdutos()
        {
            return Ok(_produto.RetonarListaProduto());
        }

        [HttpGet("LerPorId/{id}")]
        public IActionResult Produto(int id)
        {
            return Ok(_produto.RetornarProdutoPorId(id));
        }

        [HttpPost("Criar")]
        public IActionResult ProdutoAdd([FromBody] Produto novoProduto)
        {
            return Ok(_produto.AdicionarProduto(novoProduto));
        }

        [HttpPut("Editar")]
        public IActionResult ProdutoUpdate([FromBody] Produto novoProduto)
        {
            return Ok(_produto.AtualizarProduto(novoProduto));
        }


        [HttpDelete("Deletar/{id}")]
        public IActionResult ProdutoDelete(int id)
        {
            return Ok(_produto.DeletarProduto(id));
        }




    }
}
