using GidGroup.Application.UseCases.Contacts.Commands;
using GidGroup.Application.UseCases.Contacts.Queries;
using GidGroup.Domain.Entities;
using GidGroup.Web.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GidGroup.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ContactController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateContact(ContactDTO contactDTO)
        {
            var contact = new CreateContactCommand()
            {
                Name = contactDTO.Name,
                Phone = contactDTO.Phone,
                RoomSize = contactDTO.RoomSize,
                Comment = contactDTO.Comment,
            };
            await _mediator.Send(contact);
            return Ok("Created");
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllContact()
        {
            IList<ContactUs> contacts = await _mediator.Send(new GetContactQuery());
            return Ok(contacts);
        }
    }
}
