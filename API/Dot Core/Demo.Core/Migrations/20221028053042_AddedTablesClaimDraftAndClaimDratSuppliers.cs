using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Core.Migrations
{
    public partial class AddedTablesClaimDraftAndClaimDratSuppliers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PbClaimDrafts",
                columns: table => new
                {
                    ClaimDraftId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InsurerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InsurerClaimNumber = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    VehicleRegistrationNumber = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    VehicleMake = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    VehicleModel = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Year = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    InsuredName = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    VINNumber = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Labour = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Paint = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InsuredPhoneNumber = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Ronumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ClaimAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ClaimExcess = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ClaimPartsValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InvoiceType = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubmittedBy = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    SubmittedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PbClaimDrafts", x => x.ClaimDraftId);
                });

            migrationBuilder.CreateTable(
                name: "PbClaimDraftSuppliers",
                columns: table => new
                {
                    ClaimDraftSupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimDraftId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PbClaimDraftSuppliers", x => x.ClaimDraftSupplierId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PbClaimDrafts");

            migrationBuilder.DropTable(
                name: "PbClaimDraftSuppliers");
        }
    }
}
