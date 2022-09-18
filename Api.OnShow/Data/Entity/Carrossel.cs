using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationAPIOnShow.Data.Entity
{
    [Table("Carrossel")]
    public class Carrossel
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Titulo")]
        public string Titulo { get; set; }
        [Column("Ano")]
        public int Ano { get; set; }
        [Column("Nota")]
        public double Nota { get; set; }
        [Column("Catalogo")]
        public string Catalogo { get; set; }
    }
}
