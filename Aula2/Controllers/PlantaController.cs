using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoWeb.Bordas.UseCases;
using ProjetoWeb.DTO.Planta.Criar;
using ProjetoWeb.DTO.Planta.Editar;

namespace Aula2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlantaController : ControllerBase
    {
 
        private readonly ILogger<PlantaController> _logger;
        private readonly ICriarPlantaUseCase _criarPlantaUseCase;
        private readonly IEditarPlantaUseCase _editarPlantaUseCase;
        private readonly IDeletarPlantaUseCase _deletarPlantaUseCase;
        private readonly ILerPorIdPlantaUseCase _lerPorIdPlantaUseCase;
        private readonly ILerTodosPlantaUseCase _lerTodosPlantaUseCase;

        public PlantaController(ILogger<PlantaController> logger,
            ICriarPlantaUseCase criarPlantaUseCase,
            IEditarPlantaUseCase editarPlantaUseCase,
            IDeletarPlantaUseCase deletarPlantaUseCase,
            ILerPorIdPlantaUseCase lerPorIdPlantaUseCase,
            ILerTodosPlantaUseCase lerTodosPlantaUseCase)
        {
            _logger = logger;
            _criarPlantaUseCase = criarPlantaUseCase;
            _editarPlantaUseCase = editarPlantaUseCase;
            _deletarPlantaUseCase = deletarPlantaUseCase;
            _lerPorIdPlantaUseCase = lerPorIdPlantaUseCase;
            _lerTodosPlantaUseCase = lerTodosPlantaUseCase;
        }



        [HttpGet("LerTodos")]
        public IActionResult Todos()
        {
            return Ok(_lerTodosPlantaUseCase.Executar());
        }

        [HttpGet("LerPorId/{id}")]
        public IActionResult PorId(int id)
        {
            return Ok(_lerPorIdPlantaUseCase.Executar(id));
        }

        [HttpPost("Criar")]
        public IActionResult Add([FromBody] CriarPlantaRequest model)
        {
            return Ok(_criarPlantaUseCase.Executar(model));
        }

        [HttpPut("Editar")]
        public IActionResult Update([FromBody] EditarPlantaRequest editarPlanta)
        {
            return Ok(_editarPlantaUseCase.Executar(editarPlanta));
        }


        [HttpDelete("Deletar/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_deletarPlantaUseCase.Executar(id));
        }




    }
}
