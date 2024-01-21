using GidGroup.Application.Abstractions;
using GidGroup.Application.UseCases.Catalogs.Queries;
using GidGroup.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GidGroup.Application.UseCases.Catalogs.Handlers
{
    public class GetCatalogHandler : IRequestHandler<GetCatalogQuery, IList<GetCatalog>>
    {
        private readonly IGidGroupApplicationDbContext _context;
        public GetCatalogHandler(IGidGroupApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<GetCatalog>> Handle(GetCatalogQuery request, CancellationToken cancellationToken)
        {
            IList<GetCatalog> catalogs = await _context.GetCatalogs.ToListAsync(cancellationToken);
            return catalogs;
        }
    }
}
