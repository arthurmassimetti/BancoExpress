using Microsoft.EntityFrameworkCore;

namespace TesteCliente
{
    public class SeuContexto : DbContext
    {
        public DbSet<SuaEntidade> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure aqui sua string de conexão, se necessário.
            optionsBuilder.UseSqlServer("DefaultConnection");
        }
    }

    public class SuaEntidade
    {
        public int ClienteId { get; set; }
        public string Cliente { get; set; }
        public string TipoCliente { get; set; }
        public string NomeContato { get; set; }
        public decimal TelefoneContato { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public int Logradouro { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
