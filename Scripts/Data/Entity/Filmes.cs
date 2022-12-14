using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnShow.Tst.Data.Entity
{
    [Table("Filmes")]
    public class Filmes
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Titulo")]
        public string Titulo { get; set; }
        [Column("Sinopse")]
        public string Sinopse { get; set; }
        [Column("Ano")]
        public int Ano { get; set; }
        [Column("Genero")]
        public string Genero { get; set; }
        [Column("Duracao")]
        public string Duracao { get; set; }
        [Column("Nota")]
        public double Nota { get; set; }
        [Column("Catalogo")]
        public string Catalogo { get; set; }
        [Column("Video")]
        public string Video { get; set; }
    }
}
