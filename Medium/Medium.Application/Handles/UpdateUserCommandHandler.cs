using MediatR;
using Medium.Application.Abstractions;
using Medium.Application.Commads;
using Medium.Domain.Entity.DTOs;
using Medium.Domain.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.Handles
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, User>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public UpdateUserCommandHandler(IApplicationDbContext applicationDbContext)
        {
            this._applicationDbContext = applicationDbContext;
        }

        public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _applicationDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.id && x.Isdeleted != true);

            if (user != null)
            {
                user.ModifiedData = DateTime.UtcNow;
                user.Name = request.Name;
                user.Email = request.Email;
                user.USerName = request.USerName;
                user.Bio = request.Bio;
                user.PhotoPath = request.PhotoPath;
                user.FollowersCount = request.FollowersCount;
                user.Login = request.Login;
                user.PasswordHash = request.PasswordHash;

                await _applicationDbContext.SavaChagesAsync(cancellationToken);
                return user;
            }
            return new User();
        }
    }
}
