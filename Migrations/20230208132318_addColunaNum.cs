using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace editaisAPI.Migrations
{
    /// <inheritdoc />
    public partial class addColunaNum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TopicoFilhoNome",
                table: "TopicoFilhos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(180)",
                oldMaxLength: 180)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TopicoFilhoNome",
                table: "TopicoFilhos",
                type: "varchar(180)",
                maxLength: 180,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
