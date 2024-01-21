using MediatR;

namespace GidGroup.Application.UseCases.Catalogs.Commands
{
    public class CreateCatalogCommand : IRequest
    {
        public string Email { get; set; } = default!;
    }
}
