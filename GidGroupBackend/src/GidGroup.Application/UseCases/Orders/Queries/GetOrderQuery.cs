using GidGroup.Domain.Entities;
using MediatR;

namespace GidGroup.Application.UseCases.Orders.Queries
{
    public class GetOrderQuery : IRequest<IList<Order>>
    {
    }
}
