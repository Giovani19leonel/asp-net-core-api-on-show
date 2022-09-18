using IntegrationAPIOnShow.Data.Entity;

namespace IntegrationAPIOnShow.Models
{
    public class GetFilmesResponse
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public int Ano { get; set; }
        public string Genero { get; set; }
        public string Duracao { get; set; }
        public double Nota { get; set; }
        public string Catalogo { get; set; }
        public string Video { get; set; }

        public static implicit operator GetFilmesResponse(Filmes filmes)
        {
            return new GetFilmesResponse
            {
                Id = filmes.Id,
                Titulo = filmes.Titulo,
                Sinopse = filmes.Sinopse,
                Ano = filmes.Ano,
                Genero = filmes.Genero,
                Duracao = filmes.Duracao,
                Nota = filmes.Nota,
                Catalogo = filmes.Catalogo,
                Video = filmes.Video
            };
        }
    }
}
