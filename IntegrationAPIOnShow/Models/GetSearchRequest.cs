using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationAPIOnShow.Models
{
    public class GetSearchRequest
    {
        [Required]
        public string Message { get; set; }
    }
}
