using GidGroup.Domain.Enums;
using MediatR;

namespace GidGroup.Application.UseCases.Orders.Commands
{
    public class CreateOrderCommand : IRequest
    {
        public string Size { get; set; } = default!;
        public string Style { get; set; } = default!;
        public string WhenNeed { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string? Email { get; set; }
        public DateTime Date { get; set; }
        public StatusEnums.Status Status { get; set; }
    }
}
