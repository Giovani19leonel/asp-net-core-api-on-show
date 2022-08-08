using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationAPIOnShow.Core.Extensions
{
    public class SingleResponse
    {
        protected IActionResult SucessResponse<T>(T data) =>
            new OkObjectResult(data);

        protected IActionResult SucessResponse() =>
            new OkResult();

        protected IActionResult SucessResponse(string message) =>
            new OkObjectResult(new MessageResponse(message));

        protected IActionResult ErrorResponse(string message) =>
            new BadRequestObjectResult(new MessageResponse(message));
            
    }

    public class MessageResponse
    {
        public MessageResponse()
        {

        }

        public MessageResponse(string msg)
        {
            this.message = msg;
        }

        public string message;
    }

    public class ErrorResponseEspecific
    {
        public string message { get; set; }
        public string email { get; set; }
    }
}
