using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnShow.Tst.Models
{
    public class DataFileJsonModel
    {
        public List<JsonModel> populares { get; set;}
        public List<JsonModel> descricao { get; set; }
    }

    public class JsonModel
    {
        public string Id { get; set; }
        public string titulo { get; set; }
        public string sinopse { get; set; }
        public int ano { get; set; }
        public string genero { get; set; }
        public string duracao { get; set; }
        public double nota { get; set; }
        public string video { get; set; }
        public string catalogo { get; set; }
    }
}
