using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class PopulateMembershipTypeNamePropertyWithData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Update MembershipType SET Name = 'Pay as You Go' Where Id = 1");
            migrationBuilder.Sql("Update MembershipType SET Name = 'Monthly' Where Id = 2");
            migrationBuilder.Sql("Update MembershipType SET Name = 'Yearly' Where Id = 3");
            migrationBuilder.Sql("Update MembershipType SET Name = 'Hourly' Where Id = 4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
