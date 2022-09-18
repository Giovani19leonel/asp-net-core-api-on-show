using IntegrationAPIOnShow.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationAPIOnShow.Models
{
    public class GetSearchResponse
    {
        public string Titulo { get; set; }
        public string Catalogo { get; set; }

        public static implicit operator GetSearchResponse(Filmes filmes)
        {
            return new GetSearchResponse
            {
                Titulo = filmes.Titulo,
                Catalogo = filmes.Catalogo
            };
        }
    }
}
