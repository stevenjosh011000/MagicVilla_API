using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaID",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 7, 31, 16, 27, 49, 14, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 7, 31, 16, 27, 49, 14, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 3,
                column: "createdDate",
                value: new DateTime(2023, 7, 31, 16, 27, 49, 14, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 4,
                column: "createdDate",
                value: new DateTime(2023, 7, 31, 16, 27, 49, 14, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 5,
                column: "createdDate",
                value: new DateTime(2023, 7, 31, 16, 27, 49, 14, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers",
                column: "VillaID");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers",
                column: "VillaID",
                principalTable: "Villas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "VillaID",
                table: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 7, 28, 9, 48, 26, 920, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 7, 28, 9, 48, 26, 920, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 3,
                column: "createdDate",
                value: new DateTime(2023, 7, 28, 9, 48, 26, 920, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 4,
                column: "createdDate",
                value: new DateTime(2023, 7, 28, 9, 48, 26, 920, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 5,
                column: "createdDate",
                value: new DateTime(2023, 7, 28, 9, 48, 26, 920, DateTimeKind.Local).AddTicks(1430));
        }
    }
}
