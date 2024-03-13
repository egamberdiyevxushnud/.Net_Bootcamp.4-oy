using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Medium.Infrustructure.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration00 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    USerName = table.Column<string>(type: "text", nullable: true),
                    Bio = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    PhotoPath = table.Column<string>(type: "text", nullable: true),
                    FollowersCount = table.Column<int>(type: "integer", nullable: true),
                    Login = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    JoinData = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ModifiedData = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    DeleteData = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    IsSeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
