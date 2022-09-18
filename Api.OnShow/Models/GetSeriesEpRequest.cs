using System.ComponentModel.DataAnnotations;

namespace IntegrationAPIOnShow.Models
{
    public class GetSeriesEpRequest
    {
        [Required]
        public int IdSerie { get; set; }
    }
}
