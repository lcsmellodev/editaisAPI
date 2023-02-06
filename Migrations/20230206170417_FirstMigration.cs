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
                    Banca = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Orgao = table.Column<string>(type: "longtext", nullable: true)
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
                    Cargo = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
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
                    DisciplinaNome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProvaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => new { x.DisciplinaNome, x.ProvaId });
                    table.ForeignKey(
                        name: "FK_Disciplinas_Provas_ProvaId",
                        column: x => x.ProvaId,
                        principalTable: "Provas",
                        principalColumn: "ProvaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Topicos",
                columns: table => new
                {
                    TopicoPaiNome = table.Column<string>(type: "varchar(180)", maxLength: 180, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisciplinaNome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProvaId = table.Column<int>(type: "int", nullable: false),
                    DiscipddddddlinaNome = table.Column<string>(type: "varchar(80)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topicos", x => new { x.TopicoPaiNome, x.DisciplinaNome, x.ProvaId });
                    table.ForeignKey(
                        name: "FK_Topicos_Disciplinas_DiscipddddddlinaNome_ProvaId",
                        columns: x => new { x.DiscipddddddlinaNome, x.ProvaId },
                        principalTable: "Disciplinas",
                        principalColumns: new[] { "DisciplinaNome", "ProvaId" });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TopicoFilhos",
                columns: table => new
                {
                    TopicoFilhoNome = table.Column<string>(type: "varchar(180)", maxLength: 180, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TopicoPaiNome = table.Column<string>(type: "varchar(180)", maxLength: 180, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisciplinaNome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProvaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicoFilhos", x => new { x.TopicoFilhoNome, x.TopicoPaiNome, x.DisciplinaNome, x.ProvaId });
                    table.ForeignKey(
                        name: "FK_TopicoFilhos_Topicos_TopicoPaiNome_DisciplinaNome_ProvaId",
                        columns: x => new { x.TopicoPaiNome, x.DisciplinaNome, x.ProvaId },
                        principalTable: "Topicos",
                        principalColumns: new[] { "TopicoPaiNome", "DisciplinaNome", "ProvaId" },
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TopicoNetos",
                columns: table => new
                {
                    TopicoNetoNome = table.Column<string>(type: "varchar(180)", maxLength: 180, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TopicoFilhoNome = table.Column<string>(type: "varchar(180)", maxLength: 180, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TopicoPaiNome = table.Column<string>(type: "varchar(180)", maxLength: 180, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisciplinaNome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProvaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicoNetos", x => new { x.TopicoNetoNome, x.TopicoFilhoNome, x.TopicoPaiNome, x.DisciplinaNome, x.ProvaId });
                    table.ForeignKey(
                        name: "FK_TopicoNetos_TopicoFilhos_TopicoFilhoNome_TopicoPaiNome_Disci~",
                        columns: x => new { x.TopicoFilhoNome, x.TopicoPaiNome, x.DisciplinaNome, x.ProvaId },
                        principalTable: "TopicoFilhos",
                        principalColumns: new[] { "TopicoFilhoNome", "TopicoPaiNome", "DisciplinaNome", "ProvaId" },
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
                name: "IX_TopicoFilhos_TopicoPaiNome_DisciplinaNome_ProvaId",
                table: "TopicoFilhos",
                columns: new[] { "TopicoPaiNome", "DisciplinaNome", "ProvaId" });

            migrationBuilder.CreateIndex(
                name: "IX_TopicoNetos_TopicoFilhoNome_TopicoPaiNome_DisciplinaNome_Pro~",
                table: "TopicoNetos",
                columns: new[] { "TopicoFilhoNome", "TopicoPaiNome", "DisciplinaNome", "ProvaId" });

            migrationBuilder.CreateIndex(
                name: "IX_Topicos_DiscipddddddlinaNome_ProvaId",
                table: "Topicos",
                columns: new[] { "DiscipddddddlinaNome", "ProvaId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TopicoNetos");

            migrationBuilder.DropTable(
                name: "TopicoFilhos");

            migrationBuilder.DropTable(
                name: "Topicos");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Provas");

            migrationBuilder.DropTable(
                name: "Concursos");
        }
    }
}
