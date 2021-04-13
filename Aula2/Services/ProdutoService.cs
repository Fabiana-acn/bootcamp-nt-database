using Aula2.Context;
using Aula2.Entities;
using Microsoft.EntityFrameworkCore;
using ProjetoWeb.DTO.Produto.Editar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.Services
{
    public class ProdutoService : IProdutoService//classe concreta implementa a interface
    {

        private readonly LocalDbContext _local;// variavel global

        public ProdutoService(LocalDbContext local)
        {
            _local = local;
        }

        public bool AdicionarProduto(Produto produto)
        {
            _local.Produtos.Add(produto);//adicionando produto
            _local.SaveChanges();//comitar
            return true;
        }

        public bool AtualizarProduto(Produto novoProduto)
        {
            _local.Produtos.Attach(novoProduto);
            _local.Entry(novoProduto).State = EntityState.Modified;
            _local.SaveChanges();
            return true;
        }

        public bool AtualizarProduto(EditarProdutoRequest editarProduto)
        {
            throw new NotImplementedException();
        }

        public bool DeletarProduto(int id)
        {
            var objApagar = _local.Produtos.Where(d => d.id == id).FirstOrDefault();//metodo where com expressao lãmbida
            _local.Produtos.Remove(objApagar);
            _local.SaveChanges();
            return true;
        }

        public List<Produto> RetonarListaProduto()
        {
            return _local.Produtos.Include(m=>m.Marca).ToList();//retorna todos os produtos do banco
        }

        public Produto RetornarProdutoPorId(int id)
        {
            return _local.Produtos.Include(m => m.Marca).Where(d => d.id == id).FirstOrDefault();
        }
    }
}
