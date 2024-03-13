using MediatR;
using Medium.Domain.Entity.DTOs;
using Medium.Domain.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.Commads
{
    public class UpdateUserCommand : UserDTO, IRequest<User>
    {
        public Guid id { get; set; }
    }
}
