using IntegrationAPIOnShow.Data.Entity;

namespace IntegrationAPIOnShow.Models
{
    public class GetPopularesResponse
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Catalogo  { get; set; }

        public static implicit operator GetPopularesResponse(Populares filmes)
        {
            return new GetPopularesResponse
            {
                Id = filmes.Id,
                Titulo = filmes.Titulo,
                Catalogo = filmes.Catalogo
            };
        }

    }
}
