using MediatR;
using Medium.Application.Abstractions;
using Medium.Application.Queries;
using Medium.Domain.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.Handles
{
    public class GetAllCommandQueryHandler : IRequestHandler<GetAllUserCommandQuery, List<User>>
    {
        private readonly IApplicationDbContext applicationDbContext;

        public GetAllCommandQueryHandler(IApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        async Task<List<User>> IRequestHandler<GetAllUserCommandQuery, List<User>>.Handle(GetAllUserCommandQuery request, CancellationToken cancellationToken)
        {
            var users = await applicationDbContext.Users.ToListAsync();

            return users;
        }
    }
}
