using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Entidades;

namespace MinimalApi.Infraestrutura.Db;

public class DbContexto : DbContext
{

    private readonly IConfiguration _configuracaoAppSettings; // somente leitura

    //construtor
    public DbContexto(IConfiguration configuracaoAppSettings) // dado que vai receber do appsentings
    {
        _configuracaoAppSettings = configuracaoAppSettings;
    }
    
    public DbSet<Administrador> Administradores { get; set; } = default!;
    public DbSet<Veiculo> Veiculos { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrador>().HasData(
            new Administrador {
                Id = 1,
                Email = "administrador@teste.com",
                Senha = "123456",
                Perfil = "Adm"
            }
        );
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        if (!optionsBuilder.IsConfigured)
        {
            var stringConexao = _configuracaoAppSettings.GetConnectionString("SqlServer")?.ToString(); // se ele n achar nada, vem vazio

            if (!string.IsNullOrEmpty(stringConexao)) // se n for vazio ou nulo
            {
                optionsBuilder.UseSqlServer(stringConexao);
            }

        }
    }

}