using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_OnShow.Models
{
    public class FilmesDefaultModels
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Sinopse { get; set; }
        public int Ano { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Duracao { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public double Nota { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Catalogo { get; set; }
        public string Video { get; set; }
    }
}
