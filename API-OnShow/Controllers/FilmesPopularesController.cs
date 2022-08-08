using API_OnShow.Data;
using API_OnShow.Entidades;
using API_OnShow.Negocio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_OnShow.Controllers
{
    public class FilmesPopularesController : Controller
    {
        private FilmesPopularesNegocio _filmes = new FilmesPopularesNegocio(new DBContext(), new Populares());

        [HttpPost("/add/filmes/populares/{titulo}")]
        public IActionResult AdicionarFilmes(string titulo)
        {
            return Ok(_filmes.InputFilmes(titulo));
        }

        [HttpGet("/get/filmes/populares")]
        public IActionResult ObterFilmes()
        {
            return Ok(_filmes.ObterFilmes());
        }

        [HttpGet("/get/filmes/populares/{titulo}")]
        public IActionResult ObterFilme(string titulo)
        {
            return Ok(_filmes.ObterFilme(titulo));
        }

        [HttpDelete("/delete/filmes/populares/{titulo}")]
        public IActionResult DeletarFilme(string titulo)
        {
            return Ok(_filmes.DeletarFilme(titulo));
        }

    }
}
