using ProjetoWeb.DTO.Planta.Editar;

namespace ProjetoWeb.Bordas.UseCases
{
    public interface IEditarPlantaUseCase
    {
        EditarPlantaResponse Executar(EditarPlantaRequest request);
    }
}
