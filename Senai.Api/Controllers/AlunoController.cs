using Microsoft.AspNetCore.Mvc;

namespace Senai.Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AlunoController : ControllerBase
	{
		[HttpGet]

		public IActionResult Buscar()
		{
			return Ok();
		}
	}
}
