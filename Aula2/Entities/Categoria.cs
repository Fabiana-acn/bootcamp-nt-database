using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//Fornece classes de atributos que são usadas para definir metadados para controles de dados
using System.Linq;
using System.Threading.Tasks;
//adiciona os atributos as tabelas
namespace Aula2.Entities
{
    public class Categoria
    {
        [Key]// chave primaria
        public int Id { get; set; }
        public string Descricao { get; set; }

    }
}
