using Bogus;
using ProjetoWeb.DTO.Planta.Criar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWeb.Teste.Builder
{
    public class CriarPlantaRequestBuilder
    {
        private readonly Faker _faker = new Faker("pt_BR");
        private readonly CriarPlantaRequest _adicionarPlanta;
        public CriarPlantaRequestBuilder()
        {
            //instaciar
            _adicionarPlanta = new CriarPlantaRequest();
            _adicionarPlanta.nome = _faker.Random.String(40);
            _adicionarPlanta.descricao = _faker.Random.String(40);
        }
        public CriarPlantaRequestBuilder withNameLength(int tamanho)
        {
            _adicionarPlanta.nome = _faker.Random.String(tamanho);
            return this;
        }


        public CriarPlantaRequest Build()
        {
            return _adicionarPlanta;
        }

    }
}
