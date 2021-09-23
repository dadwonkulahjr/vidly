using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class PopulateGenreType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genre Values('Comedy', '2008-04-02', '2021-09-20', 4)");
            migrationBuilder.Sql("INSERT INTO Genre Values('Action', '1996-03-12', '2021-09-20', 5)");
            migrationBuilder.Sql("INSERT INTO Genre Values('Family', '1988-05-28', '2021-09-20', 1)");
            migrationBuilder.Sql("INSERT INTO Genre Values('Romance', '2010-10-19', '2021-09-20', 3)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
