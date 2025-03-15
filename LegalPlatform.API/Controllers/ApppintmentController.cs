using System.Security.Cryptography;
using Graduation_Project_Store.API.Bases;
using LegalPlatform.Core.Features.Appointments.Command.Request;
using LegalPlatform.Core.Features.Appointments.Query.Request;
using LegalPlatform.Infrastructure.Domain.DTOs.NewFolder;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace LegalPlatform.API.Controllers
{
    [ApiController]
    [Route("api/appointment")]
    public class ApppintmentController : Base
    {
        [HttpPost("Start")]
        public async Task<IActionResult> Start(StartAppointmentDTO appointment)
        {
            var startCommand = await Mediator.Send(new StartAppintmentCommand(appointment));
            return HandledResult(startCommand);
        }

        [HttpGet("Get/{Id}")]
        public async Task<IActionResult> Get(Guid Id)
        {
            var getOneQuery = await Mediator.Send(new GetAppointByIdQuery(Id));
            return HandledResult(getOneQuery);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var getAllQuery = await Mediator.Send(new GetAllAppintmentQuery());
            return HandledResult(getAllQuery);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(EditAppointmentDTO appointment)
        {
            var editCommand = await Mediator.Send(new EditAppointmentCommand(appointment));
            return HandledResult(editCommand);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Cancel(Guid Id)
        {
            var cancelCommand = await Mediator.Send(new CancelAppointmentCommand(Id));
            return HandledResult(cancelCommand);
        }
    }
}
