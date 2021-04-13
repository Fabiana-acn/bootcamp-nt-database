using Aula2.Entities;
using ProjetoWeb.DTO.Planta.Criar;
using ProjetoWeb.DTO.Planta.Editar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWeb.Bordas.Adapter
{
    public interface IPlantaAdapter
    {
        public Planta ConverterCriarRequestParaPlanta(CriarPlantaRequest request);
        public Planta ConverterEditarRequestParaPlanta(EditarPlantaRequest request);

    }
}
