using GraduationProjectStore.Core.ResultHandlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Graduation_Project_Store.API.Bases
{
    public class Base : Controller
    {
        private readonly IMediator _mediator;
        protected IMediator? Mediator => _mediator ?? HttpContext.RequestServices.GetService<IMediator>();
        public ObjectResult HandledResult<T>(Result<T> response)
        {
            return response.StatusCode switch
            {
                HttpStatusCode.OK => new OkObjectResult(response),
                HttpStatusCode.Created => new CreatedResult(string.Empty, response),
                HttpStatusCode.Unauthorized => new UnauthorizedObjectResult(response),
                HttpStatusCode.BadRequest => new BadRequestObjectResult(response),
                HttpStatusCode.UnprocessableEntity => new UnprocessableEntityObjectResult(response),
                HttpStatusCode.Accepted => new AcceptedResult(string.Empty, response),
                HttpStatusCode.NotFound => new NotFoundObjectResult(response),
                _ => new ObjectResult(response) { StatusCode = (int)response.StatusCode }
            };
        }
    }
}
