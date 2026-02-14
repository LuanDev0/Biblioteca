using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoLivros.Migrations
{
    /// <inheritdoc />
    public partial class AddRelacaoMusicaGenero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneroLivro",
                columns: table => new
                {
                    GenerosId = table.Column<int>(type: "int", nullable: false),
                    LivroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneroLivro", x => new { x.GenerosId, x.LivroId });
                    table.ForeignKey(
                        name: "FK_GeneroLivro_Generos_GenerosId",
                        column: x => x.GenerosId,
                        principalTable: "Generos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneroLivro_Livros_LivroId",
                        column: x => x.LivroId,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GeneroLivro_LivroId",
                table: "GeneroLivro",
                column: "LivroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneroLivro");
        }
    }
}
