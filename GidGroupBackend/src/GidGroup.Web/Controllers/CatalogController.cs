using GidGroup.Application.UseCases.Catalogs.Commands;
using GidGroup.Application.UseCases.Catalogs.Queries;
using GidGroup.Domain.Entities;
using GidGroup.Web.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GidGroup.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CatalogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateCatalog(CatalogDTO catalogDTO)
        {
            var catalog = new CreateCatalogCommand()
            {
                Email = catalogDTO.Email,
            };
            await _mediator.Send(catalog);
            return Ok("Created");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllCatalog()
        {
            IList<GetCatalog> catalogs = await _mediator.Send(new GetCatalogQuery());
            return Ok(catalogs);
        }
    }
}
