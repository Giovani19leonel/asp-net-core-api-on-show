using IntegrationAPIOnShow.Models;
using IntegrationAPIOnShow.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IntegrationAPIOnShow.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MainController : Controller
    {
        private readonly MainServices _mainServices;

        public MainController(MainServices mainServices)
        {
            _mainServices = mainServices;
        }

        [HttpGet("carousel")]
        public async Task<IActionResult> GetCarousel() =>
            await _mainServices.GetCarousel();
        [HttpGet("search")]
        public async Task<IActionResult> GetSearch([FromBody] GetSearchRequest request) =>
            await _mainServices.Search(request);
        [HttpGet("populares")]
        public async Task<IActionResult> GetPopulares() =>
            await _mainServices.GetPopulares();
        [HttpGet("series")]
        public async Task<IActionResult> GetSeries() =>
            await _mainServices.GetSeries();
        [HttpGet("filmes/last")]
        public async Task<IActionResult> GetLastFilmes() =>
            await _mainServices.GetLastFilmes();
    }
}
