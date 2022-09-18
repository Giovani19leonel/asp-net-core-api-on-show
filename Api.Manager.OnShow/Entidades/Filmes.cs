using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_OnShow.Entidades
{
    public class Filmes
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Sinopse { get; set; }
        public int Ano { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        public string Duracao { get; set; }
        [Required]
        public double Nota { get; set; }
        [Required]
        public string Catalogo { get; set; }
        public string Video { get; set; }

    }
}
