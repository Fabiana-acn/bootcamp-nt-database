using Aula2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWeb.Bordas.Repositorios
{
    public interface IPlantaRepositorio
    {
        int Add(Planta model);
        List<Planta> All();
        Planta GetById(int id);
        int Update(Planta model);
        void Delete(int id);
        void Remove(object id);
    }
}

 //namespace Aula2.Bordas.Repositorios
//{
   // public interface IRepositorioProdutos
    //{
      //  public int Add(Produto request);
       // public void Remove(int id);
   // }
//}
