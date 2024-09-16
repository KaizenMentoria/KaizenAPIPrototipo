using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaizenAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAlunoEnderecosConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endereco_Bairro",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Endereco_CEP",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Endereco_Complemento",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Endereco_DDD",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Endereco_Localidade",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Endereco_Logradouro",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Endereco_Numero",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Endereco_UF",
                table: "Alunos");

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CEP = table.Column<string>(type: "text", nullable: false),
                    Logradouro = table.Column<string>(type: "text", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: false),
                    Complemento = table.Column<string>(type: "text", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    Localidade = table.Column<string>(type: "text", nullable: false),
                    UF = table.Column<string>(type: "text", nullable: false),
                    DDD = table.Column<string>(type: "text", nullable: false),
                    AlunoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endereco_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_AlunoId",
                table: "Endereco",
                column: "AlunoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.AddColumn<string>(
                name: "Endereco_Bairro",
                table: "Alunos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco_CEP",
                table: "Alunos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco_Complemento",
                table: "Alunos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco_DDD",
                table: "Alunos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco_Localidade",
                table: "Alunos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco_Logradouro",
                table: "Alunos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco_Numero",
                table: "Alunos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco_UF",
                table: "Alunos",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
