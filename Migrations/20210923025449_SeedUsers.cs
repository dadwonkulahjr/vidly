using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class SeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'1cacf584-31cc-41af-b346-7c73216015e5', N'admin@vidly.com', N'ADMIN@VIDLY.COM', N'admin@vidly.com', N'ADMIN@VIDLY.COM', 0, N'AQAAAAEAACcQAAAAEPBj1bR01GeLn66SMoLvYMOqjPKHt/jWTEGrHJwfQUqIGCNA9cSOgDioLQ+cJXBTFg==', N'IFJKCILRTIGNS64ZG42RIJR7VLLFTOVE', N'15a2074b-6c13-4e01-942d-a4e8618fd2ff', NULL, 0, 0, NULL, 1, 0)
                INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'd64870f0-5647-4d7d-8db9-927d3b5a56d5', N'guest@vidly.com', N'GUEST@VIDLY.COM', N'guest@vidly.com', N'GUEST@VIDLY.COM', 0, N'AQAAAAEAACcQAAAAEFHOtM/bale570hNG5V6E47MYCaew0RDVi2iMFwSN5wRQUShPDcSH0nMfGC4x/O4ug==', N'LGJF7A6IBN45R56D7RWN4CWOKJAWLAHH', N'7a39e2ed-56eb-4fff-9e27-e72bbe191060', NULL, 0, 0, NULL, 1, 0)

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'df1ca330-dc56-4708-bc89-d6e876f6d929', N'CanManageMovies', N'CanManageMovies', N'7c541312-f01b-4234-bf60-66cf3ff212cc')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1cacf584-31cc-41af-b346-7c73216015e5', N'df1ca330-dc56-4708-bc89-d6e876f6d929')
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
