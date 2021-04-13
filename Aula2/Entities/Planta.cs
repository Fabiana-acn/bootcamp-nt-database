using System.ComponentModel.DataAnnotations;

namespace Aula2.Entities
{
    public class Planta
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }

        public string categoria { get; set; }
        public string especie { get; set; }
        public string cor { get; set; }
    }
}
