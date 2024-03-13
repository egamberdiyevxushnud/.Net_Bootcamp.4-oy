using MediatR;
using Medium.Application.Abstractions;
using Medium.Application.Commads;
using Medium.Domain.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.Handles
{
    public class GetByIdUserCommandQueryHandler : IRequestHandler<GetByIdCommandQuery, User>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public GetByIdUserCommandQueryHandler(IApplicationDbContext applicationDbContext)
        {
            this._applicationDbContext = applicationDbContext;
        }

        public async Task<User> Handle(GetByIdCommandQuery request, CancellationToken cancellationToken)
        {
            var result =await _applicationDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.id && x.Isdeleted != true);
            return result;
        }
    }
}
