using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SearchNavigator.Migrations
{
    /// <inheritdoc />
    public partial class CreateCarTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    BrandId = table.Column<int>(type: "integer", nullable: false),
                    Model = table.Column<string>(maxLength: 48, nullable: false),
                    IssueYear = table.Column<int>(type: "integer"),
                    EnginePower = table.Column<int>(type: "integer"),
                    Transmission = table.Column<string>(maxLength: 24, nullable: true),
                    Color = table.Column<string>(maxLength: 48, nullable: false),
                    Number = table.Column<string>(maxLength: 12, nullable: false),
                    LeaseRate = table.Column<decimal>(type: "decimal", nullable: false),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    PreviewImage = table.Column<string>(type: "text"),
                    IsDelete = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Car_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Car_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id");
                });


            migrationBuilder.CreateIndex(
                name: "IX_Car_BrandId",
                table: "Car",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_CityId",
                table: "Car",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_Model",
                table: "Car",
                column: "Model");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Car_Model",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_CityId",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_BrandId",
                table: "Car");

            migrationBuilder.DropTable(
                name: "Car");
        }
    }
}
