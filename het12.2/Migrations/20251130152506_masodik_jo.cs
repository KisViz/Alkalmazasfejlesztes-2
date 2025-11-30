using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace het12._2.Migrations
{
    /// <inheritdoc />
    public partial class masodik_jo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Weigh",
                table: "Puppies",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weigh",
                table: "Puppies");
        }
    }
}
