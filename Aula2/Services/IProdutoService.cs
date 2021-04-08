using Aula2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.Services
{
    public interface IProdutoService
    {
        bool AdicionarProduto(Produto produto);//produto como parametro
        List<Produto> RetonarListaProduto();
        Produto RetornarProdutoPorId(int id);
        bool AtualizarProduto(Produto novoProduto);
        bool DeletarProduto(int id);
    }
}
