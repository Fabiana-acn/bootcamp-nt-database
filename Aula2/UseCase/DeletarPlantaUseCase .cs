using ProjetoWeb.Bordas.Adapter;
using ProjetoWeb.Bordas.Repositorios;
using ProjetoWeb.Bordas.UseCases;
using ProjetoWeb.DTO.Planta.Deletar;
using System;

namespace ProjetoWeb.UseCase
{
    public class DeletarPlantaUseCase : IDeletarPlantaUseCase
    {
        private readonly IPlantaAdapter _adapter;
        private readonly IPlantaRepositorio _repo;

        public DeletarPlantaUseCase(IPlantaRepositorio repo, IPlantaAdapter adapter)
        {
            _repo = repo;
            _adapter = adapter;

        }

        public DeletarPlantaResponse Executar(int id)
        {
            var response = new DeletarPlantaResponse();
            try
            {
                _repo.Delete(id);
                response.msg = "Removido com sucesso";
                return response;
            }
            catch (Exception e)
            {
                throw new System.Exception(e.Message);
            }
        }
    }
}
