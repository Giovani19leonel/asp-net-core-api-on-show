using IntegrationAPIOnShow.Data.Entity;

namespace IntegrationAPIOnShow.Models
{
    public class GetFilmesGenreResponse
    {
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public string Genero { get; set; }
        public string Duracao { get; set; }
        public double Nota { get; set; }
        public string Catalogo { get; set; }
        public string Video { get; set; }

        public static implicit operator GetFilmesGenreResponse(Filmes filmes)
        {
            return new GetFilmesGenreResponse
            {
                Titulo = filmes.Titulo,
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
