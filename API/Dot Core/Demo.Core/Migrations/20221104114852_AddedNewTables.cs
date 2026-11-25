using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Core.Migrations
{
    public partial class AddedNewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalPartsValue",
                table: "PbClaimDrafts",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPartsValue",
                table: "PB_Claims",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPartsValue",
                table: "PB_ClaimRequests",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PbClaimPartSuppliers",
                columns: table => new
                {
                    ClaimPartSupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SupplierTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false,defaultValue: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PbClaimPartSuppliers", x => x.ClaimPartSupplierId);
                });

            migrationBuilder.CreateTable(
                name: "PbClaimSupplierParts",
                columns: table => new
                {
                    ClaimSupplierPartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimPartSupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PartName = table.Column<string>(type: "nvarchar(2000)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false,defaultValue: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PbClaimSupplierParts", x => x.ClaimSupplierPartId);
                });

            migrationBuilder.CreateTable(
                name: "PbSupplierParts",
                columns: table => new
                {
                    SupplierPartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PartId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PartName = table.Column<string>(type: "nvarchar(2000)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false,defaultValue: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PbSupplierParts", x => x.SupplierPartId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PbClaimPartSuppliers");

            migrationBuilder.DropTable(
                name: "PbClaimSupplierParts");

            migrationBuilder.DropTable(
                name: "PbSupplierParts");

            migrationBuilder.DropColumn(
                name: "TotalPartsValue",
                table: "PbClaimDrafts");

            migrationBuilder.DropColumn(
                name: "TotalPartsValue",
                table: "PB_Claims");

            migrationBuilder.DropColumn(
                name: "TotalPartsValue",
                table: "PB_ClaimRequests");
        }
    }
}
