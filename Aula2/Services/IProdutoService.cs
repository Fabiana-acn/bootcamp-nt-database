using Aula2.Entities;
using ProjetoWeb.DTO.Produto.Editar;
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
        bool AtualizarProduto(EditarProdutoRequest editarProduto);
        bool DeletarProduto(int id);
    }
}
