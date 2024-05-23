namespace Senai.Domain.Entities
{
	public class Professor : Entity
	{
		public string Nome {  get; set; }

		public long EscolaId { get; set; }
		public Escola Escola { get; set; }
	}
}
