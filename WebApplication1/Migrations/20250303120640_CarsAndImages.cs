using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class CarsAndImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarAndImges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyCarId = table.Column<int>(type: "int", nullable: false),
                    MyCarImgeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarAndImges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarAndImges_CarImages_MyCarImgeId",
                        column: x => x.MyCarImgeId,
                        principalTable: "CarImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarAndImges_Cars_MyCarId",
                        column: x => x.MyCarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarAndImges_MyCarId",
                table: "CarAndImges",
                column: "MyCarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarAndImges_MyCarImgeId",
                table: "CarAndImges",
                column: "MyCarImgeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarAndImges");
        }
    }
}
