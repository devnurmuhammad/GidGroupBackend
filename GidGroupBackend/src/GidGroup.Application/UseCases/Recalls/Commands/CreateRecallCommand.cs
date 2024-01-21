using MediatR;

namespace GidGroup.Application.UseCases.Recalls.Commands
{
    public class CreateRecallCommand : IRequest
    {
        public string Name { get; set; } = default!;
        public string Phone { get; set; } = default!;
    }
}
