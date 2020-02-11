using System.Threading;
using System.Threading.Tasks;
using CQRS02.Entity;
using MediatR;

namespace CQRS02.Commands
{
    public class CreateCommand : IRequest<int>
    {
        public string Description { get; set; }
        public class CreateCommandHandler : IRequestHandler<CreateCommand, int>
        {
            private readonly ApplicationDbContext _context;
            public CreateCommandHandler(ApplicationDbContext context)
            {
                _context = context;
            }
            public Task<int> Handle(CreateCommand request, CancellationToken cancellationToken)
            {

                var entity = new ToDoItem();

                entity.Description = request.Description;

                _context.ToDoItems.Add(entity);
                _context.SaveChanges();
                return Task.FromResult(entity.Id);
            }
        }

    }
}