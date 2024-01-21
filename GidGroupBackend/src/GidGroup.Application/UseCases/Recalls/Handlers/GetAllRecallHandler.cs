using GidGroup.Application.Abstractions;
using GidGroup.Application.UseCases.Recalls.Queries;
using GidGroup.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GidGroup.Application.UseCases.Recalls.Handlers
{
    public class GetAllRecallHandler : IRequestHandler<GetRecallQuery, IList<Recall>>
    {
        private readonly IGidGroupApplicationDbContext _context;

        public GetAllRecallHandler(IGidGroupApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IList<Recall>> Handle(GetRecallQuery request, CancellationToken cancellationToken)
        {
            IList<Recall> recalls = await _context.Recalls.ToListAsync(cancellationToken);
            return recalls;
        }
    }
}
