namespace Senai.Domain.Entities
{
	public class Endereco : Entity
	{
		public string Rua { get; set; }

		public string Bairro { get; set; }

		public string Cidade { get; set; }

		public string Estado { get; set; }

		public int Numero { get; set; }

		public long EscolaId { get; set; }

		public Escola Escola { get; set; }
	}
}
