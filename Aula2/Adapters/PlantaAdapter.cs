using Aula2.Entities;
using ProjetoWeb.Bordas.Adapter;
using ProjetoWeb.DTO.Planta.Criar;
using ProjetoWeb.DTO.Planta.Editar;

namespace ProjetoWeb.Adapters
{
    public class PlantaAdapter : IPlantaAdapter
    {
        public Planta ConverterCriarRequestParaPlanta(CriarPlantaRequest request)
        {
            return new Planta()
            {
                categoria = request.categoria,
                cor = request.cor,
                nome = request.nome,
                especie = request.especie,
                descricao = request.descricao
            };
        }

        public Planta ConverterEditarRequestParaPlanta(EditarPlantaRequest request)
        {
            return new Planta()
            {
                id=request.id,
                nome = request.nome,
                categoria = request.categoria,
                cor = request.cor,               
                especie = request.especie,
                descricao = request.descricao
            };

        }
    }
}
