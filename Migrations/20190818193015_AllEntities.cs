using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarServiceFronted.Migrations
{
    public partial class AllEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ServiceStatus",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdStatus = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceStatus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    ModelsID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Brands_Models_ModelsID",
                        column: x => x.ModelsID,
                        principalTable: "Models",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CarLicensePlate = table.Column<string>(nullable: true),
                    ManufacturingDate = table.Column<DateTime>(nullable: false),
                    BrandID = table.Column<Guid>(nullable: true),
                    ModelID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Vehicles_Brands_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_Models_ModelID",
                        column: x => x.ModelID,
                        principalTable: "Models",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    VehicleID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Services_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("ec96d8f2-4973-4e3e-858b-47746e7c6465"), "Pending   ", 10 });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("27755942-a6a3-45aa-915d-bb26cf5e1a4e"), "InProgress", 20 });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("2647a3c7-3e6e-40ea-b08f-3748bf288ac9"), "Delayed   ", 30 });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("2982e717-fe5f-4009-9c27-e61445dcbde5"), "Ended     ", 40 });

            migrationBuilder.CreateIndex(
                name: "IX_Brands_ModelsID",
                table: "Brands",
                column: "ModelsID");

            migrationBuilder.CreateIndex(
                name: "IX_Services_VehicleID",
                table: "Services",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BrandID",
                table: "Vehicles",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ModelID",
                table: "Vehicles",
                column: "ModelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "ServiceStatus");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Models");
        }
    }
}
