using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Core.Migrations
{
    public partial class AddedYearColumnsInPbClaimRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "PB_Claims",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "PB_ClaimRequests",
                type: "nvarchar(10)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Year",
                table: "PB_Claims");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "PB_ClaimRequests");
        }
    }
}
