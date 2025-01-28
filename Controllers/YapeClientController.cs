using MediatR;
using Microsoft.AspNetCore.Mvc;
using Yape.Application.Persons.Commands.CreateClient;
using Yape.Contracts.Persons;

namespace Yape.RestApi.Controllers
{
    [Route("[controller]")]
    public class YapeClientController : ApiController
    {
        private readonly ILogger<YapeClientController> _logger;
        private readonly IMediator _mediator;

        public YapeClientController(ILogger<YapeClientController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateClient(CreateClientRequest request)
        {
            var command = new CreateClientCommand(request.Name, request.LastName, request.CellPhoneNumber, request.DocumentType, request.DocumentNumber, request.ReasonOfUse);

            var createClientResult = await _mediator.Send(command);

            return createClientResult.Match(
                client => Ok(new ClientResponse(client.Id)),
                Problem);
        }
    }
}
