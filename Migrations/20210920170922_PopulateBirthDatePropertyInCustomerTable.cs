using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Vidly.Migrations
{
    public partial class PopulateBirthDatePropertyInCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Update Customer SET BirthDate = '1980-08-05' Where Id = 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
