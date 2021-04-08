using System.ComponentModel.DataAnnotations;

namespace Aula2.Entities
{
    public class Marca
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
