using API_OnShow.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_OnShow.Negocio;
using API_OnShow.Data;
using API_OnShow.Entidades;

namespace API_OnShow.Controllers
{
    [ApiController]
    public class FilmesController : Controller
    {

        private FilmesNegocio _filmes;
        public FilmesController(FilmesNegocio f)
        {
            _filmes = f;
        }


       // private FilmesNegocio _filmes = new FilmesNegocio(new DBContext(), new Filmes());

        [HttpPost("/add/filmes")]
        public IActionResult AdicionarFilmes(FilmesDefaultModels f)
        {
            return Ok(_filmes.InputFilmes(f));
        }

        [HttpGet("/get/filmes")]
        public IActionResult ObterFilmes()
        {
            return Ok(_filmes.ObterFilmes());
        }

        [HttpGet("/get/filme/{titulo}")]
        public IActionResult ObterFilme(string titulo)
        {
            try {
                return Ok(_filmes.ObterFilme(titulo));
            }
            catch
            {
                return Ok("Filme não encontrado.");
            }
        }

        [HttpPost("/modified/filme")]
        public IActionResult ModificarFilme(FilmesDefaultModels f)
        {
            return Ok(_filmes.ModificarFilme(f));
        }

        [HttpDelete("/delete/filme/{titulo}")]
        public IActionResult DeletarFilme(string titulo)
        {
            return Ok(_filmes.DeletarFilme(titulo));
        }
    }
}
