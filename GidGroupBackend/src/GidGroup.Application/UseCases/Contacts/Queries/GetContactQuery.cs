using GidGroup.Domain.Entities;
using MediatR;

namespace GidGroup.Application.UseCases.Contacts.Queries
{
    public class GetContactQuery : IRequest<IList<ContactUs>>
    {
    }
}
