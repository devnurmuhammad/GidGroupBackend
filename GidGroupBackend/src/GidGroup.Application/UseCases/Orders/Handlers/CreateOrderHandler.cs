using GidGroup.Application.Abstractions;
using GidGroup.Application.UseCases.Orders.Commands;
using GidGroup.Domain.Entities;
using MediatR;

namespace GidGroup.Application.UseCases.Orders.Handlers
{
    public class CreateOrderHandler : AsyncRequestHandler<CreateOrderCommand>
    {
        private readonly IGidGroupApplicationDbContext _dbContext;
        public CreateOrderHandler(IGidGroupApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected override async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            Order order = new Order()
            {
                Email = request.Email,
                Phone = request.Phone,
                Style = request.Style,
                Size = request.Size,
                WhenNeed = request.WhenNeed,
                Date = DateTime.UtcNow,
                Status = Domain.Enums.StatusEnums.Status.Recieved,
            };
            await _dbContext.Orders.AddAsync(order);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
