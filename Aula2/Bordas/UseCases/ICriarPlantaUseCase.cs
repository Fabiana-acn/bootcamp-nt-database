using ProjetoWeb.DTO.Planta.Criar;

namespace ProjetoWeb.Bordas.UseCases
{
    public interface ICriarPlantaUseCase
    {
        CriarPlantaResponse Executar(CriarPlantaRequest request);
    }
}
