using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoLivros.Migrations
{
    /// <inheritdoc />
    public partial class CorrigindoTPH : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CapaDura",
                table: "Livros",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Preco",
                table: "Livros",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TamanhoArquivoMb",
                table: "Livros",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoLivro",
                table: "Livros",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CapaDura",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "TamanhoArquivoMb",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "TipoLivro",
                table: "Livros");
        }
    }
}
