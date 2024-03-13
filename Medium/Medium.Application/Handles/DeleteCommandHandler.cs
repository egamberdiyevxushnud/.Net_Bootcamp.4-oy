using MediatR;
using MediatR.Pipeline;
using Medium.Application.Abstractions;
using Medium.Application.Commads;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.Handles
{
    public class DeleteCommandHandler : AsyncRequestHandler<DeleteUserCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        protected override async Task Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var result = await _context.Users.FirstOrDefaultAsync(x => x.Id == request.Id);
            _context.Users.Remove(result);
            await _context.SavaChagesAsync();
        }
    }
}
