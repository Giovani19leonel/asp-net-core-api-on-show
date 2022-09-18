using API_OnShow.Negocio;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API_OnShow.Controllers
{
    [ApiController]
    public class FilmesCarrosselController : Controller
    {
        private CarrosselNegocio _carrossel;
        public FilmesCarrosselController(CarrosselNegocio carrossel)
        {
            _carrossel = carrossel;
        }

        [HttpGet("get/filmes/carrossel")]
        public async Task<IActionResult> GetFilmesCarrossel() =>
            Ok(await _carrossel.GetFilmesCarrossel());

        [HttpPost("add/filmes/carrossel")]
        public async Task<IActionResult> PostFilmesCarrossel(string titulo) =>
            Ok(await _carrossel.PostFilmesCarrossel(titulo));

        [HttpDelete("delete/filmes/carrossel")]
        public async Task<IActionResult> DeleteFilmesCarrossel(string titulo) =>
            Ok(await _carrossel.DeleteFilmesCarrossel(titulo));
    }
}
