using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace het_12._2.Migrations
{
    /// <inheritdoc />
    public partial class masodik_jo_jo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kisallats_Kategorias_KategoriaID",
                table: "Kisallats");

            migrationBuilder.DropIndex(
                name: "IX_Kisallats_KategoriaID",
                table: "Kisallats");

            migrationBuilder.DropColumn(
                name: "KategoriaID",
                table: "Kisallats");

            migrationBuilder.CreateIndex(
                name: "IX_Kisallats_CategoryID",
                table: "Kisallats",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kisallats_Kategorias_CategoryID",
                table: "Kisallats",
                column: "CategoryID",
                principalTable: "Kategorias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kisallats_Kategorias_CategoryID",
                table: "Kisallats");

            migrationBuilder.DropIndex(
                name: "IX_Kisallats_CategoryID",
                table: "Kisallats");

            migrationBuilder.AddColumn<int>(
                name: "KategoriaID",
                table: "Kisallats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Kisallats_KategoriaID",
                table: "Kisallats",
                column: "KategoriaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kisallats_Kategorias_KategoriaID",
                table: "Kisallats",
                column: "KategoriaID",
                principalTable: "Kategorias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
