using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiTreino.Migrations
{
    /// <inheritdoc />
    public partial class SeedingSimples : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intervencoes_Processos_ProcessoId",
                table: "Intervencoes");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Intervencoes");

            migrationBuilder.AlterColumn<int>(
                name: "ProcessoId",
                table: "Intervencoes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Processos",
                columns: new[] { "Id", "Descricao", "Titulo" },
                values: new object[,]
                {
                    { -2, "Preciso de uma dashboard para visualizar as compras.", "Power BI de compras" },
                    { -1, "A tela está avariada.", "Avaria de computador" }
                });

            migrationBuilder.InsertData(
                table: "Intervencoes",
                columns: new[] { "Id", "Descricao", "ProcessoId" },
                values: new object[,]
                {
                    { -4, "Foi desenvolvido um protótipo funcional com alguns gráficos básicos.", -2 },
                    { -3, "Levantamento de requisitos.", -2 },
                    { -2, "Foram efetuados testes de diagnóstico. Ficou tudo operacional.", -1 },
                    { -1, "Abriu-se o pc e verificou-se que o cabo de ligação ao ecrã estava danificado. Substitui-se o cabo.", -1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Intervencoes_Processos_ProcessoId",
                table: "Intervencoes",
                column: "ProcessoId",
                principalTable: "Processos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intervencoes_Processos_ProcessoId",
                table: "Intervencoes");

            migrationBuilder.DeleteData(
                table: "Intervencoes",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Intervencoes",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Intervencoes",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Intervencoes",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Processos",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Processos",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.AlterColumn<int>(
                name: "ProcessoId",
                table: "Intervencoes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Intervencoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Intervencoes_Processos_ProcessoId",
                table: "Intervencoes",
                column: "ProcessoId",
                principalTable: "Processos",
                principalColumn: "Id");
        }
    }
}
