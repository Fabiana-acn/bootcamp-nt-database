using Aula2.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aula2.Context
{
    public class LocalDbContext : DbContext//classe herda do DbContext funcionalidade da biblioteca entity fc que gerencia algum BD
    {
        public LocalDbContext(DbContextOptions<LocalDbContext> opt) : base(opt) { //construtor
        
        }
        //mapeando
       public DbSet<Produto> Produtos {get;set;}
       public DbSet<Categoria> Categorias { get; set; }
       public DbSet<Marca> Marcas { get; set; }
       public DbSet<Pedido> Pedidos { get; set; }
       public DbSet<PedidoItem> PedidoItems { get; set; }
       public DbSet<Planta> Plantas { get; set; }
       
        //criar relaçoes modelando tabela
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }


    }
}