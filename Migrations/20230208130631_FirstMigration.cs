using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace editaisAPI.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Concursos",
                columns: table => new
                {
                    ConcursoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ConcursoData = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Banca = table.Column<string>(type: "varchar(180)", maxLength: 180, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Orgao = table.Column<string>(type: "varchar(180)", maxLength: 180, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concursos", x => x.ConcursoId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Provas",
                columns: table => new
                {
                    ProvaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProvaData = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Cargo = table.Column<string>(type: "varchar(180)", maxLength: 180, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcursoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provas", x => x.ProvaId);
                    table.ForeignKey(
                        name: "FK_Provas_Concursos_ConcursoId",
                        column: x => x.ConcursoId,
                        principalTable: "Concursos",
                        principalColumn: "ConcursoId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    DisciplinaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DisciplinaNome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProvaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.DisciplinaId);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Provas_ProvaId",
                        column: x => x.ProvaId,
                        principalTable: "Provas",
                        principalColumn: "ProvaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TopicoPais",
                columns: table => new
                {
                    TopicoPaiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TopicoPaiNome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisciplinaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicoPais", x => x.TopicoPaiId);
                    table.ForeignKey(
                        name: "FK_TopicoPais_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "DisciplinaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TopicoFilhos",
                columns: table => new
                {
                    TopicoFilhoId = table.Column<int>(type: "int", maxLength: 180, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TopicoFilhoNome = table.Column<string>(type: "varchar(180)", maxLength: 180, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TopicoPaiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicoFilhos", x => x.TopicoFilhoId);
                    table.ForeignKey(
                        name: "FK_TopicoFilhos_TopicoPais_TopicoPaiId",
                        column: x => x.TopicoPaiId,
                        principalTable: "TopicoPais",
                        principalColumn: "TopicoPaiId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TopicoNetos",
                columns: table => new
                {
                    TopicoNetoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TopicoNetoNome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TopicoFilhoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicoNetos", x => x.TopicoNetoId);
                    table.ForeignKey(
                        name: "FK_TopicoNetos_TopicoFilhos_TopicoFilhoId",
                        column: x => x.TopicoFilhoId,
                        principalTable: "TopicoFilhos",
                        principalColumn: "TopicoFilhoId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_ProvaId",
                table: "Disciplinas",
                column: "ProvaId");

            migrationBuilder.CreateIndex(
                name: "IX_Provas_ConcursoId",
                table: "Provas",
                column: "ConcursoId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicoFilhos_TopicoPaiId",
                table: "TopicoFilhos",
                column: "TopicoPaiId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicoNetos_TopicoFilhoId",
                table: "TopicoNetos",
                column: "TopicoFilhoId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicoPais_DisciplinaId",
                table: "TopicoPais",
                column: "DisciplinaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TopicoNetos");

            migrationBuilder.DropTable(
                name: "TopicoFilhos");

            migrationBuilder.DropTable(
                name: "TopicoPais");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Provas");

            migrationBuilder.DropTable(
                name: "Concursos");
        }
    }
}
