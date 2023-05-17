using Microsoft.EntityFrameworkCore;
using WebApp_Tarde.Entidades;

namespace WebApp_Tarde
{
    public class Contexto : DbContexto
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt)
        { }

        public DbSet<ProdutoEntidade> Produtos { get; set; }
        public DbSet<PermissaoEntidade> Permissao { get; set; }
        public DbSet<CategoriasEntidade> Categorias { get; set; }
        public DbSet<VendasEntidade> Vendas { get; set; }
        public DbSet<ItensVendaEntidade> ItensVenda { get; set; }
    }
}
