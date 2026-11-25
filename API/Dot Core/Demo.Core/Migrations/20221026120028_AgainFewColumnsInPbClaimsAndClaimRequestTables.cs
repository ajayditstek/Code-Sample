using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Core.Migrations
{
    public partial class AgainFewColumnsInPbClaimsAndClaimRequestTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Labour",
                table: "PB_ClaimRequests",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Paint",
                table: "PB_ClaimRequests",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VINNumber",
                table: "PB_ClaimRequests",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Labour",
                table: "PB_ClaimRequests");

            migrationBuilder.DropColumn(
                name: "Paint",
                table: "PB_ClaimRequests");

            migrationBuilder.DropColumn(
                name: "VINNumber",
                table: "PB_ClaimRequests");
        }
    }
}
