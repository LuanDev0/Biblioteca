using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoLivros.Migrations
{
    /// <inheritdoc />
    public partial class RelacionandoLivroBox : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autores_AutorId",
                table: "Livros");

            migrationBuilder.AlterColumn<int>(
                name: "AutorId",
                table: "Livros",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BoxId",
                table: "Livros",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Livros_BoxId",
                table: "Livros",
                column: "BoxId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autores_AutorId",
                table: "Livros",
                column: "AutorId",
                principalTable: "Autores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Boxes_BoxId",
                table: "Livros",
                column: "BoxId",
                principalTable: "Boxes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autores_AutorId",
                table: "Livros");

            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Boxes_BoxId",
                table: "Livros");

            migrationBuilder.DropIndex(
                name: "IX_Livros_BoxId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "BoxId",
                table: "Livros");

            migrationBuilder.AlterColumn<int>(
                name: "AutorId",
                table: "Livros",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autores_AutorId",
                table: "Livros",
                column: "AutorId",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
