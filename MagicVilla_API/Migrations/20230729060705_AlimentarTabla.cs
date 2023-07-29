using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la villa....", new DateTime(2023, 7, 29, 1, 7, 5, 172, DateTimeKind.Local).AddTicks(2020), new DateTime(2023, 7, 29, 1, 7, 5, 172, DateTimeKind.Local).AddTicks(2010), "", 50.0, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la villa....", new DateTime(2023, 7, 29, 1, 7, 5, 172, DateTimeKind.Local).AddTicks(2022), new DateTime(2023, 7, 29, 1, 7, 5, 172, DateTimeKind.Local).AddTicks(2022), "", 40.0, "Premium Vista a la Piscina", 4, 150.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
