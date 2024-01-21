using GidGroup.Domain.Entities;
using MediatR;

namespace GidGroup.Application.UseCases.Recalls.Queries
{
    public class GetRecallQuery : IRequest<IList<Recall>>
    {
    }
}
