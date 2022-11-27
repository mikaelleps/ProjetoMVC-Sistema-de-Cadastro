using Microsoft.EntityFrameworkCore;
using Sistema_de_Cadastro.Models;

namespace Sistema_de_Cadastro.Data
{
    public class BancoContext : DbContext
    {
    public BancoContext(DbContextOptions<BancoContext> options) : base (options)
        {

        }
    public DbSet<ContatoModel> Contatos { get; set; }
    }
}
