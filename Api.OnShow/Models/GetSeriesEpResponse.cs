using IntegrationAPIOnShow.Data.Entity;

namespace IntegrationAPIOnShow.Models
{
    public class GetSeriesEpResponse
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int NumeroEp { get; set; }

        public static implicit operator GetSeriesEpResponse(SeriesEp seriesEp)
        {
            return new GetSeriesEpResponse
            {
                Id = seriesEp.Id,
                Titulo = seriesEp.TituloEp,
                NumeroEp = seriesEp.NumeroEp
            };
        }

    }
}
