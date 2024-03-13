namespace Medium.Domain.Entity.Model
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public string? USerName { get; set; }
        public string? Bio { get; set; }
        public string? Email { get; set; }
        public string? PhotoPath { get; set; }
        public int? FollowersCount { get; set; }

        public string Login { get; set; }
        public string PasswordHash { get; set; }

        public DateTimeOffset JoinData { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset ModifiedData { get; set; }
        public DateTimeOffset DeleteData { get; set; }
        public bool Isdeleted { get; set; } = false;
    }
}
