using GidGroup.Application.Abstractions;
using GidGroup.Application.UseCases.Contacts.Queries;
using GidGroup.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GidGroup.Application.UseCases.Contacts.Handlers
{
    public class GetAllContactHandler : IRequestHandler<GetContactQuery, IList<ContactUs>>
    {
        private readonly IGidGroupApplicationDbContext _context;
        public GetAllContactHandler(IGidGroupApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<ContactUs>> Handle(GetContactQuery request, CancellationToken cancellationToken)
        {
            IList<ContactUs> contacts = await _context.ContactUs.ToListAsync(cancellationToken);
            return contacts;
        }
    }
}
