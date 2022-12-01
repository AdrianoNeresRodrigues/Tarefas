using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tarefas.Data.Migrations
{
    public partial class Tarefas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Listas",
                columns: table => new
                {
                    ListaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListaNome = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ListaDataLembrete = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ListaLembrete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListaPaiListaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listas", x => x.ListaId);
                    table.ForeignKey(
                        name: "FK_Listas_Listas_ListaPaiListaId",
                        column: x => x.ListaPaiListaId,
                        principalTable: "Listas",
                        principalColumn: "ListaId");
                });

            migrationBuilder.CreateTable(
                name: "Tarefas",
                columns: table => new
                {
                    TarefaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TarefaDescricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarefaPrioridade = table.Column<int>(type: "int", nullable: false),
                    TarefaDataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TarefaDataLembrete = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TarefaLembrete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TarefaDataVencimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TarefaDataConclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ListaPaiListaId = table.Column<int>(type: "int", nullable: true),
                    TarefaPaiTarefaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas", x => x.TarefaId);
                    table.ForeignKey(
                        name: "FK_Tarefas_Listas_ListaPaiListaId",
                        column: x => x.ListaPaiListaId,
                        principalTable: "Listas",
                        principalColumn: "ListaId");
                    table.ForeignKey(
                        name: "FK_Tarefas_Tarefas_TarefaPaiTarefaId",
                        column: x => x.TarefaPaiTarefaId,
                        principalTable: "Tarefas",
                        principalColumn: "TarefaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Listas_ListaPaiListaId",
                table: "Listas",
                column: "ListaPaiListaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_ListaPaiListaId",
                table: "Tarefas",
                column: "ListaPaiListaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_TarefaPaiTarefaId",
                table: "Tarefas",
                column: "TarefaPaiTarefaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefas");

            migrationBuilder.DropTable(
                name: "Listas");
        }
    }
}
