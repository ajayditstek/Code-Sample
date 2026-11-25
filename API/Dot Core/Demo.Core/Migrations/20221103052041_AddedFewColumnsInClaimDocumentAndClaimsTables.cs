using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Core.Migrations
{
    public partial class AddedFewColumnsInClaimDocumentAndClaimsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "NetClaimAmount",
                table: "PbClaimDrafts",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "NetClaimAmount",
                table: "PB_Claims",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "NetClaimAmount",
                table: "PB_ClaimRequests",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentUrl",
                table: "PB_ClaimDocuments",
                type: "nvarchar(2000)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NetClaimAmount",
                table: "PbClaimDrafts");

            migrationBuilder.DropColumn(
                name: "NetClaimAmount",
                table: "PB_Claims");

            migrationBuilder.DropColumn(
                name: "NetClaimAmount",
                table: "PB_ClaimRequests");

            migrationBuilder.DropColumn(
                name: "DocumentUrl",
                table: "PB_ClaimDocuments");
        }
    }
}
