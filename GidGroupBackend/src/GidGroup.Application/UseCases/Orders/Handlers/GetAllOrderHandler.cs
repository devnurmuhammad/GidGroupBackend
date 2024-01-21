using GidGroup.Application.Abstractions;
using GidGroup.Application.UseCases.Orders.Queries;
using GidGroup.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GidGroup.Application.UseCases.Orders.Handlers
{
    public class GetAllOrderHandler : IRequestHandler<GetOrderQuery, IList<Order>>
    {
        private readonly IGidGroupApplicationDbContext _context;
        public GetAllOrderHandler(IGidGroupApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Order>> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            IList<Order> orders = await _context.Orders.ToListAsync(cancellationToken);
            return orders;
        }
    }
}
