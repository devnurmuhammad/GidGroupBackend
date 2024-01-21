using GidGroup.Application.Abstractions;
using GidGroup.Application.UseCases.Contacts.Commands;
using GidGroup.Domain.Entities;
using MediatR;

namespace GidGroup.Application.UseCases.Contacts.Handlers
{
    public class CreateContactHandler : AsyncRequestHandler<CreateContactCommand>
    {
        private readonly IGidGroupApplicationDbContext _context;
        public CreateContactHandler(IGidGroupApplicationDbContext context)
        {
            _context = context;
        }

        protected override async Task Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            ContactUs contact = new ContactUs()
            {
                Name = request.Name,
                Phone = request.Phone,
                Comment = request.Comment,
                RoomSize = request.RoomSize,
            };
            await _context.ContactUs.AddAsync(contact);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
