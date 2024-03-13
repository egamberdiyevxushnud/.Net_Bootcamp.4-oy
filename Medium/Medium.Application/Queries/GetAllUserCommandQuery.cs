using MediatR;
using Medium.Domain.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.Queries
{
    public class GetAllUserCommandQuery : IRequest<List<User>>
    {
    }
}
