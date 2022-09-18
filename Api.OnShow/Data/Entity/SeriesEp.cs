using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationAPIOnShow.Data.Entity
{
    [Table("SeriesEp")]
    public class SeriesEp
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("SeriesId")]
        public int SeriesId { get; set; }
        [Column("NumeroEp")]
        public int NumeroEp { get; set; }
        [Column("TituloEp")]
        public string TituloEp { get; set; }
        [Column("Video")]
        public string Video { get; set; }
        [Column("SinopseEp")]
        public string SinopseEp { get; set; }
        [Column("Duracao")]
        public string Duracao { get; set; }
    }
}
