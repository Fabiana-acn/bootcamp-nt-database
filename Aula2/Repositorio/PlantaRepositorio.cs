using Aula2.Context;
using Aula2.Entities;
using Microsoft.EntityFrameworkCore;
using ProjetoWeb.Bordas.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWeb.Repositorio
{
    public class PlantaRepositorio : IPlantaRepositorio
    {
        private readonly LocalDbContext _local;// variavel global

        public PlantaRepositorio(LocalDbContext local)
        {
            _local = local;
        }
        public int Add(Planta model)
        {
            _local.Plantas.Add(model);//adicionando 
            return _local.SaveChanges();
        }

        public List<Planta> All()
        {
            return _local.Plantas.ToList();
        }

        public void Delete(int id)
        {
            var objApagar = _local.Plantas.Where(d => d.id == id).FirstOrDefault();//metodo where com expressao lãmbida
            _local.Plantas.Remove(objApagar);
            _local.SaveChanges();
        }

        public Planta GetById(int id)
        {
            return _local.Plantas.Where(d => d.id == id).FirstOrDefault();
        }

        public void Remove(object id)
        {
            throw new NotImplementedException();
        }

        public int Update(Planta model)
        {
            _local.Plantas.Attach(model);
            _local.Entry(model).State = EntityState.Modified;
            return _local.SaveChanges();
        }
    }
}
