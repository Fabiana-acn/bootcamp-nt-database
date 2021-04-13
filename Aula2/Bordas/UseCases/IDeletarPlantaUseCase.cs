using ProjetoWeb.DTO.Planta.Deletar;

namespace ProjetoWeb.Bordas.UseCases
{
    public interface IDeletarPlantaUseCase
    {
        DeletarPlantaResponse Executar(int  id);
    }
}
