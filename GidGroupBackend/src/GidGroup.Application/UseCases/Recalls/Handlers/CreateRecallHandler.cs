using GidGroup.Application.Abstractions;
using GidGroup.Application.UseCases.Recalls.Commands;
using GidGroup.Domain.Entities;
using MediatR;

namespace GidGroup.Application.UseCases.Recalls.Handlers
{
    public class CreateRecallHandler : AsyncRequestHandler<CreateRecallCommand>
    {
        private readonly IGidGroupApplicationDbContext _context;

        public CreateRecallHandler(IGidGroupApplicationDbContext context)
        {
            _context = context;
        }

        protected override async Task Handle(CreateRecallCommand request, CancellationToken cancellationToken)
        {
            Recall recall = new Recall()
            {
                Name = request.Name,
                Phone = request.Phone,
            };
            await _context.Recalls.AddAsync(recall);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
