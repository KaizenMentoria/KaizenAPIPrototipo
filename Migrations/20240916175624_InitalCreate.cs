using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaizenAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    Endereco_CEP = table.Column<string>(type: "text", nullable: false),
                    Endereco_Logradouro = table.Column<string>(type: "text", nullable: false),
                    Endereco_Numero = table.Column<string>(type: "text", nullable: false),
                    Endereco_Complemento = table.Column<string>(type: "text", nullable: false),
                    Endereco_Bairro = table.Column<string>(type: "text", nullable: false),
                    Endereco_Localidade = table.Column<string>(type: "text", nullable: false),
                    Endereco_UF = table.Column<string>(type: "text", nullable: false),
                    Endereco_DDD = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");
        }
    }
}
