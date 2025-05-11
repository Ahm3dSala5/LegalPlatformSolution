using Graduation_Project_Store.API.Bases;
using LegalPlatform.Core.Features.Payments.Command.Request;
using LegalPlatform.Core.Features.Payments.Query.Request;
using LegalPlatform.Infrastructure.Domain.DTOs.Payment;
using Microsoft.AspNetCore.Mvc;

namespace LegalPlatform.API.Controllers
{
    [ApiController]
    [Route("api/Payment")]
    public class PaymentController : Base
    {
        [HttpPost("Start")]
        public async Task<IActionResult> Start(StartPaymentDTO payment)
        {
            var startCommand = await Mediator.Send(new StartPaymentCommand(payment));
            return HandledResult(startCommand);
        }

        [HttpGet("Get/{Id}")]
        public async Task<IActionResult> Get(Guid Id)
        {
            var getOneQuery = await Mediator.Send(new GetPaymentByIdQuery(Id));
            return HandledResult(getOneQuery);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var getAllQuery = await Mediator.Send(new GetAllPaymentQuery());
            return HandledResult(getAllQuery);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(EditPaymentDTO payment)
        {
            var editCommand = await Mediator.Send(new EditPaymentCommand(payment));
            return HandledResult(editCommand);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Cancel(Guid Id)
        {
            var cancelCommand = await Mediator.Send(new CancelPaymetCommand(Id));
            return HandledResult(cancelCommand);
        }
    }

   
}
