using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_OnShow.Entidades
{
    public class SeriesEp
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string TituloEp { get; set; }
        public string Video { get; set; }
        public string SinopseEp { get; set; }
        [Required]
        public string Duracao { get; set; }
        [Required]
        public int SeriesId { get; set; }
    }
}
