namespace Senai.Domain.Entities
{
	public class Escola : Entity
	{
		public string Nome { get; set; }

		public Endereco Endereco { get; set; }	

		public List<Professor> Professores { get; set; }

		public List<Classe> Classes {  get; set; }

	}
}
