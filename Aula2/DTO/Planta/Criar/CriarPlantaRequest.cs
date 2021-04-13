using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWeb.DTO.Planta.Criar
{
    public class CriarPlantaRequest
    {
        public string nome { get; set; }
        public string descricao { get; set; }

        public string categoria { get; set; }
        public string especie { get; set; }
        public string cor { get; set; }
    }
}
