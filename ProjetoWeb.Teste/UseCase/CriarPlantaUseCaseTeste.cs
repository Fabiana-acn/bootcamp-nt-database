using Aula2.Entities;
using FluentAssertions;
using Moq;
using ProjetoWeb.Bordas.Adapter;
using ProjetoWeb.Bordas.Repositorios;
using ProjetoWeb.DTO.Planta.Criar;
using ProjetoWeb.Teste.Builder;
using ProjetoWeb.UseCase;
using System;
using Xunit;

namespace ProjetoWeb.Teste.UseCase
{

    public class CriarPlantaUseCaseTeste
    {
        private readonly Mock<IPlantaRepositorio> _repositorioPlanta;
        private readonly Mock<IPlantaAdapter> _adapter;
        private readonly CriarPlantaUseCase _usecase;

        public CriarPlantaUseCaseTeste()
        {
            _repositorioPlanta = new Mock<IPlantaRepositorio>();
            _adapter = new Mock<IPlantaAdapter>();
            _usecase = new CriarPlantaUseCase(
                _repositorioPlanta.Object,
                _adapter.Object);
        }

        [Fact]
        public void Planta_CriarPlanta_QuandoRetornarSucesso()
        {
            //Arrange
            var request = new CriarPlantaRequestBuilder().Build();
            var respose = new CriarPlantaResponse();
            var produto = new Planta();
            produto.id = 1;

            respose.Msg = "Planta adicionado com sucesso";
            respose.Id = produto.id;

            _repositorioPlanta.Setup(repositorio => repositorio.Add(produto)).Returns(produto.id);
            _adapter.Setup(adapter => adapter.ConverterCriarRequestParaPlanta(request)).Returns(produto);


            //act
            var result = _usecase.Executar(request);

            //Assert
            respose.Should().BeEquivalentTo(result);

        }

        [Fact]
        public void Planta_CriarPlanta_QuantoNomeMenorVinte()
        {
            //Arrange
            var request = new CriarPlantaRequestBuilder().withNameLength(10).Build();
            var respose = new CriarPlantaResponse();


            respose.Msg = "Erro ao adicionar o planta";


            //Act
            var result = _usecase.Executar(request);

            //Assert
            respose.Should().BeEquivalentTo(result);
        }

        [Fact]
        public void Planta_CriarPlanta_QuantoRepositorioExcecao()
        {
            //Arrange
            var request = new CriarPlantaRequestBuilder().Build();
            var respose = new CriarPlantaResponse();
            var produto = new Planta();
            produto.id = 1;
            respose.Msg = "Erro ao adicionar o planta";
            _adapter.Setup(adapter => adapter.ConverterCriarRequestParaPlanta(request)).Returns(produto);
            _repositorioPlanta.Setup(repositorio => repositorio.Add(produto)).Throws(new Exception());

            //Act
            var result = _usecase.Executar(request);

            //Assert
            respose.Should().BeEquivalentTo(result);
        }


    }
}
