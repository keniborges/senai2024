using Senai.Domain.Enums;

namespace Senai.Domain.Entities
{
	public class Classe : Entity
	{
		public SerieEnum Serie { get; set; }

		public long EscolaId { get; set; }
		public Escola Escola { get; set;}

		public long ProfessorId {  get; set; }
		public Professor Professor { get; set; }

		public List<Aluno> Alunos { get; set; }

	}
}
