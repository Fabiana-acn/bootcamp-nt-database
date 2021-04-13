using ProjetoWeb.Bordas.Adapter;
using ProjetoWeb.Bordas.Repositorios;
using ProjetoWeb.Bordas.UseCases;
using ProjetoWeb.DTO.Planta.LerPorId;
using System;

namespace ProjetoWeb.UseCase
{
    public class LerPorIdPlantaUseCase : ILerPorIdPlantaUseCase
    {
        private readonly IPlantaRepositorio _repositorioPlanta;
        private readonly IPlantaAdapter _adapter;

        public LerPorIdPlantaUseCase(IPlantaRepositorio repo,
                                        IPlantaAdapter adapter)
        {
            _repositorioPlanta = repo;
            _adapter = adapter;
        }
        public LerPorIdPlantaResponse Executar(int id)
        {
            var response = new LerPorIdPlantaResponse();
            try
            {
                var planta =_repositorioPlanta.GetById(id);
                if(planta != null)
                {
                    response.id = planta.id;
                    response.cor = planta.cor;
                    response.categoria = planta.categoria;
                    response.descricao = planta.descricao;
                    response.especie = planta.especie;
                    response.nome = planta.nome;
                }

                return response;
            }
            catch (Exception e)
            {
                throw new System.Exception(e.Message);
            }
        }
    }
}
