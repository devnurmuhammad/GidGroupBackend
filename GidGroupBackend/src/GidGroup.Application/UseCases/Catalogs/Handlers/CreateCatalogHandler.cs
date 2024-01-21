using GidGroup.Application.Abstractions;
using GidGroup.Application.UseCases.Catalogs.Commands;
using GidGroup.Domain.Entities;
using MediatR;

namespace GidGroup.Application.UseCases.Catalogs.Handlers
{
    public class CreateCatalogHandler : AsyncRequestHandler<CreateCatalogCommand>
    {
        private readonly IGidGroupApplicationDbContext _context;
        public CreateCatalogHandler(IGidGroupApplicationDbContext context)
        {
            _context = context;
        }

        protected override async Task Handle(CreateCatalogCommand request, CancellationToken cancellationToken)
        {
            GetCatalog catalog = new GetCatalog()
            {
                Email = request.Email,
            };

            await _context.GetCatalogs.AddAsync(catalog);
            await _context.SaveChangesAsync();
        }
    }
}
