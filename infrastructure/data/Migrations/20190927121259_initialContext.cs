using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parqueadero.Migrations
{
    public partial class initialContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PicoPlaca",
                columns: table => new
                {
                    PicoPlacaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescripcionPicoPlaca = table.Column<string>(nullable: true),
                    DiaPicoPlaca = table.Column<string>(nullable: true),
                    ValorPlaca = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PicoPlaca", x => x.PicoPlacaId);
                });

            migrationBuilder.CreateTable(
                name: "Tarifa",
                columns: table => new
                {
                    TarifaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescripcionTarifa = table.Column<string>(nullable: true),
                    ValorTarifa = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarifa", x => x.TarifaId);
                });

            migrationBuilder.CreateTable(
                name: "TipoVehiculo",
                columns: table => new
                {
                    TipoVehiculoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescripcionTipoVehiculo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVehiculo", x => x.TipoVehiculoId);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    VehiculoId = table.Column<int>(nullable: false),
                    VehiculoPlaca = table.Column<string>(nullable: false),
                    DescripcionVehiculo = table.Column<string>(nullable: true),
                    Cilindraje = table.Column<int>(nullable: false),
                    TipoVehiculoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => new { x.VehiculoId, x.VehiculoPlaca });
                    table.ForeignKey(
                        name: "FK_Vehiculo_TipoVehiculo_TipoVehiculoId",
                        column: x => x.TipoVehiculoId,
                        principalTable: "TipoVehiculo",
                        principalColumn: "TipoVehiculoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tiquete",
                columns: table => new
                {
                    TiqueteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    ValorTotal = table.Column<decimal>(nullable: false),
                    TarifaId = table.Column<int>(nullable: false),
                    VehiculoId = table.Column<int>(nullable: false),
                    VehiculoId1 = table.Column<int>(nullable: true),
                    VehiculoPlaca = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiquete", x => x.TiqueteId);
                    table.ForeignKey(
                        name: "FK_Tiquete_Tarifa_TarifaId",
                        column: x => x.TarifaId,
                        principalTable: "Tarifa",
                        principalColumn: "TarifaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tiquete_Vehiculo_VehiculoId1_VehiculoPlaca",
                        columns: x => new { x.VehiculoId1, x.VehiculoPlaca },
                        principalTable: "Vehiculo",
                        principalColumns: new[] { "VehiculoId", "VehiculoPlaca" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tiquete_TarifaId",
                table: "Tiquete",
                column: "TarifaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tiquete_VehiculoId1_VehiculoPlaca",
                table: "Tiquete",
                columns: new[] { "VehiculoId1", "VehiculoPlaca" });

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_TipoVehiculoId",
                table: "Vehiculo",
                column: "TipoVehiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PicoPlaca");

            migrationBuilder.DropTable(
                name: "Tiquete");

            migrationBuilder.DropTable(
                name: "Tarifa");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DropTable(
                name: "TipoVehiculo");
        }
    }
}
