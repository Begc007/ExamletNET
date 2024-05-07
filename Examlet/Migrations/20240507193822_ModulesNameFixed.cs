using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examlet.Migrations
{
    /// <inheritdoc />
    public partial class ModulesNameFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Models_ModuleId",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.RenameTable(
                name: "Models",
                newName: "Modules");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modules",
                table: "Modules",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Modules_ModuleId",
                table: "Cards",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Modules_ModuleId",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modules",
                table: "Modules");

            migrationBuilder.RenameTable(
                name: "Modules",
                newName: "Models");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Models_ModuleId",
                table: "Cards",
                column: "ModuleId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
