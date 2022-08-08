using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_OnShow.Entidades
{
    public class Series
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
        public double Nota { get; set; }
        [Required]
        public string Catalogo { get; set; }
    }
}
