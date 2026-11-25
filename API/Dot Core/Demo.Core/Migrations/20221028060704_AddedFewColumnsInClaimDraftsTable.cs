using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Core.Migrations
{
    public partial class AddedFewColumnsInClaimDraftsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EstimatedBookInDate",
                table: "PbClaimDrafts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstimatedDaysToCompleted",
                table: "PbClaimDrafts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "InsurerIdsecondary",
                table: "PbClaimDrafts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsurerLiaisonPerson",
                table: "PbClaimDrafts",
                type: "nvarchar(1000)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstimatedBookInDate",
                table: "PbClaimDrafts");

            migrationBuilder.DropColumn(
                name: "EstimatedDaysToCompleted",
                table: "PbClaimDrafts");

            migrationBuilder.DropColumn(
                name: "InsurerIdsecondary",
                table: "PbClaimDrafts");

            migrationBuilder.DropColumn(
                name: "InsurerLiaisonPerson",
                table: "PbClaimDrafts");
        }
    }
}
