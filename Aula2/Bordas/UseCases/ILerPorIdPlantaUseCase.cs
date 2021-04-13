using ProjetoWeb.DTO.Planta.LerPorId;

namespace ProjetoWeb.Bordas.UseCases
{
    public interface ILerPorIdPlantaUseCase
    {
        LerPorIdPlantaResponse Executar(int  id);
    }
}
