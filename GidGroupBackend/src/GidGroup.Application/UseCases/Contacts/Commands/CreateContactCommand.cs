using MediatR;

namespace GidGroup.Application.UseCases.Contacts.Commands
{
    public class CreateContactCommand : IRequest
    {
        public string? Name { get; set; }
        public string Phone { get; set; } = default!;
        public string RoomSize { get; set; } = default!;
        public string? Comment { get; set; }
    }
}
