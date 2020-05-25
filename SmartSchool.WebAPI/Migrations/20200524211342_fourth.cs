using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.WebAPI.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Datani",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "Datani",
                table: "AlunosCursos");

            migrationBuilder.DropColumn(
                name: "Datani",
                table: "Alunos");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataIni",
                table: "Professores",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataIni",
                table: "AlunosCursos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataIni",
                table: "Alunos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 482, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataIni",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataIni",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 2 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 4 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 5 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 1 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 2 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 5 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 1 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 2 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 3 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 1 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 4 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 5 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 4 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 5 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 1 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 2 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 3 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 4 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 1 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 2 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 3 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 4 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 5 },
                column: "Datani",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 478, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 479, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 479, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 479, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2020, 5, 24, 18, 13, 42, 479, DateTimeKind.Local).AddTicks(8769));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataIni",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "DataIni",
                table: "AlunosCursos");

            migrationBuilder.DropColumn(
                name: "DataIni",
                table: "Alunos");

            migrationBuilder.AddColumn<DateTime>(
                name: "Datani",
                table: "Professores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Datani",
                table: "AlunosCursos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Datani",
                table: "Alunos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 305, DateTimeKind.Local).AddTicks(6471));

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

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 300, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 2,
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 301, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 3,
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 301, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4,
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 301, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 5,
                column: "Datani",
                value: new DateTime(2020, 5, 24, 17, 36, 13, 301, DateTimeKind.Local).AddTicks(8924));
        }
    }
}
