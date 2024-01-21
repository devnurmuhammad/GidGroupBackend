using GidGroup.Application.UseCases.Recalls.Commands;
using GidGroup.Web.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GidGroup.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RecallController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RecallController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateRecall(RecallDTO recallDTO)
        {
            var recall = new CreateRecallCommand()
            {
                Name = recallDTO.Name,
                Phone = recallDTO.Phone,
            };
            await _mediator.Send(recall);
            return Ok("Created");
        }
    }
}
