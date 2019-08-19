using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarServiceFronted.Migrations
{
    public partial class allEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    models = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.ID);
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
                name: "Vehicles",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CarLicensePlate = table.Column<string>(nullable: true),
                    ManufacturingDate = table.Column<DateTime>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.ID);
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
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("31fb55d6-7b1b-4006-97a1-3fd605289908"), "Renault", "Captur,Clio,Clio Grandtour,Espace,Express,Fluence,Grand Espace,Grand Modus,Grand Scenic,Kadjar,Kangoo,Kangoo Express,Koleos,Laguna,Laguna Grandtour,Latitude,Mascott,Mégane,Mégane CC,Mégane Combi,Mégane Grandtour,Mégane Coupé,Mégane Scénic,Scénic,Talisman,Talisman Grandtour,Thalia,Twingo,Wind,Zoé" });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("41e251ca-732f-491f-805d-958d3897c5a4"), "Pending   ", 10 });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("43b70a54-c8a6-4a2c-bc61-e3549000dc2e"), "InProgress", 20 });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("dd638e75-2148-4bde-8092-0116e158faee"), "Delayed   ", 30 });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("d012c4a6-a04e-4938-9efc-ad14a70fc5a0"), "Ended     ", 40 });

            migrationBuilder.CreateIndex(
                name: "IX_Services_VehicleID",
                table: "Services",
                column: "VehicleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "ServiceStatus");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
