﻿using Graduation_Project_Store.API.Bases;
using LegalPlatform.Core.Features.Articales.Command.Request;
using LegalPlatform.Core.Features.Articales.Query.Request;
using LegalPlatform.Infrastructure.Domain.DTOs.Articale;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace LegalPlatform.API.Controllers
{
    [ApiController]
    [Route("api/articale")]
    [SwaggerTag("3")]
    public class ArticaleController : Base
    {
        [HttpPost("Write")]
        public async Task<IActionResult> Write(WriteArticaleDTO articale)
        {
            var writeCommand = await Mediator.Send(new WriteArticalesCommand(articale));
            return HandledResult(writeCommand);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetAll(Guid id)
        {
            var getQuery = await Mediator.Send(new GetArticaleByIdQuery(id));
            return HandledResult(getQuery);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var getAllQuery = await Mediator.Send(new GetAllArticalesQuery());
            return HandledResult(getAllQuery);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateArticaleDTO articale)
        {
            var updateCommand = await Mediator.Send(new UpdateArticalesCommand(articale));
            return HandledResult(updateCommand);
        }

        [HttpDelete("Delete/{Id}")]
        public async Task<IActionResult> Delete(Guid Id)
        {
            var deleteCommand = await Mediator.Send(new DeleteArticalesCommand(Id));
            return HandledResult(deleteCommand);
        }
    }
}
