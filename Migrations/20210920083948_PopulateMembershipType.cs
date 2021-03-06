using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class PopulateMembershipType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO MembershipType(Id, SignUpFee, DurationInMonths, DiscountRate) Values(1, 0, 0, 0)");

            migrationBuilder.Sql("INSERT INTO MembershipType(Id, SignUpFee, DurationInMonths, DiscountRate) Values(2, 30, 1, 10)");

            migrationBuilder.Sql("INSERT INTO MembershipType(Id, SignUpFee, DurationInMonths, DiscountRate) Values(3, 90, 3, 15)");

            migrationBuilder.Sql("INSERT INTO MembershipType(Id, SignUpFee, DurationInMonths, DiscountRate) Values(4, 300, 3, 15)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
