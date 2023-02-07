using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SearchNavigator.Migrations
{
    /// <inheritdoc />
    public partial class CreateLeaseTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lease",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    CarId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lease", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lease_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Lease_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lease_PersonId",
                table: "Lease",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Lease_CarId",
                table: "Lease",
                column: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Lease_CarId",
                table: "Lease");

            migrationBuilder.DropIndex(
                name: "IX_Lease_PersonId",
                table: "Lease");

            migrationBuilder.DropTable(
                name: "Lease");  
        }
    }
}
