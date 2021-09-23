using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class PopulateGenderType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Gender Values('Male', 'Gender of a male.')");
            migrationBuilder.Sql("INSERT INTO Gender Values('Female', 'Gender of a female.')");
            migrationBuilder.Sql("INSERT INTO Gender Values('Other', 'Gender of a other.')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
