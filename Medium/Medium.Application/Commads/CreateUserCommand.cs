using MediatR;

namespace Medium.Application.Commads
{
    public class CreateUserCommand : IRequest
    {
        public string Name { get; set; }
        public string USerName { get; set; }
        public string? Bio { get; set; }
        public string? Email { get; set; }
        public string? PhotoPath { get; set; }
        public int? FollowersCount { get; set; }

        public string Login { get; set; }
        public string PasswordHash { get; set; }

    }
}
