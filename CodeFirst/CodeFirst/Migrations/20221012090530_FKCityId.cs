using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class FKCityId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_tblemployee_city_id",
                table: "tblemployee",
                column: "city_id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblemployee_tblcities_city_id",
                table: "tblemployee",
                column: "city_id",
                principalTable: "tblcities",
                principalColumn: "city_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblemployee_tblcities_city_id",
                table: "tblemployee");

            migrationBuilder.DropIndex(
                name: "IX_tblemployee_city_id",
                table: "tblemployee");
        }
    }
}
