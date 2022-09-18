using IntegrationAPIOnShow.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationAPIOnShow.Models
{
    public class GetCarouselResponse
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Catalogo { get; set; }

        public static implicit operator GetCarouselResponse(Carrossel carrossel)
        {
            return new GetCarouselResponse()
            {
                Id = carrossel.Id,
                Titulo = carrossel.Titulo,
                Catalogo = carrossel.Catalogo
            };
        }
    }
}
