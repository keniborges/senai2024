using System.ComponentModel.DataAnnotations;

namespace Senai.Domain.Entities
{
	public class Entity
	{
		[Key]
		public long Id { get; set; }
	}
}
