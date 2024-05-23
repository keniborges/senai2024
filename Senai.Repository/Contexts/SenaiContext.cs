using Microsoft.EntityFrameworkCore;
using Senai.Domain.Entities;

namespace Senai.Repository.Contexts
{
	public class SenaiContext : DbContext
	{

		public DbSet<Escola> Escola { get; set; }
		public DbSet<Endereco> Endereco { get; set; }
		public DbSet<Professor> Professor { get; set; }
		public DbSet<Classe> Classe { get; set; }
		public DbSet<Aluno> Aluno { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseNpgsql("Server=192.168.50.45;Port=5432;Database=Senai2024;User Id=postgres;Password=pezqE7G7;");
		}




	}
}
