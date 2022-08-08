using API_OnShow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_OnShow.Negocio
{
    public interface IFilmes
    {
        public FilmesDefaultModels ObterFilme(string titulo);
        public List<FilmesDefaultModels> ObterFilmes();
        public string DeletarFilme(string titulo);

    }
}
