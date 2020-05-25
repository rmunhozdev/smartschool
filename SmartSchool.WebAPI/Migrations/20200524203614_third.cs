using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.WebAPI.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Professores",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFim",
                table: "Professores",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Datani",
                table: "Professores",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Registro",
                table: "Professores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "Professores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Professores",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CargaHoraria",
                table: "Disciplinas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "Disciplinas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrerequisitoId",
                table: "Disciplinas",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFim",
                table: "AlunosDisciplinas",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Datani",
                table: "AlunosDisciplinas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Nota",
                table: "AlunosDisciplinas",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Alunos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFim",
                table: "Alunos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNasc",
                table: "Alunos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Datani",
                table: "Alunos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Matricula",
                table: "Alunos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlunosCursos",
                columns: table => new
                {
                    AlunoId = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: false),
                    Datani = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosCursos", x => new { x.AlunoId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_AlunosCursos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunosCursos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Ativo", "DataNasc", "Datani", "Matricula" },
                values: new object[] { true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(4740), 1 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Ativo", "DataNasc", "Datani", "Matricula" },
                values: new object[] { true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(6391), 2 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Ativo", "DataNasc", "Datani", "Matricula" },
                values: new object[] { true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(6447), 3 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Ativo", "DataNasc", "Datani", "Matricula" },
                values: new object[] { true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(6454), 4 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Ativo", "DataNasc", "Datani", "Matricula" },
                values: new object[] { true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(6458), 5 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Ativo", "DataNasc", "Datani", "Matricula" },
                values: new object[] { true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(6466), 6 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Ativo", "DataNasc", "Datani", "Matricula" },
                values: new object[] { true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(6471), 7 });

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 2 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 4 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 5 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 1 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 2 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 5 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 1 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 2 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 3 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 1 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 4 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 5 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 4 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 5 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 1 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 2 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 3 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 4 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 1 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 2 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 3 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 4 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 5 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 2, "Sistemas de Informação" },
                    { 3, "Ciência da Computação" },
                    { 1, "Tecnologia da Informação" }
                });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Ativo", "Datani", "Registro", "Sobrenome" },
                values: new object[] { true, new DateTime(2020, 5, 24, 17, 36, 13, 300, DateTimeKind.Local).AddTicks(6202), 1, "Oliveira" });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Ativo", "Datani", "Registro", "Sobrenome" },
                values: new object[] { true, new DateTime(2020, 5, 24, 17, 36, 13, 301, DateTimeKind.Local).AddTicks(8854), 2, "Soares" });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Ativo", "Datani", "Registro", "Sobrenome" },
                values: new object[] { true, new DateTime(2020, 5, 24, 17, 36, 13, 301, DateTimeKind.Local).AddTicks(8920), 3, "Marconi" });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Ativo", "Datani", "Registro", "Sobrenome" },
                values: new object[] { true, new DateTime(2020, 5, 24, 17, 36, 13, 301, DateTimeKind.Local).AddTicks(8923), 4, "Carvalho" });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Ativo", "Datani", "Registro", "Sobrenome" },
                values: new object[] { true, new DateTime(2020, 5, 24, 17, 36, 13, 301, DateTimeKind.Local).AddTicks(8924), 5, "Montanha" });

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CursoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CursoId", "Nome", "ProfessorId" },
                values: new object[] { 3, "Matemática", 1 });

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CursoId", "Nome", "ProfessorId" },
                values: new object[] { 3, "Física", 2 });

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CursoId", "Nome", "ProfessorId" },
                values: new object[] { 1, "Português", 3 });

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CursoId", "Nome", "ProfessorId" },
                values: new object[] { 1, "Inglês", 4 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "CargaHoraria", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[,]
                {
                    { 8, 0, 1, "Programação", null, 5 },
                    { 6, 0, 2, "Inglês", null, 4 },
                    { 9, 0, 2, "Programação", null, 5 },
                    { 7, 0, 3, "Inglês", null, 4 },
                    { 10, 0, 3, "Programação", null, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_CursoId",
                table: "Disciplinas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_PrerequisitoId",
                table: "Disciplinas",
                column: "PrerequisitoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunosCursos_CursoId",
                table: "AlunosCursos",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplinas_Cursos_CursoId",
                table: "Disciplinas",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplinas_Disciplinas_PrerequisitoId",
                table: "Disciplinas",
                column: "PrerequisitoId",
                principalTable: "Disciplinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplinas_Cursos_CursoId",
                table: "Disciplinas");

            migrationBuilder.DropForeignKey(
                name: "FK_Disciplinas_Disciplinas_PrerequisitoId",
                table: "Disciplinas");

            migrationBuilder.DropTable(
                name: "AlunosCursos");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Disciplinas_CursoId",
                table: "Disciplinas");

            migrationBuilder.DropIndex(
                name: "IX_Disciplinas_PrerequisitoId",
                table: "Disciplinas");

            migrationBuilder.DeleteData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "DataFim",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "Datani",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "Registro",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "CargaHoraria",
                table: "Disciplinas");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "Disciplinas");

            migrationBuilder.DropColumn(
                name: "PrerequisitoId",
                table: "Disciplinas");

            migrationBuilder.DropColumn(
                name: "DataFim",
                table: "AlunosDisciplinas");

            migrationBuilder.DropColumn(
                name: "Datani",
                table: "AlunosDisciplinas");

            migrationBuilder.DropColumn(
                name: "Nota",
                table: "AlunosDisciplinas");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "DataFim",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "DataNasc",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Datani",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Matricula",
                table: "Alunos");

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Nome", "ProfessorId" },
                values: new object[] { "Física", 2 });

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Nome", "ProfessorId" },
                values: new object[] { "Português", 3 });

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Nome", "ProfessorId" },
                values: new object[] { "Inglês", 4 });

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Nome", "ProfessorId" },
                values: new object[] { "Programação", 5 });
        }
    }
}
