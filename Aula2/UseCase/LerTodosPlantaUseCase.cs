using ProjetoWeb.Bordas.Adapter;
using ProjetoWeb.Bordas.Repositorios;
using ProjetoWeb.Bordas.UseCases;
using ProjetoWeb.DTO.Planta.Criar;
using ProjetoWeb.DTO.Planta.Deletar;
using ProjetoWeb.DTO.Planta.LerTodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWeb.UseCase
{
    public class LerTodosPlantaUseCase : ILerTodosPlantaUseCase
    {
        private readonly IPlantaRepositorio _repositorioPlanta;


        public LerTodosPlantaUseCase(IPlantaRepositorio repo)
        {
            _repositorioPlanta = repo;

        }
        public LerTodosPlantaResponse Executar()
        {
            var response = new LerTodosPlantaResponse();

            try
            {
                var plantas = _repositorioPlanta.All();
                if (plantas != null)
                {
                    response.dados = plantas.Select(planta => new DTO.Planta.PlantaDto()
                    {
                        id = planta.id,
                        cor = planta.cor,
                        categoria = planta.categoria,
                        descricao = planta.descricao,
                        especie = planta.especie,
                        nome = planta.nome
                    }).ToList();

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
