using System.ComponentModel.DataAnnotations.Schema;

namespace API_OnShow.Entidades
{
    [Table("Carrossel")]
    public class Carrossel
    {
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
