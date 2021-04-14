using ProjetoWeb.Bordas.Adapter;
using ProjetoWeb.Bordas.Repositorios;
using ProjetoWeb.Bordas.UseCases;
using ProjetoWeb.DTO.Planta.Criar;

namespace ProjetoWeb.UseCase
{
    public class CriarPlantaUseCase : ICriarPlantaUseCase
    {
        private readonly IPlantaRepositorio _repositorioPlanta;
        private readonly IPlantaAdapter _adapter;

        public CriarPlantaUseCase(IPlantaRepositorio repo,
                                        IPlantaAdapter adapter)
        {
            _repositorioPlanta = repo;
            _adapter = adapter;
        }

        public CriarPlantaResponse Executar(CriarPlantaRequest request)
        {
            var response = new CriarPlantaResponse();

            try
            {
                if (request.nome.Length < 20)
                {
                    response.Msg = "Erro ao adicionar o planta";
                    return response;
                }

                var produtoAdicionar = _adapter.ConverterCriarRequestParaPlanta(request);
                var id = _repositorioPlanta.Add(produtoAdicionar);
                response.Msg = "Planta adicionado com sucesso";
                response.Id = produtoAdicionar.id;
                return response;
            }
            catch
            {
                response.Msg = "Erro ao adicionar o planta";
                return response;

            }
        }
    }
}
