using GidGroup.Domain.Entities;
using MediatR;

namespace GidGroup.Application.UseCases.Catalogs.Queries
{
    public class GetCatalogQuery : IRequest<IList<GetCatalog>>
    {
    }
}
