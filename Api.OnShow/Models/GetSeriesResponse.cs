using IntegrationAPIOnShow.Data.Entity;

namespace IntegrationAPIOnShow.Models
{
    public class GetSeriesResponse
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Catalogo { get; set; }

        public static implicit operator GetSeriesResponse(Series series)
        {
            return new GetSeriesResponse
            {
                Id = series.Id,
                Titulo = series.Titulo,
                Catalogo = series.Catalogo
            };
        }
    }
}