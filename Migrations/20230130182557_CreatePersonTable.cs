using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SearchNavigator.Migrations
{
    /// <inheritdoc />
    public partial class CreatePersonTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Phone = table.Column<string>(maxLength: 32),
                    Email = table.Column<string>(maxLength: 64, nullable: true),
                    PassportNumber = table.Column<string>(maxLength: 32, nullable: false),
                    IsDelete = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_Phone",
                table: "Person",
                column: "Phone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Person_Phone",
                table: "Person");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
