using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class CarsAndImages2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarAndImges_CarImages_MyCarImgeId",
                table: "CarAndImges");

            migrationBuilder.DropIndex(
                name: "IX_CarAndImges_MyCarImgeId",
                table: "CarAndImges");

            migrationBuilder.DropColumn(
                name: "MyCarImgeId",
                table: "CarAndImges");

            migrationBuilder.AddColumn<int>(
                name: "CarAndImgId",
                table: "CarImages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarImages_CarAndImgId",
                table: "CarImages",
                column: "CarAndImgId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarImages_CarAndImges_CarAndImgId",
                table: "CarImages",
                column: "CarAndImgId",
                principalTable: "CarAndImges",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarImages_CarAndImges_CarAndImgId",
                table: "CarImages");

            migrationBuilder.DropIndex(
                name: "IX_CarImages_CarAndImgId",
                table: "CarImages");

            migrationBuilder.DropColumn(
                name: "CarAndImgId",
                table: "CarImages");

            migrationBuilder.AddColumn<int>(
                name: "MyCarImgeId",
                table: "CarAndImges",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CarAndImges_MyCarImgeId",
                table: "CarAndImges",
                column: "MyCarImgeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarAndImges_CarImages_MyCarImgeId",
                table: "CarAndImges",
                column: "MyCarImgeId",
                principalTable: "CarImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
