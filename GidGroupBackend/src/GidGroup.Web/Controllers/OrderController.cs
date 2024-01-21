using GidGroup.Application.UseCases.Orders.Commands;
using GidGroup.Application.UseCases.Orders.Queries;
using GidGroup.Domain.Entities;
using GidGroup.Web.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GidGroup.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateOrder(OrderDTO orderDTO)
        {
            var order = new CreateOrderCommand()
            {
                Email = orderDTO.Email,
                Phone = orderDTO.Phone,
                Style = orderDTO.Style,
                Size = orderDTO.Size,
                WhenNeed = orderDTO.WhenNeed,
                Date = DateTime.UtcNow,
                Status = Domain.Enums.StatusEnums.Status.Recieved,
            };
            await _mediator.Send(order);
            return Ok("Created");
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllOrder()
        {
            IList<Order> orders = await _mediator.Send(new GetOrderQuery());
            return Ok(orders);
        }
    }
}
