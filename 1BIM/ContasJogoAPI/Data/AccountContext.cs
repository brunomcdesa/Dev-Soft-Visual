using Contas_de_Jogo.Model;
using Microsoft.EntityFrameworkCore;

namespace Contas_de_Jogo.Data
{
    public class AccountContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<KDA> KDAs { get; set; }
        
        public AccountContext(DbContextOptions<AccountContext> opts) : base(opts) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
           IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .Build();

            optionsBuilder.UseMySQL(configuration.GetConnectionString("AccountConnection"));

        }
        
    }
}
