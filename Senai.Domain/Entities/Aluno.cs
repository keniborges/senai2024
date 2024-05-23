namespace Senai.Domain.Entities
{
	public class Aluno : Entity
	{
		public string Nome { get; set; }

		public DateTime Nascimento { get; set; }

		public string Cpf { get; set; }

		public long ClasseId {  get; set; }
		public Classe Classe { get; set; }
	}
}
