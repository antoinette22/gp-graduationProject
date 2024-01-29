using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace graduationProject.Migrations
{
    /// <inheritdoc />
    public partial class SeedDefaultAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Create DefaultAdmin user
            var hasher = new PasswordHasher<IdentityUser>();
            var hashedPassword = hasher.HashPassword(null, "Admin123");

            migrationBuilder.Sql($@"INSERT INTO AspNetUsers (Id, UserName, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp,AccessFailedCount,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnabled)
                                VALUES ('{Guid.NewGuid().ToString()}', 'DefaultAdmin', 'DEFAULTADMIN', 'defaultemail@gmail.com', 'DEFAULTEMAIL@GMAIL.COM', 1, '{hashedPassword}', 'RandomSecurityStamp', '{Guid.NewGuid().ToString()}',0,0,0,1)");

            // Assign DefaultAdmin to Admin role
            migrationBuilder.Sql("INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ((SELECT Id FROM AspNetUsers WHERE UserName = 'DefaultAdmin'), (SELECT Id FROM AspNetRoles WHERE [Name] = 'Admin'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove records added in the Up method
            migrationBuilder.Sql("DELETE FROM AspNetUserRoles WHERE UserId IN (SELECT Id FROM AspNetUsers WHERE UserName = 'DefaultAdmin')");
            migrationBuilder.Sql("DELETE FROM AspNetUsers WHERE UserName = 'DefaultAdmin'");
        }
    }
}
