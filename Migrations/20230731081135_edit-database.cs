using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalApplication.Migrations
{
    /// <inheritdoc />
    public partial class editdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Rentals_RentalId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_RentalId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasDriver",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "RentalId",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "ReplacementDriverId",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_ReplacementDriverId",
                table: "Drivers",
                column: "ReplacementDriverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Drivers_ReplacementDriverId",
                table: "Drivers",
                column: "ReplacementDriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Drivers_ReplacementDriverId",
                table: "Drivers");

            migrationBuilder.DropIndex(
                name: "IX_Drivers_ReplacementDriverId",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "ReplacementDriverId",
                table: "Drivers");

            migrationBuilder.AddColumn<bool>(
                name: "HasDriver",
                table: "Rentals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "RentalId",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_RentalId",
                table: "Cars",
                column: "RentalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Rentals_RentalId",
                table: "Cars",
                column: "RentalId",
                principalTable: "Rentals",
                principalColumn: "Id");
        }
    }
}
