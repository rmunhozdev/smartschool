﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool.WebAPI.Data;

namespace SmartSchool.WebAPI.Migrations
{
    [DbContext(typeof(SmartContext))]
    [Migration("20200524211342_fourth")]
    partial class fourth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("datetime2");

                    b.Property<int>("Matricula")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataIni = new DateTime(2020, 5, 24, 18, 13, 42, 482, DateTimeKind.Local).AddTicks(9721),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 1,
                            Nome = "Marta",
                            Sobrenome = "Kent",
                            Telefone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataIni = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(1311),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 2,
                            Nome = "Paula",
                            Sobrenome = "Isabela",
                            Telefone = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataIni = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(1366),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 3,
                            Nome = "Laura",
                            Sobrenome = "Antonia",
                            Telefone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataIni = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(1372),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 4,
                            Nome = "Luiza",
                            Sobrenome = "Maria",
                            Telefone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataIni = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(1376),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 5,
                            Nome = "Lucas",
                            Sobrenome = "Machado",
                            Telefone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            Ativo = true,
                            DataIni = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(1383),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 6,
                            Nome = "Pedro",
                            Sobrenome = "Alvares",
                            Telefone = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            Ativo = true,
                            DataIni = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(1388),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 7,
                            Nome = "Paulo",
                            Sobrenome = "José",
                            Telefone = "9874512"
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoCurso", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("datetime2");

                    b.HasKey("AlunoId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("AlunosCursos");
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Datani")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Nota")
                        .HasColumnType("int");

                    b.HasKey("AlunoId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("AlunosDisciplinas");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 2,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(2565)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 4,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3301)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 5,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3370)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 1,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3376)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 2,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3380)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 5,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3483)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 1,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3490)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 2,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3492)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 3,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3494)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 1,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3500)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 4,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3503)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 5,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3505)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 4,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3506)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 5,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3507)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 1,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3509)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 2,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3510)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 3,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3511)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 4,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3514)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 1,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3516)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 2,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3517)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 3,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3518)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 4,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3519)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 5,
                            Datani = new DateTime(2020, 5, 24, 18, 13, 42, 483, DateTimeKind.Local).AddTicks(3521)
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Tecnologia da Informação"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Sistemas de Informação"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Ciência da Computação"
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("int");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PrerequisitoId")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("PrerequisitoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 2,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 3,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Física",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 4,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 5,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 6,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 7,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 8,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 9,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 10,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Programação",
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Registro")
                        .HasColumnType("int");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataIni = new DateTime(2020, 5, 24, 18, 13, 42, 478, DateTimeKind.Local).AddTicks(9049),
                            Nome = "Lauro",
                            Registro = 1,
                            Sobrenome = "Oliveira"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataIni = new DateTime(2020, 5, 24, 18, 13, 42, 479, DateTimeKind.Local).AddTicks(8716),
                            Nome = "Roberto",
                            Registro = 2,
                            Sobrenome = "Soares"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataIni = new DateTime(2020, 5, 24, 18, 13, 42, 479, DateTimeKind.Local).AddTicks(8765),
                            Nome = "Ronaldo",
                            Registro = 3,
                            Sobrenome = "Marconi"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataIni = new DateTime(2020, 5, 24, 18, 13, 42, 479, DateTimeKind.Local).AddTicks(8767),
                            Nome = "Rodrigo",
                            Registro = 4,
                            Sobrenome = "Carvalho"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataIni = new DateTime(2020, 5, 24, 18, 13, 42, 479, DateTimeKind.Local).AddTicks(8769),
                            Nome = "Alexandre",
                            Registro = 5,
                            Sobrenome = "Montanha"
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoCurso", b =>
                {
                    b.HasOne("SmartSchool.WebAPI.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.WebAPI.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("SmartSchool.WebAPI.Models.Aluno", "Aluno")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.WebAPI.Models.Disciplina", "Disciplina")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Disciplina", b =>
                {
                    b.HasOne("SmartSchool.WebAPI.Models.Curso", "Curso")
                        .WithMany("Disciplinas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.WebAPI.Models.Disciplina", "Prerequisito")
                        .WithMany()
                        .HasForeignKey("PrerequisitoId");

                    b.HasOne("SmartSchool.WebAPI.Models.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
