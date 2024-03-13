using MediatR;
using Medium.Application.Commads;
using Medium.Application.Queries;
using Medium.Domain.Entity.Model;
using Microsoft.AspNetCore.Mvc;

namespace MediumApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommand command)
        {
            await _mediator.Send(command);

            return Ok("Malumot yaratildi");
        }
        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAll()
        {
            var result = await _mediator.Send(new GetAllUserCommandQuery());

            return result;
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetById(Guid id)
        {
            var result = await _mediator.Send(new GetByIdCommandQuery()
            {
                id = id
            }) ;

            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var result = await _mediator.Send(new DeleteUserCommand()
            {
                Id = id
            }) ;

            return Ok("Ochirildi");
        }

        [HttpPut]
        public async Task<ActionResult<User>> UpdateUser(UpdateUserCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
