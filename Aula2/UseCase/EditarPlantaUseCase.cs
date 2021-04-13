using ProjetoWeb.Bordas.Adapter;
using ProjetoWeb.Bordas.Repositorios;
using ProjetoWeb.Bordas.UseCases;
using ProjetoWeb.DTO.Planta.Editar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWeb.UseCase
{
    public class EditarPlantaUseCase : IEditarPlantaUseCase
    {
        private readonly IPlantaRepositorio _repositorioPlanta;
        private readonly IPlantaAdapter _adapter;

        public EditarPlantaUseCase(IPlantaRepositorio repo,
                                        IPlantaAdapter adapter)
        {
            _repositorioPlanta = repo;
            _adapter = adapter;
        }
        public EditarPlantaResponse Executar(EditarPlantaRequest request)
        {
            var response = new EditarPlantaResponse();

            try
            {
                if (request.id <= 0  )
                {
                    response.Msg = "Item Invalido";
                    return response;
                }

                var planta = _adapter.ConverterEditarRequestParaPlanta(request);
                var id = _repositorioPlanta.Update(planta);
                response.Msg = "Planta Alterado com sucesso";
                response.Id = request.id;
                return response;
            }
            catch
            {
                response.Msg = "Erro ao Alterar  planta";
                return response;

            }
        }
    }
}
